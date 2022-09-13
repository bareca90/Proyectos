import 'package:bines_app/providers/providers.dart';
import 'package:bines_app/services/services.dart';
import 'package:bines_app/widgets/widgets.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class AssigmentScreen extends StatelessWidget {
  const AssigmentScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    /* final listaGuiasAsignadas =
        Provider.of<AssiggrListProvider>(context, listen: false); */
    final listaGuiasServices = Provider.of<DataGuiasDayServices>(context);

    final listaGuiasAsignadas = Provider.of<AssiggrListProvider>(context);
    listaGuiasAsignadas.cargarGrAsignadas();

    return Scaffold(
      body: Scaffold(
        appBar: AppBar(
          title: const Text('Bin - Guìa'),
          actions: [
            IconButton(
                onPressed: () {
                  //aqui se debe controlar quitar la
                  //authServices.logout();
                  //Navigator.pushReplacementNamed(context, 'login');
                  /* final now = DateTime.now();
                  final berlinWallFell = DateTime.utc(1989, 11, 9); */
                  /* final moonLanding = DateTime.utc(2022, 08, 09); */
                  /* final insertVarios = listaGuiasAsignadas.nuevaGuiaPesca(
                      'G59558', '2022-08-01', 20, 's145', 10, 1, 1);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'G59578', '2022-08-01', 5, 'PIS14', 8, 0, 1);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'G59528', '2022-08-01', 10, 'C120', 12, 0, 1);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'G59598', '2022-08-01', 4, 'S45', 4, 1, 1);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'S59558', '2022-08-01', 8, 'G5', 3, 1, 1);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'G58558', '2022-10-01', 8, 'G5', 3, 1, 1);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'Y59558', '2022-05-01', 8, 'G5', 3, 0, 1);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'Z59574', '2022-05-01', 8, 'G5', 3, 1, 0);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'Z79574', '2022-05-01', 8, 'G5', 3, 1, 0);
                  listaGuiasAsignadas.nuevaGuiaPesca(
                      'Z4584', '2022-05-01', 8, 'G5', 3, 1, 0);
                  listaGuiasAsignadas.cargarGrAsignadas(); */
                },
                icon: const Icon(Icons.search))
          ],
        ),
        body: ListView.builder(
            //itemCount: productsServices.productos.length,
            itemCount: listaGuiasAsignadas.asignados.length,
            itemBuilder: (BuildContext context, int indice) => GestureDetector(
                // TODO Aqui navego a la pantalla de Productos
                onTap: () {
                  /* productsServices.selectedProduct =
                      productsServices.productos[indice].copy();
                  Navigator.pushNamed(context, 'product'); */
                  listaGuiasAsignadas.guiaSeleccionada =
                      listaGuiasAsignadas.asignados[indice].copy();

                  final nroguia = listaGuiasAsignadas.asignados[indice].nroguia;
                  final listaBinGuiaAsignada =
                      Provider.of<BinGrAsignado>(context, listen: false);
                  listaBinGuiaAsignada.cargarBinAsignadas(nroguia);
                  Navigator.pushNamed(context, 'asigbin');
                },
                child: AssigmentBinCard(
                  asignados: listaGuiasAsignadas.asignados[indice],
                  //product: productsServices.productos[indice],
                ))),
      ),
    );
  }
}
