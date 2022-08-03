import 'package:bines_app/themes/app_themes.dart';
import 'package:flutter/material.dart';

class AssignedCardHeader extends StatelessWidget {
  const AssignedCardHeader({Key? key}) : super(key: key);
  final double tamanio = 12.5;
  @override
  Widget build(BuildContext context) {
    return Container(
      decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(20), color: Colors.white),
      child: Row(
        children: [
          Expanded(
            flex: 1,
            child: Container(
              //color: Colors.red,
              padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 10),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    '#Guìa : ',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.second,
                        fontWeight: FontWeight.bold),
                  ),
                  /* Text(
                      'NIRSA DEL ECU',
                      style: TextStyle(
                          fontSize: tamanio,
                          color: AppTheme.primary,
                          fontWeight: FontWeight.bold),
                    ), */
                  const Divider(
                    height: 5,
                    color: Colors.white,
                  ),
                  Text(
                    'Kg :',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.second,
                        fontWeight: FontWeight.bold),
                  ),
                  const Divider(
                    height: 5,
                    color: Colors.white,
                  ),
                  Text(
                    'Cant. : ',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.second,
                        fontWeight: FontWeight.bold),
                  ),
                ],
              ),
            ),
          ),
          Expanded(
            flex: 1,
            child: Container(
              //color: Colors.red,
              padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 10),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    'H14526',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.primary,
                        fontWeight: FontWeight.bold),
                  ),
                  /* Text(
                      'NIRSA DEL ECU',
                      style: TextStyle(
                          fontSize: tamanio,
                          color: AppTheme.primary,
                          fontWeight: FontWeight.bold),
                    ), */
                  const Divider(
                    height: 5,
                    color: Colors.white,
                  ),
                  Text(
                    '1256.32',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.primary,
                        fontWeight: FontWeight.bold),
                  ),
                  const Divider(
                    height: 5,
                    color: Colors.white,
                  ),
                  const Text(
                    '15',
                    style: TextStyle(
                        fontSize: 20,
                        color: AppTheme.upload,
                        fontWeight: FontWeight.bold),
                  ),
                ],
              ),
            ),
          ),
          Expanded(
            flex: 1,
            child: Container(
              //color: Colors.red,
              padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 10),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    'Fecha : ',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.second,
                        fontWeight: FontWeight.bold),
                  ),
                  /* Text(
                      'NIRSA DEL ECU',
                      style: TextStyle(
                          fontSize: tamanio,
                          color: AppTheme.primary,
                          fontWeight: FontWeight.bold),
                    ), */
                  const Divider(
                    height: 5,
                    color: Colors.white,
                  ),
                  Text(
                    '# Pisc :',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.second,
                        fontWeight: FontWeight.bold),
                  ),
                ],
              ),
            ),
          ),
          Expanded(
            flex: 1,
            child: Container(
              //color: Colors.red,
              padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 10),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    '2022-08-01',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.primary,
                        fontWeight: FontWeight.bold),
                  ),
                  /* Text(
                      'NIRSA DEL ECU',
                      style: TextStyle(
                          fontSize: tamanio,
                          color: AppTheme.primary,
                          fontWeight: FontWeight.bold),
                    ), */
                  const Divider(
                    height: 5,
                    color: Colors.white,
                  ),
                  Text(
                    'C119',
                    style: TextStyle(
                        fontSize: tamanio,
                        color: AppTheme.primary,
                        fontWeight: FontWeight.bold),
                  ),
                ],
              ),
            ),
          )
        ],
      ),
    );
  }
}
