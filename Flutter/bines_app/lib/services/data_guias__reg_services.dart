import 'dart:convert' as convert;
//import 'dart:convert';
import 'package:bines_app/providers/providers.dart';
import 'package:http/http.dart' as http;

//class DataGuiasRegServices extends ChangeNotifier {
class DataGuiasRegServices {
  List<RegisteredGuias> listadoGrReg = [];
  final serverport = '10.20.4.38:8077';
  bool insertados = false;
  DataGuiasRegServices();

  Future loadGuiasRegistradas(String tipo, String opcion) async {
    bool flag = false;
    final parametros = {"nroguia": "", "opcion": tipo};
    final uri = Uri.http(serverport,
        '/api-app-control-time/obtenerguiasregistradas', parametros);
    final responseGuiasReg = await http.get(
      uri,
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
      },
    );

    print('Server');
    print(serverport);
    final List<dynamic> listguiasMap =
        convert.jsonDecode(responseGuiasReg.body);
    if (listguiasMap.isNotEmpty) {
      //Borramos los datos de las tablas no sincronziadas
      for (Map<String, dynamic> guias in listguiasMap) {
        /*
          --------------------------------------------
          Obtiene las guias del dìa
          --------------------------------------------
        */
        final double kg = double.parse(guias['can_kg'].toString());
        final int cantescaneada = int.parse(guias['cant_bines'].toString());
        final int sincronizado = int.parse(guias['sincronizado'].toString());
        final int activo = int.parse(guias['activo'].toString());
        final String tipoproceso = guias['tipo_proceso'];
        final String nroguia = guias['nro_guia'];
        final String fechaguia = guias['fec_pesc'];
        final String piscina = guias['nro_pisc'];

        //borramos las guias registradas con ese tipo de proceso
        if (flag == false) {
          //print(tipoproceso);
          await RegisteredGuiasProvider().borrarGuiasRegistradas(tipoproceso);
          flag = true;
        }
        /* final binesAct = await BinGrAsignado().updateEstadoGuia(nroguia, 0); */
        final guiasRec = await RegisteredGuiasProvider().nuevaGuiaRegistrada(
            tipoproceso,
            nroguia,
            fechaguia,
            kg,
            piscina,
            cantescaneada,
            sincronizado,
            activo);

        /*
          --------------------------------------------
            Obtiene e Inserta los bines y sus guias
          --------------------------------------------
        */
        /*
          --------------------------------------------
            Consumimos el Api 
          --------------------------------------------
        */
        final queryParameters = {
          "nroguia": guias['nro_guia'],
          "opcion": opcion
        };
        final uri = Uri.http(serverport,
            '/api-app-control-time/obtenerbinesguia', queryParameters);
        //final headers = {HttpHeaders.contentTypeHeader: 'application/json'};
        final responseBin = await http.get(
          uri,
          headers: <String, String>{
            'Content-Type': 'application/json; charset=UTF-8',
          },
        );
        final List<dynamic> listGuiasBinMap =
            convert.jsonDecode(responseBin.body);
        /*
          --------------------------------------------
          Borrar los datos de las guias 
          --------------------------------------------
        */
        await DBProvider.db.borrarBinesGuiasSincReg(nroguia, tipoproceso);
        /*
          --------------------------------------------
          Recorre el json que viene desde el Api de Bines
          --------------------------------------------
        */
        for (Map<String, dynamic> guiasBin in listGuiasBinMap) {
          /* final nuevoBinGuia = BinesGrAsigModel(
              nroguia: guiasBin['nroguia'],
              nrobin: guiasBin['nrobin'],
              fechahora: guiasBin['fechahora'],
              sincronizado: guiasBin['sincronizado'],
              activo: guiasBin['activo']); */
          int bin = guiasBin['nrobin'];
          String fechahoraing = guiasBin['fechahora'];
          int sincbin = guiasBin['sincronizado'];
          int actbin = guiasBin['activo'];
          final guiasBinReg = await RegisteredBinGuiasProvider()
              .nuevaGuiaBinAsignadoReg(
                  tipoproceso, nroguia, bin, fechahoraing, sincbin, actbin);
        }
      }
    }
    return listadoGrReg;
  }
}
