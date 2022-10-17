/* import 'package:bines_app/providers/providers.dart'; */
import 'package:bines_app/providers/providers.dart';
import 'package:bines_app/routes/app_routes.dart';
import 'package:bines_app/themes/app_themes.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
/* import 'package:provider/provider.dart'; */

class HomeScreen extends StatelessWidget {
  const HomeScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    /* final listaGuiasAsignadas = Provider.of<AssiggrListProvider>(context); */
    final menuOptions = AppRoutes.menuOptions;
    return Scaffold(
      appBar: AppBar(
        title: const Text('Registro de Bines'),
        //agregar boton para logout
        actions: [
          IconButton(
              onPressed: () {
                //aqui se debe controlar quitar la
                //authServices.logout();
                Navigator.pushReplacementNamed(context, 'login');
              },
              icon: const Icon(Icons.login_outlined))
        ],
      ), //Este Widget permite tener un separador entre cada linea del listview
      body: ListView.separated(
        itemCount: menuOptions.length,
        itemBuilder: (context, index) => ListTile(
          title: Text(menuOptions[index].name,
              style:
                  const TextStyle(fontSize: 14, fontWeight: FontWeight.bold)),
          leading: Icon(
            menuOptions[index].icon,
            color: AppTheme.primary,
          ),
          //permite seleccionar el elemencto de la lista
          onTap: () {
            //se podra navgar a otras pantallas
            /*
            final route = MaterialPageRoute(
                builder: (context) => const ListView1Screen());
            Navigator.push(context, route);
            */
            final listaGuiasServices =
                Provider.of<ServicesProvider>(context, listen: false);
            final listadoGR =
                Provider.of<RegisteredGuiasProvider>(context, listen: false);
            switch (index) {
              case 0:

              case 1:
                listaGuiasServices
                    .llamarApiGuiasRegistradas('OGCE'); //Obtiene Guias Cerradas
                listadoGR.cargarGrRegistradas('RSP'); //Regitro Salida Planta
                break;
              case 2:
              case 3:
              case 4:
              case 5:
              case 6:
            }
            Navigator.pushNamed(context, menuOptions[index].route);
          },
          trailing: const Icon(
            Icons.keyboard_arrow_right,
            color: AppTheme.primary,
          ),
        ),
        separatorBuilder: (_, __) => const Divider(),
      ),
    );
  }
}
