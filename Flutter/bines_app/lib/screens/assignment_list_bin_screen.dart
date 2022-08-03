import 'package:bines_app/widgets/widgets.dart';
import 'package:flutter/material.dart';

class AssigmentScreen extends StatelessWidget {
  const AssigmentScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
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
                },
                icon: const Icon(Icons.search))
          ],
        ),
        body: ListView.builder(
            //itemCount: productsServices.productos.length,
            itemCount: 20,
            itemBuilder: (BuildContext context, int indice) => GestureDetector(
                // TODO Aqui navego a la pantalla de Productos
                onTap: () {
                  /* productsServices.selectedProduct =
                      productsServices.productos[indice].copy();
                  Navigator.pushNamed(context, 'product'); */
                  Navigator.pushNamed(context, 'asigbin');
                },
                child: const AssigmentBinCard(
                    //product: productsServices.productos[indice],
                    ))),
      ),
    );
  }
}
