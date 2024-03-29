import 'package:bines_app/models/models.dart';
import 'package:bines_app/providers/providers.dart';
import 'package:flutter/material.dart';

class AssiggrListProvider extends ChangeNotifier {
  List<AssiggrModel> asignados = [];
  /* List<BinesGrAsigModel> binAsignados = []; */

  late AssiggrModel guiaSeleccionada;
  Future<AssiggrModel> nuevaGuiaPesca(String nroguia, String fecha, double kg,
      String piscina, int cant, int sincronizado, int activo) async {
    final nuevaGuiaPesca = AssiggrModel(
        nroguia: nroguia,
        fecha: fecha,
        kg: kg,
        piscina: piscina,
        cant: cant,
        sincronizado: sincronizado,
        activo: activo);
    nuevaGuiaPesca.nroguia =
        await DBProvider.db.insertAsiganadas(nuevaGuiaPesca);
    asignados.add(nuevaGuiaPesca);
    notifyListeners();
    return nuevaGuiaPesca;
  }

  cargarGrAsignadas() async {
    final asignados = await DBProvider.db.consultaGrAsignadas();
    /* print(asignados); */
    this.asignados = [...?asignados];
    notifyListeners();
  }

  borrarGuiasPesca(String nroguia) async {
    await DBProvider.db.borrarGuiasPesca(nroguia);
    cargarGrAsignadas();
  }
}
