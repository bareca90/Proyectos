import 'package:bines_app/themes/app_themes.dart';
import 'package:flutter/material.dart';

class AssignedListBin extends StatelessWidget {
  const AssignedListBin({Key? key}) : super(key: key);
  final bool sincronizado = false;
  @override
  Widget build(BuildContext context) {
    return Expanded(
        child: ListView.builder(
      itemCount: 30,
      itemBuilder: (_, indice) => Dismissible(
          key: UniqueKey(),
          background: Container(
            //color: AppTheme.second,
            decoration: _cardBorders(),
          ),
          child: Container(
            //color: Colors.white,
            padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 10),
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
                title: const Text(
                  'BIN # 16',
                  style: TextStyle(fontSize: 15, fontWeight: FontWeight.bold),
                ),
                subtitle: const Text('02-08-2022:16:40',
                    style:
                        TextStyle(fontSize: 13, fontWeight: FontWeight.bold)),
                trailing: Icon(
                  //Aqui averiguamos el tipo que nos llega y en base a eso mostramos el icono, ya sea del mapa o de las direcciones
                  sincronizado == true ? Icons.cloud_done : Icons.cloud_off,
                  color:
                      sincronizado == true ? AppTheme.upload : AppTheme.second,
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
