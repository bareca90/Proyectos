import 'dart:convert' as convert;
import 'dart:convert';
/* import 'dart:html'; */
/* import 'package:bines_app/models/models.dart'; */
import 'package:bines_app/providers/providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:http/http.dart' as http;

class DataGuiasRegServices extends ChangeNotifier {
  final List<RegisteredGuias> listadoGrReg = [];
  bool isLoading = true;
  bool insertados = false;

  DataGuiasRegServices() {
    loadGuiasRegistradas();
  }
  /* final String _baseUrl =
      'http://10.20.4.38:8077/api-app-control-time/obtenerbinesguia'; */
  Future<List<RegisteredGuias>> loadGuiasRegistradas() async {
    isLoading = true;
    //notificamos  a otro cualquier otro widget que se desea
    notifyListeners();

    final parametros = {"nroguia": "", "opcion": "OGCE"};
    final uri = Uri.http('10.20.4.38:8077',
        '/api-app-control-time/obtenerbinesguia', parametros);
    //final headers = {HttpHeaders.contentTypeHeader: 'application/json'};
    final responseGuiasReg = await http.get(
      uri,
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
      },
    );
    print('Entro al servicio ');
    print(responseGuiasReg.body);
    /* final response = await http.get(Uri.parse(_baseUrl)); */
    /*  print(responseGuiasReg.body);
    final List<dynamic> listguiasMap =
        convert.jsonDecode(responseGuiasReg.body);
    if (listguiasMap.isNotEmpty) {
      
    }
    isLoading = false;
    //notificamos  a otro cualquier otro widget que se desea
    notifyListeners(); */
    return listadoGrReg;
  }
}
