import 'dart:convert' as convert;
/* import 'dart:html'; */
/* import 'package:bines_app/models/models.dart'; */
import 'package:bines_app/providers/providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:http/http.dart' as http;

class DataGuiasDayServices extends ChangeNotifier {
  final List<AssiggrModel> listadoGr = [];
  bool isLoading = true;

  DataGuiasDayServices() {
    loadGuiasDay();
  }
  final String _baseUrl =
      'http://10.20.4.38:8077/api-app-control-time/dataguiasdia';
  Future<List<AssiggrModel>> loadGuiasDay() async {
    isLoading = true;
    //notificamos  a otro cualquier otro widget que se desea
    notifyListeners();
    print('Antes de la Respuesta');
    final response = await http.get(Uri.parse(_baseUrl));
    /* final Map<String, dynamic> listguiasMap = convert.jsonDecode(response.body); */
    final List<dynamic> listguiasMap = convert.jsonDecode(response.body);
    if (listguiasMap.isNotEmpty) {
      //Borramos los datos de las tablas no sincronziadas
      //TODO : Borrar los datos de las guias no sincronizadas
      await DBProvider.db.borrarGuiasPesca('');
      //Recorremos el Json y Realizamos el Insert
      for (Map<String, dynamic> guias in listguiasMap) {
        /* print(guias['nro_guia']); */
        final double kg = double.parse(guias['can_kg'].toString());
        final nuevaGuiaPesca = AssiggrModel(
            nroguia: guias['nro_guia'],
            fecha: guias['fec_pesc'],
            /* kg: double.parse(guias['can_kg']), */
            kg: kg,
            piscina: guias['nro_pisc'],
            cant: 0,
            sincronizado: 0,
            activo: 1);
        nuevaGuiaPesca.nroguia =
            await DBProvider.db.insertAsiganadas(nuevaGuiaPesca);
        /* final insertVarios = listaGuiasAsignadas.nuevaGuiaPesca(
            'G59558', '2022-08-01', 20, 's145', 10, 1, 1); */

      }
    }
    isLoading = false;
    //notificamos  a otro cualquier otro widget que se desea
    notifyListeners();
    return listadoGr;
  }
}
