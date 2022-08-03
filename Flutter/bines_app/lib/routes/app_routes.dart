//Se Define las rutas de mi aplicacion
import 'package:bines_app/models/models.dart';
import 'package:bines_app/screens/screens.dart';
import 'package:flutter/material.dart';

//import 'package:fl_components/models/models.dart';
//import 'package:fl_components/screens/screens.dart';

class AppRoutes {
  //Primera Opcion para Manejar las rutas
  /*
  static const initial_route = 'HomeScreen';

  static Map<String, Widget Function(BuildContext)> routes = {
    'HomeScreen': (BuildContext context) => const HomeScreen(),
    'ListView1': (BuildContext context) => const ListView1Screen(),
    'ListView2': (BuildContext context) => const ListView2Screen(),
    'Alerta': (BuildContext context) => const AlertScreen(),
    'Card': (BuildContext context) => const CardScreen(),
  };

  static Route<dynamic> onGenerateRoute(RouteSettings settings) {
    return MaterialPageRoute(builder: (context) => const AlertScreen());
  }
  */
  static const initialRoute = 'HomeScreen';
  static final menuOptions = <MenuOptions>[
    // TODO: Borrar Home
    /* MenuOptions(
        route: 'home',
        name: 'Home Screen',
        screen: const HomeScreen(),
        icon: Icons.home), */
    MenuOptions(
        route: 'registerbin',
        name: 'Registrar Bin',
        screen: const AssigmentScreen(),
        icon: Icons.app_registration),
    MenuOptions(
        route: 'exitplant',
        name: 'Registrar Salida Planta',
        screen: const ExitPlantListScreen(),
        icon: Icons.fire_truck_sharp),
    MenuOptions(
        route: 'arrivefarm',
        name: 'Registrar Llegada a Granja',
        screen: const ArriveFarmScreen(),
        icon: Icons.fast_forward_rounded),
    MenuOptions(
        route: 'closebin',
        name: 'Registrar Cierre de Bin',
        screen: const CloseBinScreen(),
        icon: Icons.close_fullscreen),
    MenuOptions(
        route: 'exitfarm',
        name: 'Registrar Salida Granja',
        screen: const ExitFarmScreen(),
        icon: Icons.emoji_transportation_outlined),
    MenuOptions(
        route: 'arriveplant',
        name: 'Registrar Llegada a Planta',
        screen: const ArrivePlantScreen(),
        icon: Icons.mobile_friendly),
    MenuOptions(
        route: 'receptionbin',
        name: 'Registrar Llegada Recepciòn',
        screen: const ReceptionScreen(),
        icon: Icons.check_box),
    MenuOptions(
        route: 'receivebin',
        name: 'Registrar Recibido Recepciòn',
        screen: const SupllyHopperScreen(),
        icon: Icons.share_arrival_time),

    /* MenuOptions(
        route: 'ListView1',
        name: 'List View 1',
        screen: const ListView1Screen(),
        icon: Icons.list),
    MenuOptions(
        route: 'ListView2',
        name: 'List View 2',
        screen: const ListView2Screen(),
        icon: Icons.list),
    MenuOptions(
        route: 'Alerta',
        name: 'Alertas',
        screen: const AlertScreen(),
        icon: Icons.add_alert_outlined),
    MenuOptions(
        route: 'Card',
        name: 'Cards',
        screen: const CardScreen(),
        icon: Icons.credit_card) */
  ];

  static Map<String, Widget Function(BuildContext)> getAppRoutes() {
    Map<String, Widget Function(BuildContext)> appRoutes = {};
    for (final option in menuOptions) {
      appRoutes.addAll({option.route: (BuildContext context) => option.screen});
    }

    return appRoutes;
  }

  /*
  static Map<String, Widget Function(BuildContext)> routes = {
    'HomeScreen': (BuildContext context) => const HomeScreen(),
    'ListView1': (BuildContext context) => const ListView1Screen(),
    'ListView2': (BuildContext context) => const ListView2Screen(),
    'Alerta': (BuildContext context) => const AlertScreen(),
    'Card': (BuildContext context) => const CardScreen(),
  };
  */

  static Route<dynamic> onGenerateRoute(RouteSettings settings) {
    return MaterialPageRoute(builder: (context) => const AlertScreen());
  }
}
