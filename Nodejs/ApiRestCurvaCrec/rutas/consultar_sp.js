const config = require('../configuraciones/configuracion_base');
/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const app = express();


/*Conexion al SP para que devuelva datos del Combo de Operaciones */
let datosComboOperacion = async(query, opcion,valor_operacion) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('opcion', sql.Char, opcion)
            .input('valor_operacion', sql.Char, valor_operacion)
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}

/*Conexion al Sp para que devuleva los datos de la Curva */
let datosCurva = async(query, opcion,anio,camaronera,piscina,ciclo,operacion) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('opcion', sql.Char, opcion)
            .input('anio',sql.Int,anio)
            .input('camaronera',sql.Char,camaronera)
            .input('piscina',sql.Char,piscina)
            .input('ciclo',sql.Char,ciclo)
            .input('operacion',sql.Char,operacion)
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}

/*Conexion al Sp para que devuleva los datos de los Usuarios */
let datosUsr = async(query, usuario,clave) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('usuario', sql.Char, usuario)
            .input('clave',sql.Char,clave)
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }
}

/*Ruta para Obtener Datos del combo de Anios*/
app.get('/validausr', function(req, respuesta) {
    let usuario = req.query.usuario
    let clave = req.query.clave
    
    let query = 'Sp_Valida_Usr_Curva_Ideal';
    
    datosUsr(query, usuario,clave).then(datosusr => {
        respuesta.json(datosusr[0]);
    })

})


/*Ruta para Obtener datos del Combo Principal*/
app.get('/obteneroperacion', function(req, respuesta) {
    /* let id = req.query.id; */
    let opcion = 'CBO'
    let valor_operacion = ''

    let query = 'Sp_Obtener_Config_Curva_Ideal';

    datosComboOperacion(query, opcion,valor_operacion).then(datoscombo => {
        respuesta.json(datoscombo[0]);
    })

})


/*Ruta para Obtener datos del Servidor donde estaran las Apis*/
app.get('/datosapi', function(req, respuesta) {
    /* let id = req.query.id; */
    let opcion = 'API'
    let valor_operacion = req.query.valor_operacion;

    let query = 'Sp_Obtener_Config_Curva_Ideal';

    datosComboOperacion(query, opcion,valor_operacion).then(datoscombo => {
        respuesta.json(datoscombo[0]);
    })

})

/*Ruta para Obtener Datos del combo de Camaroneras*/
app.get('/datoscamaronera', function(req, respuesta) {
    /* let id = req.query.id; */
    let opcion = 'CAM'
    let valor_operacion = '';

    let query = 'Sp_Obtener_Config_Curva_Ideal';

    datosComboOperacion(query, opcion,valor_operacion).then(datoscombo => {
        respuesta.json(datoscombo[0]);
    })

})

/*Ruta para Obtener Datos del combo de Anios*/
app.get('/datosanio', function(req, respuesta) {
    /* let id = req.query.id; */
    let opcion = 'ANI'
    let valor_operacion = req.query.valor_operacion;

    let query = 'Sp_Obtener_Config_Curva_Ideal';
    console.log(valor_operacion);
    datosComboOperacion(query, opcion,valor_operacion).then(datoscombo => {
        respuesta.json(datoscombo[0]);
    })

})


/*Ruta para Obtener Datos Piscinas*/
app.get('/datospiscinas', function(req, respuesta) {
    /* let id = req.query.id; */
    let opcion = 'PIS'
    let anio = req.query.anio;
    let camaronera = req.query.camaronera;
    let piscina = '';
    let ciclo = '';
    let query = 'Sp_Calculo_Curva_Ideal';
    let operacion   =  req.query.operacion;
    
    datosCurva(query, opcion,anio,camaronera,piscina,ciclo,operacion).then(datoscurva => {
        respuesta.json(datoscurva[0]);
    })

})
/*Ruta para Obtener Datos Ciclo*/
app.get('/datosciclo', function(req, respuesta) {
    /* let id = req.query.id; */
    let opcion = 'CIC'
    let anio = req.query.anio;
    let camaronera = req.query.camaronera;
    let piscina = req.query.piscina;
    let ciclo = '';
    let query = 'Sp_Calculo_Curva_Ideal';
    let operacion   =  req.query.operacion;
    datosCurva(query, opcion,anio,camaronera,piscina,ciclo,operacion).then(datoscurva => {
        respuesta.json(datoscurva[0]);
    })

})

/*Ruta para Obtener Datos Curva*/
app.get('/curva', function(req, respuesta) {
    /* let id = req.query.id; */
    let opcion = 'CUR'
    let anio = req.query.anio;
    let camaronera = req.query.camaronera;
    let piscina = req.query.piscina;
    let ciclo = req.query.ciclo;
    let query = 'Sp_Calculo_Curva_Ideal';
    let operacion   =  req.query.operacion;
    
    datosCurva(query, opcion,anio,camaronera,piscina,ciclo,operacion).then(datoscurva => {
        respuesta.json(datoscurva[0]);
    })

})
module.exports = app;