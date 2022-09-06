import 'package:bines_app/providers/providers.dart';
import 'package:bines_app/themes/app_themes.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class AssignedListBin extends StatelessWidget {
  const AssignedListBin({Key? key, required this.nroguia}) : super(key: key);
  final String nroguia;
  @override
  Widget build(BuildContext context) {
    /* final listaGuiaBin = Provider.of<AssiggrListProvider>(context); */
    final listaGuiaBin = Provider.of<BinGrAsignado>(context);
    listaGuiaBin.cargarBinAsignadas(nroguia);
    return Expanded(
        child: ListView.builder(
      itemCount: listaGuiaBin.binAsignados.length,
      itemBuilder: (context, indice) => Dismissible(
          key: UniqueKey(),
          background: Container(
            //color: AppTheme.second,
            decoration: _cardBorders(),
          ),
          //Mediante este proceso eliminamos de la base  de datos por el id
          onDismissed: (DismissDirection direction) {
            Provider.of<BinGrAsignado>(context, listen: false).borrarBinGuia(
                nroguia, listaGuiaBin.binAsignados[indice].nrobin);
          },
          child: Container(
            //color: Colors.white,
            padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 8),
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
                  'BIN # ${listaGuiaBin.binAsignados[indice].nrobin}',
                  /* 'BIN # 16', */
                  style: const TextStyle(
                      fontSize: 15, fontWeight: FontWeight.bold),
                ),
                subtitle: Text(
                    listaGuiaBin.binAsignados[indice].fechahora.toString(),
                    /* '#Guia 145', */
                    style: const TextStyle(
                        fontSize: 13, fontWeight: FontWeight.bold)),
                trailing:
                    /* Row(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      IconButton(
                          onPressed: () {},
                          icon: Icon(
                            //Aqui averiguamos el tipo que nos llega y en base a eso mostramos el icono, ya sea del mapa o de las direcciones
                            listaGuiaBin.binAsignados[indice].sincronizado == 1
                                ? Icons.cloud_done
                                : Icons.cloud_off,
                            /* available == 1 ? Icons.cloud_done : Icons.cloud_off, */
                            color: listaGuiaBin
                                        .binAsignados[indice].sincronizado ==
                                    1
                                ? AppTheme.upload
                                : AppTheme.second,
                            /* color: available == 1 ? AppTheme.upload : AppTheme.second, */
                            size: 30,
                          )),
                      IconButton(
                          onPressed: () {
                            'ELIMINAR BIN # ${listaGuiaBin.binAsignados[indice].nrobin}';
                          },
                          icon: Icon(
                            //Aqui averiguamos el tipo que nos llega y en base a eso mostramos el icono, ya sea del mapa o de las direcciones
                            listaGuiaBin.binAsignados[indice].sincronizado == 1
                                ? Icons.delete
                                : Icons.cloud_off,
                            /* available == 1 ? Icons.cloud_done : Icons.cloud_off, */
                            color: listaGuiaBin
                                        .binAsignados[indice].sincronizado ==
                                    1
                                ? AppTheme.upload
                                : AppTheme.second,
                            /* color: available == 1 ? AppTheme.upload : AppTheme.second, */
                            size: 30,
                          ))
                    ],
                  ) */

                    Icon(
                  //Aqui averiguamos el tipo que nos llega y en base a eso mostramos el icono, ya sea del mapa o de las direcciones
                  listaGuiaBin.binAsignados[indice].sincronizado == 1
                      ? Icons.cloud_done
                      : Icons.cloud_off,
                  /* available == 1 ? Icons.cloud_done : Icons.cloud_off, */
                  color: listaGuiaBin.binAsignados[indice].sincronizado == 1
                      ? AppTheme.upload
                      : AppTheme.second,
                  /* color: available == 1 ? AppTheme.upload : AppTheme.second, */
                  size: 30,
                ),
              ),
            ),
          )),
    ));
  }

  BoxDecoration _cardBorders() => BoxDecoration(
          color: AppTheme.second,
          borderRadius: BorderRadius.circular(20),
          boxShadow: const [
            BoxShadow(color: Colors.black, offset: Offset(0, 5), blurRadius: 10)
          ]);
}
