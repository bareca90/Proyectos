import 'dart:convert' as convert;
//import 'dart:convert';
import 'package:bines_app/providers/providers.dart';
import 'package:http/http.dart' as http;

//class DataGuiasRegServices extends ChangeNotifier {
class DataGuiasRegServices {
  List<RegisteredGuias> listadoGrReg = [];
  /* bool isLoading = true; */
  bool insertados = false;
  DataGuiasRegServices();
  /* DataGuiasRegServices() {
    loadGuiasRegistradas();
  } */
  /* final String _baseUrl =
      'http://10.20.4.38:8077/api-app-control-time/obtenerbinesguia'; */
  Future loadGuiasRegistradas(String tipo) async {
    /* isLoading = true; */
    //notificamos  a otro cualquier otro widget que se desea
    bool flag = false;
    final parametros = {"nroguia": "", "opcion": tipo};
    final uri = Uri.http('10.20.4.38:8077',
        '/api-app-control-time/obtenerbinesguia', parametros);
    //final headers = {HttpHeaders.contentTypeHeader: 'application/json'};
    final responseGuiasReg = await http.get(
      uri,
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
      },
    );

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
      }
    }
    return listadoGrReg;
  }
}
