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
 *          type: array
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
 *              tconcod:	QUINCENAL
 *              EmplPerPag:	Q
 *              CnctCodSta:	ACTIVO
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
 *              EmplNumCed:	120670217-5
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
 *                  type: string
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
 *          summery: Permite Insertar los Empleados que son dados de baja
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
//---------------------------------------------------------
/*Ruta para Post de los datos que vienen por Change */
//---------------------------------------------------------
/**
 * @swagger
 * components:
 *  schemas:
 *      Changes:
 *          type: array
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
 *              mobjcod:
 *                  type: string
 *                  description: Motivo de baja del empleado
 *              CnctFecLiq:
 *                  type: string
 *                  description: Periodo de Pago QUincenal , etc
 *              cnctno:
 *                  type : number 
 *                  description : Permite registrar el numero de contrato
 *              emplconcon:
 *                  type: string
 *                  description: Permite registrar las condiciones de contratacion
 *              Emplfecifp:
 *                  type: string
 *                  description: Permite registrar la fecha donde inicia la forma de pago
 *              emplcodcco:
 *                  type: string
 *                  description: Permite registrar el centro de costo
 *              cnctfeccds:
 *                  type: string
 *                  description: Fecha de Cambio de Sueldo
 *              emplsuenew:
 *                  type : number 
 *                  description: Nuevo Salario
 *              emplTipLic:
 *                  type : string
 *                  description : Tipo liquidacion del empleado
 *              rhcnct_grpgcod:
 *                  type : string 
 *                  description : grupo de Pago
 *              rhcnct1_bonocod:
 *                  type : string
 *                  description : Tipo de Bonificacion
 *              rhcnct1_cnctvbnwd:
 *                  type : string
 *                  description : Tipo de Compensacion WD
 *              rhCnct7_onetcodwd:
 *                  type : string
 *                  description : Descripcion Otros Incentivos
 *              rhCnct7_onetdol:
 *                  type : number
 *                  description : Valor en Dolares
 *              rhcnct_tctacod:
 *                  type : string
 *                  description : Tipo de Cuenta
 *              rhcnct_TpagCod:
 *                  type : string
 *                  description : Tipo de Pago del Empleado
 *              rhcnct_banccod:
 *                  type : string
 *                  description : Banco donde se acredita el salario del empleado
 *              rhcnct_EmplNumCta:
 *                  type : string
 *                  description : Numero de Cuenta Bancaria
 *              rhempl_EmplDesNac:
 *                  type : string
 *                  description : Nacionalidad del empleado
 *              rhempl_ecivcod:
 *                  type : string
 *                  description : Estado Civil 
 *              rhempl_sexocod:
 *                  type : string
 *                  description : Descripcion del Sexo
 *              rhempl_emplcnsxds:
 *                  type : string
 *                  description : Condicion de Discapacidad
 *              rhempl_emplgrdmrl:
 *                  type : number
 *                  description : Porcentaje discapacidad
 *              rhcnct_cnctfinent:
 *                  type : string
 *                  description : Fecha Finalizaciòn del entrenamiento
 *              PermFini::
 *                  type : string
 *                  description : Fecha Inicio del Permiso
 *              PermFfin:
 *                  type : string
 *                  description : Fecha Fin del Permiso
 *              PermSta01:
 *                  type : string
 *                  description : Tipo del Permiso
 *              vacastawd:
 *                  type : string
 *                  description : Tipo de Vacaciones 
 *              vacadsf:
 *                  type : string
 *                  description : Fecha de la Vacacion Tomada
 *              dias:
 *                  type: int
 *                  description : Dias de Vacaciones Tomadas
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
 *              -mobjcod
 *              -CnctFecLiq
 *              -cnctno
 *              -emplconcon
 *              -Emplfecifp
 *              -emplcodcco
 *              -cnctfeccds
 *              -emplsuenew
 *              -emplTipLic
 *              -rhcnct_grpgcod
 *              -rhcnct1_bonocod
 *              -rhcnct1_cnctvbnwd
 *              -rhCnct7_onetcodwd
 *              -rhCnct7_onetdol
 *              -rhcnct_tctacod
 *              -rhcnct_TpagCod
 *              -rhcnct_banccod
 *              -rhcnct_EmplNumCta
 *              -rhempl_EmplDesNac
 *              -rhempl_ecivcod
 *              -rhempl_sexocod
 *              -rhempl_emplcnsxds
 *              -rhempl_emplgrdmrl
 *              -rhcnct_cnctfinent
 *              -PermFini
 *              -PermFfin
 *              -PermSta01
 *              -vacastawd
 *              -vacadsf
 *              -dias
 *              -MuleSoft_Id
 *              -Fecha_WD
 *          example:
 *              emplcod_wd:	WRKeCU00004
 *              CnctFecReg:	2018-04-01
 *              EmplValSue:	800.50	 
 *              tconcod:	QUINCENAL
 *              EmplPerPag:	Q
 *              CnctCodSta:	ACTIVO
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
 *              EmplNumCed:	120670217-5
 *              mobjcod : D00123
 *              CnctFecLiq:  2022-01-01
 *              cnctno:     1
 *              emplconcon:  loremipsum loremipsum loremi
 *              Emplfecifp:  2022-01-01
 *              emplcodcco:  DF00011
 *              cnctfeccds: 2018-04-01
 *              emplsuenew:  1500.32
 *              emplTipLic:  ECU_CI
 *              rhcnct_grpgcod:  PG_ECU_1_QUI
 *              rhcnct1_bonocod: MENSUAL
 *              rhcnct1_cnctvbnwd:  ANUAL
 *              rhCnct7_onetcodwd: OTROS INCENTIVOS
 *              rhCnct7_onetdol:  1600.20
 *              rhcnct_tctacod:     CUENTA
 *              rhcnct_TpagCod:  DEPOSITO BANCARIO
 *              rhcnct_banccod:  GUAYAQUIL
 *              rhcnct_EmplNumCta:  1025320-5
 *              rhempl_EmplDesNac:  ECUATORIANA
 *              rhempl_ecivcod:  SOLTERO
 *              rhempl_sexocod:  MASCULINO
 *              rhempl_emplcnsxds:  NINGUNA
 *              rhempl_emplgrdmrl:  25.60
 *              rhcnct_cnctfinent:  2022-01-01
 *              PermFini:  2022-02-02
 *              PermFfin:  2022-02-02
 *              PermSta01:  LT_ECU_1
 *              vacastawd:  TOT_ECU_Duelo
 *              vacadsf:  2022-08-29
 *              dias:  1
 *              MuleSoft_Id: Wdfttt122633
 *              Fecha_WD:   2022-06-08
 */
/***
 * @swagger
 *  /apiwd/datoschanges:
 *      post: 
 *          summery: Permite Almacenar los cambios , permisos o vacaciones del empleado
 *          tags: [Changes]
 *          requestBody:
 *              required: true
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          $ref: '#/components/schemas/Changes'
 *          responses : 
 *              200:
 *                  description: Registros agregados correctamente
 */     
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
/*Conexion a Sp que devuelve los datos de los clientes*/
//---------------------------------------------------------
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
//---------------------------------------------------------
/*Conexion a Sp que devulve datos para get*/
//---------------------------------------------------------
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