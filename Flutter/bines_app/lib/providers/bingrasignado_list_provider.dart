import 'package:bines_app/models/models.dart';
import 'package:bines_app/providers/providers.dart';
import 'package:flutter/material.dart';

class BinGrAsignado extends ChangeNotifier {
  List<BinesGrAsigModel> binAsignados = [];
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
    this.binAsignados = [...?binAsignados];
    print(binAsignados);
    notifyListeners();
  }

  borrarBinGuia(String nroguia, int nrobin) async {
    await DBProvider.db.borrarBinEscanead(nroguia, nrobin);
    cargarBinAsignadas(nroguia);
  }

  borrarBinesGuia(String nroguia) async {
    await DBProvider.db.borrarBinesGuias(nroguia);
    cargarBinAsignadas(nroguia);
  }
}
