import 'dart:convert' as convert;
import 'dart:convert';
/* import 'dart:html'; */
/* import 'package:bines_app/models/models.dart'; */
import 'package:bines_app/providers/providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:http/http.dart' as http;

class DataGuiaBinServices extends ChangeNotifier {
  List<BinesGrAsigModel> binAsignadosGuias = [];
  bool isLoading = true;
  DataGuiaBinServices();

  //listaBinGuiaAsignada.cargarBinAsignadas(nroguia);
  Future<String> insertBinGuias(BinGrAsignado listaBinGuiaAsignada) async {
    //final listaBinGuiaAsignada = BinGrAsignado().cargarBinAsignadas(nroguia);
    /* final listaBinGuiaAsignada =
        await DBProvider.db.consultaBinAsignadas(nroguia); */

    //TODO : Validar que exista conexion con el api
    const String opcion = 'RBG'; //Registro Bin GUia
    for (int index = 0;
        index < listaBinGuiaAsignada.binAsignados.length;
        index++) {
      final int nrobin = listaBinGuiaAsignada.binAsignados[index].nrobin;
      final String fechora = listaBinGuiaAsignada.binAsignados[index].fechahora;
      final String nroguia = listaBinGuiaAsignada.binAsignados[index].nroguia;
      final int sincronizo =
          listaBinGuiaAsignada.binAsignados[index].sincronizado;
      if (sincronizo == 0) {
        //si fue sincronizado no lo considero
        final response = await http.post(
            Uri.parse('http://10.20.4.38:8077/api-app-control-time/binesguia'),
            headers: <String, String>{
              'Content-Type': 'application/json; charset=UTF-8',
            },
            body: jsonEncode(<String, dynamic>{
              "opcion": opcion,
              "nroguia": nroguia,
              "nrobin": nrobin,
              "fechahra": fechora
            }));

        final List<dynamic> decodedResp = json.decode(response.body);
        final dynamic cod = decodedResp[0]['codmsg'];
        if (cod == 200) {
          final actualizado =
              await DBProvider.db.actSincGrBines(nroguia, 0, 1, nrobin);
          print('Cod Ok');
        } else {
          print('Cod Error ');
        }
      }
      /* print('Datos de la Respuesta ${response.body} '); */
    }
    isLoading = false;
    notifyListeners();
    return opcion;
  }

  cargarBinAsignadasServ(String nroguia) async {
    final binAsignadosGuias = await DBProvider.db.consultaBinAsignadas(nroguia);
    this.binAsignadosGuias = [...?binAsignadosGuias];
    /* catidadBinesEscaneados(nroguia); */
    notifyListeners();
  }
}
