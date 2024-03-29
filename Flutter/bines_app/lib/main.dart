import 'package:bines_app/providers/providers.dart';
import 'package:bines_app/screens/screens.dart';
import 'package:bines_app/services/services.dart';
import 'package:bines_app/themes/app_themes.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

void main() => runApp(const AppsState());

//Con este mantendremos actualizados siempre los datos
class AppsState extends StatelessWidget {
  const AppsState({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => AssiggrListProvider()),
        ChangeNotifierProvider(create: (_) => BinGrAsignado()),
        ChangeNotifierProvider(create: (_) => DataGuiasDayServices()),
        ChangeNotifierProvider(create: (_) => DataGuiaBinServices()),
        ChangeNotifierProvider(create: (_) => RegisteredGuiasProvider()),
        ChangeNotifierProvider(create: (_) => ServicesProvider()),
        ChangeNotifierProvider(create: (_) => RegisteredBinGuiasProvider()),
      ],
      child: const MyApp(),
    );
  }
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);
  final Color colorPrincipal = Colors.indigo;
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Grupo NP BinesApp',
      initialRoute: 'login',
      routes: {
        'login': (_) => const LoginScreen(), //Pantalla de Logueo
        'register': (_) => const RegisterScreen(), //Registro de Nuevo Uuario
        'home': (_) => const HomeScreen(), //Pagina Principal lista de Opciones
        'registerbin': (_) =>
            const AssigmentScreen(), //Registro de Bines Paso 1
        'exitplant': (_) =>
            const ExitPlantListScreen(), //Lista de Guias -  Registro Salida de Planta
        'arrivefarm': (_) =>
            const ArriveFarmListScreen(), // Lista de Guias - Registro Llegada a Granja
        'closebin': (_) =>
            const CloseBinListScreen(), // Lista de Guias - Cierre de Bines
        'exitfarm': (_) =>
            const ExitFarmListScreen(), //Lista Guia Salida de Granja
        'arriveplant': (_) =>
            const ArrivePlantListScreen(), //Lista Guia  - Llegada a planta
        'receptionbin': (_) =>
            const ReceptionListScreen(), //Lista Guias Llegada Recepcion
        'receivebin': (_) =>
            const SupllyHopperListScreen(), //Lista Guias - Recibido Recepcion
        'asigbin': (_) =>
            const AssigmentBinScreen(), //Listado de Bines Asignados a las guias Paso 1
        'binsalplan': (_) =>
            const ExitPlantBinGuia(), //Bines Salidos de Planta con Guias
        'exitplantscreen': (_) => const ExitPlantScreen(),

        //'product': (_) => const ProductScreen(),
      },
      theme: AppTheme.lighthTheme,

      /* theme: ThemeData.light().copyWith(
          scaffoldBackgroundColor: Colors.grey[300],
          appBarTheme: const AppBarTheme(elevation: 0, color: Colors.indigo),
          floatingActionButtonTheme: const FloatingActionButtonThemeData(
              backgroundColor: Colors.indigo, elevation: 0)), */
    );
  }
}

/* class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Material App',
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Material App Bar'),
        ),
        body: const Center(
          child: Text('Hello World'),
        ),
      ),
    );
  }
} */
