import 'package:bines_app/models/models.dart';
import 'package:bines_app/providers/providers.dart';
import 'package:flutter/material.dart';

class AssiggrListProvider extends ChangeNotifier {
  List<AssiggrModel> asignados = [];
  List<BinesGrAsigModel> binAsignados = [];

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

  Future<BinesGrAsigModel> nuevaGuiaBinAsignado(String nroguia, int nrobin,
      String fechahora, int sincronizado, int activo) async {
    final nuevoBinGuia = BinesGrAsigModel(
        nroguia: nroguia,
        nrobin: nrobin,
        fechahora: fechahora,
        sincronizado: sincronizado,
        activo: activo);
    nuevoBinGuia.nrobin =
        await DBProvider.db.insertBinGrAsiganadas(nuevoBinGuia);
    binAsignados.add(nuevoBinGuia);
    notifyListeners();
    return nuevoBinGuia;
  }

  cargarBinAsignadas(String nroguia) async {
    final binAsignados = await DBProvider.db.consultaBinAsignadas(nroguia);
    /*  print(binAsignados); */
    this.binAsignados = [...?binAsignados];
    notifyListeners();
  }

  borrarBinGuia(String nroguia, int nrobin) async {
    await DBProvider.db.borrarBinEscanead(nroguia, nrobin);
    cargarBinAsignadas(nroguia);
  }
}
