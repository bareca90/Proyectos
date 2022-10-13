import 'package:bines_app/models/models.dart';
import 'package:bines_app/providers/providers.dart';
import 'package:flutter/material.dart';

class RegisteredGuiasProvider extends ChangeNotifier {
  List<RegisteredGuias> registrados = [];
  /* List<BinesGrAsigModel> binAsignados = []; */

  late RegisteredGuias guiaSeleccionada;
  Future<RegisteredGuias> nuevaGuiaRegistrada(
      String tipoproceso,
      String nroguia,
      String fechaguia,
      double kg,
      String piscina,
      int cantescaneada,
      int sincronizado,
      int activo) async {
    final nuevaGuiaReg = RegisteredGuias(
        tipoproceso: tipoproceso,
        nroguia: nroguia,
        fechaguia: fechaguia,
        kg: kg,
        piscina: piscina,
        cantescaneada: cantescaneada,
        activo: activo,
        sincronizado: sincronizado);
    nuevaGuiaReg.nroguia = await DBProvider.db.insertGuiasReg(nuevaGuiaReg);
    registrados.add(nuevaGuiaReg);
    notifyListeners();
    return nuevaGuiaReg;
  }

  cargarGrRegistradas(String tipoproceso) async {
    final registrados = await DBProvider.db.consultaGrReg(tipoproceso);
    /* print(asignados); */
    this.registrados = [...?registrados];
    notifyListeners();
  }

  borrarGuiasRegistradas(String tipoproceso) async {
    await DBProvider.db.borrarGuiasReg(tipoproceso);
    cargarGrRegistradas(tipoproceso);
  }
}
