import 'package:bines_app/providers/providers.dart';
import 'package:bines_app/screens/screens.dart';
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
        ChangeNotifierProvider(create: (_) => BinGrAsignado())
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
        'login': (_) => const LoginScreen(),
        'register': (_) => const RegisterScreen(),
        'home': (_) => const HomeScreen(),
        'registerbin': (_) => const AssigmentScreen(),
        'exitplant': (_) => const ExitPlantListScreen(),
        'exitplantscreen': (_) => const ExitPlantScreen(),
        'arrivefarm': (_) => const ArriveFarmScreen(),
        'closebin': (_) => const CloseBinScreen(),
        'exitfarm': (_) => const ExitFarmScreen(),
        'arriveplant': (_) => const ArrivePlantScreen(),
        'receptionbin': (_) => const ReceptionScreen(),
        'receivebin': (_) => const SupllyHopperScreen(),
        'asigbin': (_) => const AssigmentBinScreen(),

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
