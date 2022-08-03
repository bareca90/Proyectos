import 'package:bines_app/widgets/auth_background.dart';
import 'package:flutter/material.dart';

class ArrivePlantScreen extends StatelessWidget {
  const ArrivePlantScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Llegada a Planta'),
      ),
      body: AuthBackground(
          child: SingleChildScrollView(
        child: Column(
          children: [
            Container(
              color: Colors.red,
              height: 200,
            ),
            Container(
              color: Colors.blue,
            )
          ],
        ),
      )),
    );
  }
}
