// ignore: depend_on_referenced_packages
import 'package:bines_app/models/models.dart';
export 'package:bines_app/models/models.dart';
import 'package:path/path.dart';
import 'package:sqflite/sqflite.dart'; //aqui se usara para un sigleton , esto es para instanciarlos donde querramos

class DBProvider {
  static final DBProvider db = DBProvider._();
  DBProvider._();

  Future<Database> get databaseRead async {
    final database = openDatabase(
      // Set the path to the database. Note: Using the `join` function from the
      // `path` package is best practice to ensure the path is correctly
      // constructed for each platform.

      join(await getDatabasesPath(), 'BinesAppDB1.db'),
      // When the database is first created, create a table to store dogs.
      onCreate: (db, version) {
        // Run the CREATE TABLE statement on the database.
        db.execute(
          'CREATE TABLE Assiggr(nroguia TEXT PRIMARY KEY, fecha TEXT, kg REAL,piscina TEXT,cant INT,sincronizado INT,activo INT) ',
          //'CREATE TABLE Scans(id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, tipo TEXT, valor TEXT)',
        );
        return db.execute(
          'CREATE TABLE BinesGrAsig(nroguia TEXT,nrobin INT,fechahora TEXT,sincronizado INT,activo INT,PRIMARY KEY (nroguia, nrobin) ) ',
          //'CREATE TABLE Scans(id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, tipo TEXT, valor TEXT)',
        );
      },
      // Set the version. This executes the onCreate function and provides a
      // path to perform database upgrades and downgrades.
      version: 1,
    );
    /* final String dir = await getDatabasesPath();
    print('Direccion Base $dir'); */
    return database;
  }

  //----------------------------------
  //Bloque de Registro de la tabla que registra las guias con sus binees Primer Paso(Datos Vienen del API)
  //----------------------------------

  //----------------------------------
  //Registro de Guias de Pesca que Vienen desde el API
  //----------------------------------
  Future insertAsiganadas(AssiggrModel asignadas) async {
    // Get a reference to the database.
    final db = await databaseRead;

    // Insert the Dog into the correct table. You might also specify the
    // `conflictAlgorithm` to use in case the same dog is inserted twice.
    //
    // In this case, replace any previous data.
    final resp = await db.insert(
      'Assiggr',
      asignadas.toJson(),
      conflictAlgorithm: ConflictAlgorithm.replace,
    );
    //print('Respuesta de la Insercion $resp');

    return asignadas.nroguia;
  }

  //----------------------------------
  //Consulta de Guìas de Pesca que vinieron desde el API
  //----------------------------------
  // A method that retrieves all the dogs from the dogs table.
  Future<List<AssiggrModel>?> consultaGrAsignadas() async {
    // Get a reference to the database.
    final db = await databaseRead;

    final res = await db.query('Assiggr', where: '1 = 1 ');

    return res.isNotEmpty
        ? res.map((e) => AssiggrModel.fromJson(e)).toList()
        : [];
  }

  //----------------------------------
  //Bloque de Registro de la tabla que alamcena los registros de las guias
  //----------------------------------
  //----------------------------------
  //Registro de Guias de Pesca con los Bines Asignados
  //----------------------------------
  Future insertBinGrAsiganadas(BinesGrAsigModel binasignadas) async {
    // Get a reference to the database.
    final db = await databaseRead;

    // Insert the Dog into the correct table. You might also specify the
    // `conflictAlgorithm` to use in case the same dog is inserted twice.
    //
    // In this case, replace any previous data.
    final resp = await db.insert(
      'BinesGrAsig',
      binasignadas.toJson(),
      conflictAlgorithm: ConflictAlgorithm.replace,
    );
    //print('Respuesta de la Insercion $resp');

    return binasignadas.nrobin;
  }

  //----------------------------------
  //Consulta de Guias Asinadas con los bines
  //----------------------------------
  Future<List<BinesGrAsigModel>?> consultaBinAsignadas(String nroguia) async {
    // Get a reference to the database.
    final db = await databaseRead;

    final res = await db
        .query('BinesGrAsig', where: 'nroguia = ?', whereArgs: [nroguia]);
    /* print('Respuesta $res'); */
    return res.isNotEmpty
        ? res.map((e) => BinesGrAsigModel.fromJson(e)).toList()
        : [];
  }

  //----------------------------------
  //Borra de la tabla los bines escaneados de manera equivocada
  //----------------------------------
  Future borrarBinEscanead(String nroguia, int nrobin) async {
    // Get a reference to the database.
    final db = await databaseRead;

    // Update the given Dog.
    final res = await db.delete(
      'BinesGrAsig',
      // Ensure that the Dog has a matching id.
      where: 'nroguia = ? and nrobin = ?',
      // Pass the Dog's id as a whereArg to prevent SQL injection.
      whereArgs: [nroguia, nrobin],
    );

    return res;
  }
}
