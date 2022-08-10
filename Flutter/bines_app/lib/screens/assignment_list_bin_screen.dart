import 'package:bines_app/providers/providers.dart';
import 'package:bines_app/widgets/widgets.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class AssigmentScreen extends StatelessWidget {
  const AssigmentScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    /* final listaGuiasAsignadas =
        Provider.of<AssiggrListProvider>(context, listen: false); */
    final listaGuiasAsignadas = Provider.of<AssiggrListProvider>(context);

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
                  final insertVarios = listaGuiasAsignadas.nuevaGuiaPesca(
                      'G59578', '2022-08-01', 20, 's145', 10, 1, 1);
                  listaGuiasAsignadas.cargarGrAsignadas();
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
