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

      join(await getDatabasesPath(), 'ControlTiemposDB.db'),
      // When the database is first created, create a table to store dogs.
      onCreate: (db, version) {
        // Run the CREATE TABLE statement on the database.
        db.execute(
          'CREATE TABLE Assiggr(nroguia TEXT PRIMARY KEY, fecha TEXT, kg REAL,piscina TEXT,cant INT,sincronizado INT,activo INT) ',
        );
        db.execute(
          'CREATE TABLE GuiasRegistradas(tipoproceso TEXT,nroguia TEXT, fechaguia TEXT, kg REAL,piscina TEXT,cantescaneada INT,activo INT,sincronizado INT,PRIMARY KEY (tipoproceso, nroguia)) ',
        );
        db.execute(
          'CREATE TABLE BinesRegistrados(tipoproceso TEXT,nroguia TEXT,nrobin INT, fechahoraesc TEXT,activo INT,sincronizado INT,PRIMARY KEY (tipoproceso, nroguia,nrobin)) ',
        );
        return db.execute(
          'CREATE TABLE BinesGrAsig(nroguia TEXT,nrobin INT,fechahora TEXT,sincronizado INT,activo INT,PRIMARY KEY (nroguia, nrobin) ) ',
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
  //Registro de Guias de Pesca que Vienen desde el API
  //----------------------------------
  Future insertGuiasReg(RegisteredGuias registradas) async {
    // Get a reference to the database.
    final db = await databaseRead;

    // Insert the Dog into the correct table. You might also specify the
    // `conflictAlgorithm` to use in case the same dog is inserted twice.
    //
    // In this case, replace any previous data.
    final resp = await db.insert(
      'GuiasRegistradas',
      registradas.toJson(),
      conflictAlgorithm: ConflictAlgorithm.replace,
    );
    //print('Respuesta de la Insercion $resp');

    return registradas.nroguia;
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
  //Consulta de Guìas de Pesca que vinieron desde el API
  //----------------------------------
  // A method that retrieves all the dogs from the dogs table.
  Future<List<RegisteredGuias>?> consultaGrReg(String tipoproceso) async {
    // Get a reference to the database.
    final db = await databaseRead;

    final res = await db.query('GuiasRegistradas',
        where: 'tipoproceso = ? ', whereArgs: [tipoproceso]);

    return res.isNotEmpty
        ? res.map((e) => RegisteredGuias.fromJson(e)).toList()
        : [];
  }

  //----------------------------------
  //Eliminacion de las guias q no estan sincronizadas que vinieron desde el API
  //----------------------------------
  Future borrarGuiasPesca(String nroguia) async {
    // Get a reference to the database.
    final db = await databaseRead;

    //TODO : APlicar COndicion para q borre las que no han sido sincronizadas
    final res = await db.delete(
      'Assiggr',
      // Ensure that the Dog has a matching id.
      /* where: 'nroguia = ? and sincronizado = 0 ', */
      // Pass the Dog's id as a whereArg to prevent SQL injection.
      /* whereArgs: [nroguia], */
    );

    return res;
  }

  //----------------------------------
  //Eliminacion de las guias q no estan sincronizadas que vinieron desde el API
  //----------------------------------
  Future borrarGuiasReg(String tipoproceso) async {
    // Get a reference to the database.
    final db = await databaseRead;

    //TODO : APlicar COndicion para q borre las que no han sido sincronizadas
    final res = await db.delete(
      'GuiasRegistradas',
      // Ensure that the Dog has a matching id.
      where: 'tipoproceso = ? ',
      // Pass the Dog's id as a whereArg to prevent SQL injection.
      whereArgs: [tipoproceso],
    );

    return res;
  }

  //----------------------------------
  //Actualizar Tabla Asiggr para saber que esta sincronizada
  //----------------------------------
  Future actSincGr(String nroguia, int activo, int sincronizado) async {
    // Get a reference to the database.
    final db = await databaseRead;
    //'CREATE TABLE Assiggr(nroguia TEXT PRIMARY KEY, fecha TEXT, kg REAL,piscina TEXT,cant INT,sincronizado INT,activo INT) ',
    final actualizado = await db.update(
        'Assiggr', {'sincronizado': sincronizado, 'activo': activo},
        where: 'nroguia = ?', whereArgs: [nroguia]);
    return sincronizado;
  }

  //----------------------------------
  //Bloque de Registro de la tabla que alamcena los registros de las guias con los Bines
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
  //Cantidad de Bines Escaneados
  //----------------------------------
  Future cantidadBinesEscaneados(String nroguia) async {
    // Get a reference to the database.
    final db = await databaseRead;

    final res = await db
        .query('BinesGrAsig', where: 'nroguia = ?', whereArgs: [nroguia]);
    int bines = res.length;
    if (res.isEmpty) {
      bines = 0;
    }
    final actualizado = await db.update('Assiggr', {'cant': bines},
        where: 'nroguia = ?', whereArgs: [nroguia]);
    return bines;
  }

  //----------------------------------
  //Actualizar Tabla Asiggr para saber que esta sincronizada
  //----------------------------------
  Future actSincGrBines(
      String nroguia, int activo, int sincronizado, int nrobin) async {
    // Get a reference to the database.
    final db = await databaseRead;
    final actualizado = await db.update('BinesGrAsig',
        {'sincronizado': sincronizado, 'activo': activo, 'nrobin': nrobin},
        where: 'nroguia = ? and nrobin = ? ', whereArgs: [nroguia, nrobin]);
    return actualizado;
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

  //----------------------------------
  //Borrar Todas las Guia  no sincronizadas
  //----------------------------------
  Future borrarBinesGuias(String nroguia) async {
    // Get a reference to the database.
    final db = await databaseRead;

    // Update the given Dog.
    final res = await db.delete(
      'BinesGrAsig',
      // Ensure that the Dog has a matching id.
      where: 'nroguia = ? and sincronizado = 0 ',
      // Pass the Dog's id as a whereArg to prevent SQL injection.
      whereArgs: [nroguia],
    );

    return res;
  }

  //----------------------------------
  //Borrar Todas las Guia  Sincronizadas
  //----------------------------------
  Future borrarBinesGuiasSinc(String nroguia) async {
    // Get a reference to the database.
    final db = await databaseRead;

    // Update the given Dog.
    final res = await db.delete(
      'BinesGrAsig',
      // Ensure that the Dog has a matching id.
      where: 'nroguia = ? and sincronizado = 1 ',
      // Pass the Dog's id as a whereArg to prevent SQL injection.
      whereArgs: [nroguia],
    );

    return res;
  }
}
