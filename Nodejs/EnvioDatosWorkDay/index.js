require('dotenv').config()
const sql = require('mssql/msnodesqlv8');
/* const { readMapBiolan,datosCabecera,mapaCabPayRoll,datosDetallePaLips,mapaDetPayLips} = require('./helpers/inquirer'); */
const { datosCabecera,mapaCabPayRoll,datosDetallePaLips,mapaDetPayLips} = require('./helpers/inquirer');
const Busquedas = require('./models/busquedas');
const config = require('./configuraciones/config')
const fs = require('fs');
const path = require("path");


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
    //Paso 1 : Obtengo Datos para Envìo de PayRoll
    //--------------------------------------------
    console.log('Paso 1 - Cagando Datos del SP Para los PayRolls.........');
    const datos = await datosCabecera('PR','');
    const numapertura = datos.Apertura;
    console.log(datos);
    //--------------------------------------------
    //Paso 2 : Transformar la Data Recibida en un Mapa
    //--------------------------------------------
    console.log('Paso 2 - Transformar los Datos a Un Mapa - PayRoll');
    const mapaDatosPayRoll = await mapaCabPayRoll(datos);
    console.log(mapaDatosPayRoll);
    //--------------------------------------------
    //Paso 3 : Consumir y Enviar los Payrrolls
    //--------------------------------------------
    console.log('Paso 3 - Consumir y Enviar los Payrrolls');
    const resppayroll = await busquedas.enviarDatosPayRoll(mapaDatosPayRoll,'payroll')
    console.log(resppayroll);
    /* let cantDatosResp = resppayroll.length; */
    let cantDatosResp = 0;
    if(cantDatosResp>0){
        //--------------------------------------------
        //Paso 4 : Obtener Cabecera Paylips y Numero de Apertura
        //--------------------------------------------
        console.log('Paso 4 - Cargando Datos de los Paylips.........');
        const datoscabpaylips = await datosCabecera('PL','');
        console.log(datoscabpaylips);
        //--------------------------------------------
        //Paso 5 : Obtengo # de Apertura(PK) para extraer los detalles
        //--------------------------------------------
        console.log('Paso 5 - Datos de la cabecera - Paylips');
        let filename = datoscabpaylips.FileNameCsv;
        let path = datoscabpaylips.PathCsv;
        let apertura = datoscabpaylips.Apertura;
        console.log('Nombre Archivo : ',filename);
        //--------------------------------------------
        //Paso 6 : Obtener Datos del Detalle de los PayLips
        //--------------------------------------------
        console.log('Paso 6 - Cargando Datos Cabecera de los Paylips.........');
        const datosdetpaylips = await datosDetallePaLips('PL',apertura);
        console.log(datosdetpaylips);
        //--------------------------------------------
        //Paso 7 : Convertir los Datos en Mapa
        //--------------------------------------------
        console.log('Paso 7 - Convertir los Datos de Payslips en Mapa');
        const datosmapapaylips = await mapaDetPayLips(filename,path,datosdetpaylips);
        console.log(datosmapapaylips);
        //--------------------------------------------
        //Paso 8 : COnsumimos y Realizamos el Envio 
        //--------------------------------------------
        console.log('Paso 8 - Consumir y Enviar los Paylips');
        const resppaylips = await busquedas.enviarDatosPayRoll(datosmapapaylips,'payslips')
        console.log(resppaylips); 

        //--------------------------------------------
        //Paso 9 : Actualizar Tabla de Envios.
        //--------------------------------------------

    }else{
        console.log('Revisar por Favor , No Devolvio Datos el EndPoint de Mule !!')
    }
    
}
const val_conexion = mensaje();
if (val_conexion){
    main();
}else{
    console.log('Revise configuracion de BD');
}

// Helper function
function base64_encode(file) {
    const contents=fs.readFileSync(file, 'base64');
    return contents;
}



