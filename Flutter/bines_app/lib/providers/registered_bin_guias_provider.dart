import 'package:bines_app/models/models.dart';
import 'package:bines_app/providers/providers.dart';
import 'package:bines_app/services/services.dart';
import 'package:flutter/material.dart';
import 'package:flutter/scheduler.dart';

class RegisteredBinGuiasProvider extends ChangeNotifier {
  List<RegisteredBinGuias> binAsignadosReg = [];
  int cantescaneados = 0;
  int actualizado = 0;
  Future<RegisteredBinGuias> nuevaGuiaBinAsignadoReg(
      String tipoproceso,
      String nroguia,
      int nrobin,
      String fechahoraesc,
      int sincronizado,
      int activo) async {
    final nuevoBinGuiaReg = RegisteredBinGuias(
        tipoproceso: tipoproceso,
        nroguia: nroguia,
        nrobin: nrobin,
        fechahoraesc: fechahoraesc,
        activo: activo,
        sincronizado: sincronizado);

    nuevoBinGuiaReg.nrobin =
        await DBProvider.db.insertBinGrReg(nuevoBinGuiaReg);
    binAsignadosReg.add(nuevoBinGuiaReg);
    notifyListeners();
    return nuevoBinGuiaReg;
  }

  cargarBinAsignadasReg(String nroguia, String tipoproceso) async {
    final binAsignadosReg =
        await DBProvider.db.consultaBinAsignadasReg(nroguia, tipoproceso);
    this.binAsignadosReg = [...?binAsignadosReg];
    catidadBinesEscaneadosReg(nroguia, tipoproceso);
    notifyListeners();
  }

  borrarBinesGuiaReg(String nroguia, String tipoproceso) async {
    await DBProvider.db.borrarBinesGuias(nroguia);
    cargarBinAsignadasReg(nroguia, tipoproceso);
  }

  borrarBinGuiaReg(String nroguia, int nrobin, String tipoproceso) async {
    await DBProvider.db.borrarBinEscaneadReg(nroguia, nrobin, tipoproceso);
    cargarBinAsignadasReg(nroguia, tipoproceso);
  }

  catidadBinesEscaneadosReg(String nroguia, String tipoproceso) async {
    final cantescaneados =
        await DBProvider.db.cantidadBinesEscaneadosReg(nroguia, tipoproceso);
    this.cantescaneados = cantescaneados;
    notifyListeners();
  }

  updateBinesSincronizadosReg(String nroguia, int activo, int sincronizado,
      int nrobin, String tipoproceso) async {
    final actualizado = await DBProvider.db
        .actSincGrBinesReg(nroguia, activo, sincronizado, nrobin, tipoproceso);
    this.actualizado = actualizado;
    cargarBinAsignadasReg(nroguia, tipoproceso);
    notifyListeners();
  }

  //Recibo los datos y los envio uno por uno
  updateGuiaBinReg(RegisteredBinGuiasProvider datosGuiasReg, String opcion,
      String numGuia, String tipoProceso) {
    DateTime now = DateTime.now();
    final String fecha = now.toString();
    for (int index = 0; index < datosGuiasReg.binAsignadosReg.length; index++) {
      final String nroguia = datosGuiasReg.binAsignadosReg[index].nroguia;
      final int nrobin = datosGuiasReg.binAsignadosReg[index].nrobin;
      final String tipoproceso =
          datosGuiasReg.binAsignadosReg[index].tipoproceso;
      updateFechaBinReg(nroguia, nrobin, tipoproceso, fecha);
    }
    consumeApiReg(opcion, numGuia, fecha, tipoProceso);
  }

  consumeApiReg(
      String opcion, String nroguia, String fecha, String tipoProceso) async {
    final services = DataGuiasRegServices();
    final actualizado =
        await services.updateRegGuiasBD(opcion, nroguia, fecha, tipoProceso);

    this.actualizado = actualizado;
    cargarBinAsignadasReg(nroguia, tipoProceso);
    notifyListeners();
  }

  actualizarEstadosRegBin(
      String nroguia, String tipoproceso, int activo, int sincronizado) async {
    final actualizado = await DBProvider.db
        .actEstadoBinesReg(nroguia, activo, sincronizado, tipoproceso);
    this.actualizado = actualizado;
    cargarBinAsignadasReg(nroguia, tipoproceso);
    notifyListeners();
  }

  updateFechaBinReg(
      String nroguia, int bin, String tipoproceso, String fecha) async {
    final actualizado =
        await DBProvider.db.actBinReg(nroguia, bin, tipoproceso, fecha);
    this.actualizado = actualizado;
    cargarBinAsignadasReg(nroguia, tipoproceso);
    notifyListeners();
  }

  updateEstadoGuiaReg(String nroguia, int activo, String tipoproceso) async {
    final actualizado =
        await DBProvider.db.actGrEstadoReg(nroguia, activo, tipoproceso);
    this.actualizado = actualizado;
    cargarBinAsignadasReg(nroguia, tipoproceso);
    notifyListeners();
  }
}
