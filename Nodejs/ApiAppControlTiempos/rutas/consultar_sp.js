const config = require('../configuraciones/configuracion_base');
/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const app = express();


//---------------------------------------------------------
/*Ruta para Get para devolver los datos de las Guias x Dìa */
//---------------------------------------------------------
app.get('/dataguiasdia', function(req, respuesta) {
    let query = 'Sp_Datos_App_Bines';
    let nroguia ='';
    //console.log(JSON.stringify(datos));
    datosGuiasDia(query,'GDIA',nroguia).then(datosguiadia => {
        respuesta.json(datosguiadia[0]);
    })
    

})
//---------------------------------------------------------
/*Conexion al Sp que devuelve guias registradas y procesadas*/
//---------------------------------------------------------
app.get('/obtenerguiasregistradas', function(req, respuesta) {
    let nroguia = req.query.nroguia;
    let opcion = req.query.opcion
    let query = 'Sp_Datos_App_Bines';
    //console.log(JSON.stringify(datos));
    datosGuiasDia(query,opcion,nroguia).then(datosguiadia => {
        respuesta.json(datosguiadia[0]);
    })
})
//---------------------------------------------------------
/*Conexion al Sp que devuelve los Bines Registrados por guìa*/
//---------------------------------------------------------
app.get('/obtenerbinesguia', function(req, respuesta) {
    let nroguia = req.query.nroguia;
    let opcion = req.query.opcion
    let query = 'Sp_Datos_App_Bines';
    //console.log(JSON.stringify(datos));
    datosGuiasDia(query,opcion,nroguia).then(datosguiadia => {
        respuesta.json(datosguiadia[0]);
    })
})
//---------------------------------------------------------
/*Ruta para Post de Registros de Bines Asignados por guìa */
//---------------------------------------------------------
app.post('/binesguia', function(req, respuesta) {
    let nroguia = req.body.nroguia;
    let nrobin = req.body.nrobin;
    let fechahra = req.body.fechahra;
    let opcion = req.body.opcion
    let query = 'Insert_Datos_App_Bines';
    //console.log(JSON.stringify(datos));
    datosGuiasBines(query,nroguia,nrobin,fechahra,opcion).then(datosguiadia => {
        respuesta.json(datosguiadia[0]);
    })
})


//---------------------------------------------------------
/*Conexion al Sp que devuelve los registros de las guias*/
//---------------------------------------------------------
let datosGuiasDia = async(query,opcion,nroguia) => {
    try {
        let pool = await sql.connect(config);
        let datguia = await pool.request()
            .input('opcion', sql.Char, opcion)
            .input('nroguia', sql.Char, nroguia)
            .execute(query);
        
        return datguia.recordsets;
        
    } catch (error) {
        console.log(error);
    }
}

//---------------------------------------------------------
/*Conexion al Sp que Realiza las Inserciones*/
//---------------------------------------------------------
let datosGuiasBines = async(query,nroguia,nrobin,fechahra,opcion) => {
    try {
        let pool = await sql.connect(config);
        let datguia = await pool.request()
            .input('opcion', sql.Char, opcion)
            .input('nroguia', sql.Char, nroguia)
            .input('nroBin', sql.Char, nrobin)
            .input('fechahra', sql.Char, fechahra)
            .execute(query);
        
        return datguia.recordsets;
        
    } catch (error) {
        console.log(error);
    }


}

module.exports = app;