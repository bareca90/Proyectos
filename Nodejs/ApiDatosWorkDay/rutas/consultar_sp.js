const config = require('../configuraciones/configuracion_base');
/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const app = express();
//---------------------------------------------------------
/*Ruta para Post de los empleados que se reciben */
//---------------------------------------------------------
/**
 * @swagger
 * components:
 *  schemas:
 *      Hire:
 *          type: object
 *          properties:
 *              emplcod_wd:
 *                  type: string
 *                  description: Codigo Empleado Work Day
 *              CnctFecReg:
 *                  type : string
 *                  description: Fecha de Registro del Empleado
 *              EmplValSue:
 *                  type: number
 *                  description: Salario del empleado
 *              tconcod:
 *                  type: string
 *                  description: Tipo de Contrato del empleado
 *              EmplPerPag:
 *                  type: string
 *                  description: Periodo de Pago QUincenal , etc
 *              CnctCodSta:
 *                  type: string
 *                  description: Estado del Contrato 
 *              emplfecant:
 *                  type: string
 *                  description: Fecha del contrato
 *              cnctclscnt:
 *                  type: string
 *                  description: Tipo de Contrato
 *              job_cod:
 *                  type: string
 *                  description: JOb Cod de Workday
 *              org_id:
 *                  type: string
 *                  description: Org id de WorkDay
 *              emplfecing:
 *                  type: string
 *                  description: Fecha Ingreso del empleado
 *              empldir:
 *                  type: string
 *                  description: Direccion Domicilio del empleado
 *              emplnompri:
 *                  type: string
 *                  description: Primer Nombre del Empleado
 *              emplnomseg:
 *                  type: string
 *                  description: Segundo Nombre del Empleado
 *              emplapepat:
 *                  type: string
 *                  description: Apellido Paterno del empleado
 *              emplapemat:
 *                  type: string
 *                  description: Apellido materno del empleado
 *              emplfecnac:
 *                  type: string
 *                  description: Fecha Nacimiento del empleado
 *              EmplNumCed:
 *                  type: string
 *                  description: Numero IDentificacion del empleado
 *              MuleSoft_Id:
 *                  type: string
 *                  description: Id Enviado por Mulesoft
 *              Fecha_WD:
 *                  type: string
 *                  description: Fecha de Ejecucion WorkDay
 *          required:
 *              -emplcod_wd
 *              -CnctFecReg
 *              -EmplValSue
 *              -tconcod
 *              -EmplPerPag
 *              -CnctCodSta
 *              -emplfecant
 *              -cnctclscnt
 *              -job_cod
 *              -org_id
 *              -emplfecing
 *              -empldir
 *              -emplnompri
 *              -emplnomseg
 *              -emplapepat
 *              -emplapemat
 *              -emplfecnac
 *              -EmplNumCed
 *              -MuleSoft_Id
 *              -Fecha_WD
 *          example:
 *              emplcod_wd:	WRKeCU00004
 *              CnctFecReg:	2018-04-01
 *              EmplValSue:	800.50	 
 *              tconcod:	00001
 *              EmplPerPag:	Q
 *              CnctCodSta:	00001
 *              emplfecant:	2022-07-01
 *              cnctclscnt:	I
 *              job_cod: D000025
 *              org_id:	D000141
 *              emplfecing:	 2018-04-01
 *              empldir:	 Milagro, ciudadela bellavista av de las aguas
 *              emplnompri:	Antonio
 *              emplnomseg:	Jose
 *              emplapepat:	Reyes
 *              emplapemat:	Campuzano
 *              emplfecnac:	1990-08-06
 *              EmplNumCed:	0934567890
 *              MuleSoft_Id: Wdfttt122633
 *              Fecha_WD:   2022-06-08
 */
/***
 * @swagger
 *  /apiwd/dataemployees:
 *      post: 
 *          summery: Permite Crear los Nuevos Empleados
 *          tags: [Hire]
 *          requestBody:
 *              required: true
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          $ref: '#/components/schemas/Hire'
 *          responses : 
 *              200:
 *                  description: Registros agregados 
 */                         
//---------------------------------------------------------
app.post('/dataemployees', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let query = 'SP_Insert_Hire';
    //console.log(JSON.stringify(datos));
    datosCliente(query, datos).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })
})
//---------------------------------------------------------
/*Ruta para Post de los datos que vienen por termination */
//---------------------------------------------------------
/**
 * @swagger
 * components:
 *  schemas:
 *      Termination:
 *          type: array
 *          properties:
 *              emplcod_wd:
 *                  type: string
 *                  description: Codigo Empleado Work Day
 *              CnctFecReg:
 *                  type : string
 *                  description: Fecha de Registro del Empleado
 *              mobjcod:
 *                  type: number
 *                  description: Motivo de baja del empleado
 *              CnctCodSta:
 *                  type: string
 *                  description: Tipo de Contrato del empleado
 *              CnctFecLiq:
 *                  type: string
 *                  description: Periodo de Pago QUincenal , etc
 *              MuleSoft_Id:
 *                  type: string
 *                  description: Id Enviado por Mulesoft
 *              Fecha_WD:
 *                  type: string
 *                  description: Fecha de Ejecucion WorkDay
 *          required:
 *              -emplcod_wd
 *              -CnctFecReg
 *              -mobjcod
 *              -CnctCodSta
 *              -CnctFecLiq
 *              -Cnctusrlog
 *              -MuleSoft_Id
 *              -Fecha_WD
 *          example:
 *              emplcod_wd:	WRKeCU00004
 *              CnctFecReg:	2018-04-01
 *              mobjcod : WD00123
 *              CnctCodSta : 00001
 *              CnctFecLiq : 2022-10-01
 *              Cnctusrlog : DFgg0001
 *              MuleSoft_Id: Wdfttt122633
 *              Fecha_WD:   2022-06-08
 */
/***
 * @swagger
 *  /apiwd/datatermination:
 *      post: 
 *          summery: Permite Crear los Nuevos Empleados
 *          tags: [Termination]
 *          requestBody:
 *              required: true
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          $ref: '#/components/schemas/Termination'
 *          responses : 
 *              200:
 *                  description: Registros agregados 
 */  


//---------------------------------------------------------
app.post('/datatermination', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let query = 'SP_Insert_Termination';
    //console.log(JSON.stringify(datos));
    datosCliente(query, datos).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })
    

})
/*Conexion a Sp que devuelve los datos de los clientes*/
let datosCliente = async(query, pJson) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('pJson', sql.Char, pJson)
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}
/*Conexion a Sp que devulve datos para get*/
let datosGetWordDay = async(query) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}

//---------------------------------------------------------
/*Ruta para Post de los datos que vienen por Change */
//---------------------------------------------------------
app.post('/datoschanges', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let query = 'SP_Insert_Changes';
    //console.log(JSON.stringify(datos));
    datosCliente(query, datos).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })
    

})
//---------------------------------------------------------
/*Ruta para Get para devolver los errores */
//---------------------------------------------------------
app.get('/errorviewer', function(req, respuesta) {
    let query = 'SP_Devolver_Errores';
    //console.log(JSON.stringify(datos));
    datosGetWordDay(query).then(datosgetworkday => {
        respuesta.json(datosgetworkday[0]);
    })
    

})
module.exports = app;