import 'dart:convert' as convert;
/* import 'dart:html'; */
import 'package:bines_app/models/models.dart';
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

    //se debe leer cada uno de los items por que se tiene un id y las descripciones,
    //en este sentido el codigo y sus caracteristicas
    /*  listguiasMap.forEach((key, value) {
      final tempListGuias = AssiggrModel.fromJson(value);
      tempListGuias.nroguia = key;
      productos.add(tempProduct);
    }); */
    print(response);

    isLoading = false;
    //notificamos  a otro cualquier otro widget que se desea
    notifyListeners();
    return listadoGr;
  }
}
