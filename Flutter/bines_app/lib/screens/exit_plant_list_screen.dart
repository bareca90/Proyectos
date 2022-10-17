import 'package:bines_app/providers/providers.dart';

/* import 'package:bines_app/screens/search_guias_delegate.dart';
import 'package:bines_app/services/services.dart'; */
import 'package:bines_app/widgets/widgets.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ExitPlantListScreen extends StatelessWidget {
  const ExitPlantListScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    /* final listaGuiasAsignadas =
        Provider.of<AssiggrListProvider>(context, listen: false); */

    /* final listaGuiasServices =
        Provider.of<ServicesProvider>(context, listen: false);
    listaGuiasServices.llamarApiGuiasRegistradas('OGCE'); */

    final listadoGR = Provider.of<RegisteredGuiasProvider>(context);
    final guias = listadoGR.registrados;
    //listadoGR.cargarGrRegistradas('RSP');

    /* listaGuiasServices.loadGuiasRegistradas('OGCE'); */

    /* final listaGuiasAsignadas = Provider.of<AssiggrListProvider>(context);
    listaGuiasAsignadas.cargarGrAsignadas();
 */
    return Scaffold(
      body: Scaffold(
        appBar: AppBar(
          title: const Text('Salida - Planta'),
          actions: [
            IconButton(
                onPressed: () async {
                  /* showSearch(
                      context: context,
                      delegate: SearchGuiasDelegate(
                          listaGuiasAsignadas: listaGuiasAsignadas)); */
                },
                icon: const Icon(Icons.search))
          ],
        ),
        body:
            // Container()
            ListView.builder(
                //itemCount: productsServices.productos.length,
                /* itemCount: listaGuiasAsignadas.asignados.length, */
                itemCount: listadoGR.registrados.length,
                itemBuilder: (BuildContext context, int indice) =>
                    GestureDetector(
                        // TODO Aqui navego a la pantalla de Productos
                        onTap: () {
                          /* productsServices.selectedProduct =
                      productsServices.productos[indice].copy();
                  Navigator.pushNamed(context, 'product'); */

                          listadoGR.guiaSeleccionadaReg =
                              listadoGR.registrados[indice].copy();

                          final nroguia = listadoGR.registrados[indice].nroguia;
                          final tipoproceso =
                              listadoGR.registrados[indice].tipoproceso;

                          /* final listaBinGuiaAsignada =
                      Provider.of<BinGrAsignado>(context, listen: false);
                  listaBinGuiaAsignada.cargarBinAsignadas(nroguia); */

                          Navigator.pushNamed(context, 'binsalplan');
                        },
                        child: GuiasListReg(
                          registradas: listadoGR.registrados[indice],
                          //product: productsServices.productos[indice],
                        ))),
      ),
    );
  }
}
