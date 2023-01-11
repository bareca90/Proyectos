const config = require('../configuraciones/configuracion_base');
/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const app = express();

/*Conexion a Sp que devuelve los datos de los clientes*/
let datosCliente = async(query, cliente) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('cliente', sql.Char, cliente)
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}
/*Conexion a Sp que devuelve los datos de los clientes*/
let datosSolAnticipo = async(query, datsolant) => {
    try {
        let pool = await sql.connect(config);
        let datsolants = await pool.request()
            .input('pjson', sql.Char, datsolant)
            .execute(query);
        /* console.log(clientes); */
        return datsolants.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}
/*Conexion a SP de  Facturacion y Pagos*/
let datosFactPagos = async(query, datsolant) => {
    try {
        let pool = await sql.connect(config);
        let datsolants = await pool.request()
            .input('pjson', sql.Char, datsolant)
            .execute(query);
        /* console.log(clientes); */
        return datsolants.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}
/*Conexion a Sp que devuelve los Vo Aprobados*/
let datosVoAprobados = async(query, docuprvsecuencia,divisionn) => {
    try {
        let pool = await sql.connect(config);
        let datvoapr = await pool.request()
            .input('docuprvsecuencia', sql.Int, docuprvsecuencia)
            .input('divisionn', sql.Char, divisionn)
            .execute(query);
        /* console.log(clientes); */
        return datvoapr.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}
/*Conexion a Sp que Inserta los resultados del SCI*/
let datosIngresoSci = async(query, ltApNoRef,ltApStaRes,ltApFecCad,ltApCodSCI) => {
    try {
        let pool = await sql.connect(config);
        let datvoapr = await pool.request()
            .input('LtApNoRef', sql.Char, ltApNoRef)
            .input('LtApStaRes', sql.Char, ltApStaRes)
            .input('LtApFecCad', sql.Date, ltApFecCad)
            .input('LtApCodSCI', sql.Char, ltApCodSCI)
            .execute(query);
        /* console.log(clientes); */
        return datvoapr.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }
}

/*Conexion a Sp que Consulta Datos del SCI*/
let datosConsutlaSci = async(query, ltApNoRef) => {
    try {
        let pool = await sql.connect(config);
        let datsci = await pool.request()
            .input('LtApNoRef', sql.Char, ltApNoRef)
            .execute(query);
        /* console.log(clientes); */
        return datsci.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }
}


/*Ruta para Obtener Datos Cliente */
app.get('/datoscliente', function(req, respuesta) {
    let cliente = req.query.cliente ;
    let query = 'Sp_Datos_Cliente';
    datosCliente(query, cliente).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })

})

/*Rutas Post Para Enviar Sol Anticipo */
app.post('/postsolanti', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let query = 'SP_Datos_Rpa_Sol_Anticipos';
    console.log('Llego hasta aqui');
    datosSolAnticipo(query, datos).then(datossolanticipo => {
        respuesta.json(datossolanticipo[0]);
    })

})

/*Rutas Post Para Enviar Facturación y Pagos */
app.post('/postfacpagos', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let query = 'SP_Datos_Rpa_Fac_Pagos';
    datosFactPagos(query, datos).then(datosfactpagos => {
        respuesta.json(datosfactpagos[0]);
    })

})

/*Rutas Post Para Obtener VO Aprobados */
app.post('/voaprobados', function(req, respuesta) {
    let docuprvsecuencia = req.query.docuprvsecuencia;
    let division   = req.query.division;  
    let query = 'Sp_Devuleve_OS_Aprobada';
    
    datosVoAprobados(query, docuprvsecuencia,division).then(datosvoaprobados => {
        respuesta.json(datosvoaprobados[0]);
    })

})
/*Ruta para actualizar datos del certificado SCI*/
app.put('/ingresasci', function(req, respuesta) {
    let ltApNoRef	=   req.query.ltApNoRef ;
	let ltApStaRes	=   req.query.ltApStaRes ;	
	let ltApFecCad	=	req.query.ltApFecCad ;    
	let ltApCodSCI	=	req.query.ltApCodSCI ;
    let query       = 'SP_Actualiza_Reg_SCI';
    datosIngresoSci(query, ltApNoRef,ltApStaRes,ltApFecCad,ltApCodSCI).then(datosingresosci => {
        respuesta.json(datosingresosci[0]);
    })

})

/*Ruta para Consultar Datos del SCI*/
app. get('/consultasci', function(req, respuesta) {
    let ltApNoRef	=   req.query.ltApNoRef ;
	let query       =   'SP_Consutla_Datos_SCI';
    console.log(ltApNoRef);
    datosConsutlaSci(query, ltApNoRef).then(datosconsultasci => {
        respuesta.json(datosconsultasci[0]);
    })

})


module.exports = app;