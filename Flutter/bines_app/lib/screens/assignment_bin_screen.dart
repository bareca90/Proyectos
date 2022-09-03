import 'package:bines_app/providers/providers.dart';
import 'package:bines_app/themes/app_themes.dart';
import 'package:bines_app/widgets/widgets.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class AssigmentBinScreen extends StatelessWidget {
  const AssigmentBinScreen({Key? key}) : super(key: key);
  final bool sincronizado = true;

  @override
  Widget build(BuildContext context) {
    final listaGuiasAsignadas =
        Provider.of<AssiggrListProvider>(context, listen: false);
    final nroguia = listaGuiasAsignadas.guiaSeleccionada.nroguia;
    listaGuiasAsignadas.cargarBinAsignadas(nroguia);

    return Scaffold(
        appBar: AppBar(
          title: const Text('Registro Bin en Guìa'),
          //agregar boton para logout
          actions: [
            IconButton(
                onPressed: () {
                  //aqui se debe controlar quitar la
                  //authServices.logout();
                  //Navigator.pushReplacementNamed(context, 'login');
                },
                icon: const Icon(Icons.delete)),
            IconButton(
                onPressed: () {
                  //aqui se debe controlar quitar la
                  //authServices.logout();
                  //Navigator.pushReplacementNamed(context, 'login');
                },
                icon: const Icon(Icons.cloud_upload_rounded))
          ],
        ),
        body: Column(
          children: [
            Container(
              padding: const EdgeInsets.symmetric(horizontal: 5, vertical: 10),
              color: AppTheme.primary,
              height: 120,
              child:
                  AssignedCardHeader(listaGuiasAsignadas: listaGuiasAsignadas),
            ),
            /* AssignedListBin(
                nroguia: listaGuiasAsignadas.guiaSeleccionada.nroguia) */
            Expanded(
                child: ListView.builder(
              itemCount: listaGuiasAsignadas.binAsignados.length,
              itemBuilder: (_, indice) => Dismissible(
                  key: UniqueKey(),
                  background: Container(
                    decoration: _cardBorders(),
                  ),
                  child: Container(
                    padding:
                        const EdgeInsets.symmetric(horizontal: 10, vertical: 8),
                    child: Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(20),
                        color: Colors.white,
                      ),
                      child: ListTile(
                        leading: const Icon(
                          Icons.assignment,
                          color: AppTheme.primary,
                          size: 30,
                        ),
                        title: Text(
                          'BIN # ${listaGuiasAsignadas.binAsignados[indice].nrobin}',
                          /* 'BIN # 16', */
                          style: const TextStyle(
                              fontSize: 15, fontWeight: FontWeight.bold),
                        ),
                        subtitle: Text(
                            listaGuiasAsignadas.binAsignados[indice].fechahora
                                .toString(),
                            /* '#Guia 145', */
                            style: const TextStyle(
                                fontSize: 13, fontWeight: FontWeight.bold)),
                        trailing: Icon(
                          //Aqui averiguamos el tipo que nos llega y en base a eso mostramos el icono, ya sea del mapa o de las direcciones
                          listaGuiasAsignadas
                                      .binAsignados[indice].sincronizado ==
                                  1
                              ? Icons.cloud_done
                              : Icons.cloud_off,
                          color: listaGuiasAsignadas
                                      .binAsignados[indice].sincronizado ==
                                  1
                              ? AppTheme.upload
                              : AppTheme.second,
                          size: 30,
                        ),
                      ),
                    ),
                  )),
            ))
          ],
        ),
        floatingActionButtonLocation: FloatingActionButtonLocation.endFloat,
        floatingActionButton:
            ScanButtonQR(listaGuiasAsignadas: listaGuiasAsignadas)

        /* FloatingActionButton(
        onPressed: () async {
          //TODO :  Guardar Producto
          /* if (!productForm.isValidaForm()) return;
          await productService.updateProducts(productForm.product);  */
        },
        child: const Icon(Icons.qr_code_scanner_rounded),
      ), */
        );
  }

  BoxDecoration _cardBorders() => BoxDecoration(
          color: AppTheme.second,
          borderRadius: BorderRadius.circular(20),
          boxShadow: const [
            BoxShadow(color: Colors.black, offset: Offset(0, 5), blurRadius: 10)
          ]);
}
