require('dotenv').config()
const sql = require('mssql/msnodesqlv8');
const { readMapBiolan} = require('./helpers/inquirer');
const Busquedas = require('./models/busquedas');
const config = require('./configuraciones/config')
//--------------------------------------------
//Validamos la conexion a la base de datos
//--------------------------------------------

const mensaje = async()=>{
    try{
        const respuesta = await sql.connect(config)
        if (respuesta) console.log('Se Conecto a la Base Correctamente')
        return true ;
    
    }catch(error){
        console.log(error)
        return false ;
    }
}

const main = async()=>{

    const busquedas = new Busquedas();
    //--------------------------------------------
    //Paso 1 : Obtener el Token
    //--------------------------------------------
    const token = await busquedas.loguearBiolan('kiniguez@promarisco.com','Pescanova123')
    //--------------------------------------------
    //Paso 2 : Obtener los datos de El Dìa 
    //--------------------------------------------
    //local_timestamp__date
    let fecha_actual = new Date();
    fecha_actual=fecha_actual.getFullYear()+"-"+(fecha_actual.getMonth()+1)+"-"+fecha_actual.getDate()
    console.log(fecha_actual);
    //--------------------------------------------
    const analisisDia = await busquedas.obtenerDatos(token,fecha_actual)
    //console.log(analisisDia);

    const datosBiolan = await readMapBiolan(analisisDia)
}
const val_conexion = mensaje();
if (val_conexion){
    main();
}else{
    console.log('Revise configuracion de BD');
}

 



