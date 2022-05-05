const config = require('../configuraciones/configuracion_base');
/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const app = express();
var cors = require('cors');



/*Funciones ue se conectan a los SP de SQL*/

/*Conexion al Sp para que devuleva los datos de la Sucursal */
let datossucursal = async(query, cod_usuario,usua_nom_red,opcion,clave) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('cod_usuario', sql.Char, cod_usuario)
            .input('usua_nom_red',sql.Char,usua_nom_red)
            .input('opcion',sql.Char,opcion)
            .input('clave',sql.Char,clave)
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}

/*Conexion al Sp para cambiar la clave*/
let datosclave = async(query, cod_usuario,clave_anterior,clave_nueva,clave_nueva_confirmar) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('usuario', sql.Char, cod_usuario)
            .input('clave_ant',sql.Char,clave_anterior)
            .input('clave_nueva',sql.Char,clave_nueva)
            .input('clave_nueva_conf',sql.Char,clave_nueva_confirmar)
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}

app.use(function(req, respuesta, next) {
    respuesta.header("Access-Control-Allow-Origin", "*"); // update to match the domain you will make the request from
    respuesta.header("Access-Control-Allow-Headers", "*");
    next();
});
  
/*Ruta para Obtener datos de la Sucursal por Usuario*/
app.get('/datossucursal', function(req, respuesta) {
    
    let opcion          =   'SUC';
    let cod_usuario     =   req.query.cod_usuario;
    let usua_nom_red    =   '';
    let query           =   'Sp_Sucursal_Usuario_Pr';
    let clave           =   '';
    
    datossucursal(query, cod_usuario,usua_nom_red,opcion,clave).then(datossucursal => {
        respuesta.json(datossucursal[0]);
    })

})

/*Ruta para Validar la clave del usuario*/
app.get('/datosusuario', function(req, respuesta) {
    let opcion          =   'USR';
    let cod_usuario     =   req.query.cod_usuario;
    let usua_nom_red    =   '';
    let query           =   'Sp_Sucursal_Usuario_Pr';
    let clave           =   req.query.clave;
    
    datossucursal(query, cod_usuario,usua_nom_red,opcion,clave).then(datossucursal => {
        respuesta.json(datossucursal[0]);
    })

})
/*Ruta para Obtener Programas por Usuario*/
app.get('/programasusuario', function(req, respuesta) {
    let opcion          =   'PPU';
    let cod_usuario     =   req.query.cod_usuario;
    let usua_nom_red    =   '';
    let query           =   'Sp_Sucursal_Usuario_Pr';
    let clave           =   '';

    datossucursal(query, cod_usuario,usua_nom_red,opcion,clave).then(datossucursal => {
        respuesta.json(datossucursal[0]);
    })

})
/*Ruta para Obtener Menu por Usuario*/
app.get('/menuusuario', function(req, respuesta) {
    let opcion          =   'MPU';
    let cod_usuario     =   req.query.cod_usuario;
    let usua_nom_red    =   '';
    let query           =   'Sp_Sucursal_Usuario_Pr';
    let clave           =   '';

    datossucursal(query, cod_usuario,usua_nom_red,opcion,clave).then(datossucursal => {
        respuesta.json(datossucursal[0]);
    })

})
/*Ruta para Obtener Sub Menu por Usuario*/
app.get('/submenuusuario', function(req, respuesta) {
    let opcion          =   'SPU';
    let cod_usuario     =   req.query.cod_usuario;
    let usua_nom_red    =   '';
    let query           =   'Sp_Sucursal_Usuario_Pr';
    let clave           =   '';

    datossucursal(query, cod_usuario,usua_nom_red,opcion,clave).then(datossucursal => {
        respuesta.json(datossucursal[0]);
    })

})
/*Ruta para Obtener la Compañia */
app.get('/obtcompania', function(req, respuesta) {
    let opcion          =   'OBC';
    let cod_usuario     =   req.query.cod_usuario;
    let usua_nom_red    =   req.query.usua_nom_red;//aqui va el codigo de la sucursal
    let query           =   'Sp_Sucursal_Usuario_Pr';
    let clave           =   ''
    
    datossucursal(query, cod_usuario,usua_nom_red,opcion,clave).then(datossucursal => {
        respuesta.json(datossucursal[0]);
    })

})
/*Ruta para Cambiar Clave*/
app.get('/cambiarclave', function(req, respuesta) {    
    let cod_usuario             =   req.query.cod_usuario; 
    let clave_anterior          =   req.query.clave_anterior; 
    let clave_nueva             =   req.query.clave_nueva;
    let clave_nueva_confirmar   =   req.query.clave_nueva_confirmar;
    let query                   =   'Sp_Cambiar_Clave';
    let valor_query             =   req.query;
    
    datosclave(query, cod_usuario,clave_anterior,clave_nueva,clave_nueva_confirmar).then(datosclave => {
        respuesta.json(datosclave[0]);
    })

})
app.use(cors());
module.exports = app;