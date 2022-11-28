const config = require('../configuraciones/configuracion_base');
/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const app = express();
//---------------------
//Variables Globales 
//---------------------
let contador=0;
let contador_contratos=0;
let contador_salarios=0;
let contador_bonus=0;
let contador_posiciones =0;
let contador_direcciones =0;
let contador_nombres=0;
let contador_documentos=0;
let contador_pagos=0;
let contador_elecciones;
let contador_discapacidad=0;
let contador_excedencias=0;
let contador_timeoffs
let fecha_actual;
let pk_unidos;

let datosmap = {};
//---------------------------------------------------------
/*Middleware */
//---------------------------------------------------------



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
 *                  required: true
 *                  type: string
 *                  description: Codigo Empleado Work Day
 *              CnctFecReg:
 *                  required: true
 *                  type : string
 *                  description: Fecha de Registro del Empleado
 *              EmplValSue:
 *                  type: number
 *                  description: Salario del empleado
 *              tconcod:
 *                  type: string
 *                  description: Tipo de Contrato del empleado
 *              CnctCodSta:
 *                  type: string
 *                  description: Estado del Contrato 
 *              emplfecant:
 *                  required: true
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
 *                  required: true
 *                  type: string
 *                  description: Fecha Ingreso del empleado
 *              empldir:
 *                  type: string
 *                  description: Direccion Domicilio del empleado
 *              emplnompri:
 *                  required: true
 *                  type: string
 *                  description: Primer Nombre del Empleado
 *              emplnomseg:
 *                  type: string
 *                  description: Segundo Nombre del Empleado
 *              emplapepat:
 *                  required: true
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
 *          example:
 *              emplcod_wd:	WRKeCU00004
 *              CnctFecReg:	2018-04-01
 *              EmplValSue:	800.50	 
 *              tconcod:	QUINCENAL
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
 *                          type: object
 *                          $ref: '#/components/schemas/Hire'
 *          responses : 
 *              200:
 *                  description: Registros agregados 
 */                         
//---------------------------------------------------------
app.post('/dataemployees', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let head  = JSON.stringify(req.headers);
    let query = 'SP_Insert_Hire';
    //console.log(JSON.stringify(datos));
    datosCliente(query, datos,head).then(datoscliente => {
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
 *          type: object
 *          properties:
 *              emplcod_wd:
 *                  required: true
 *                  type: string
 *                  description: Codigo Empleado Work Day
 *              CnctFecReg:
 *                  required: true
 *                  type : string
 *                  description: Fecha de Registro del Empleado
 *              mobjcod:
 *                  required: true
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
 *          example:
 *              emplcod_wd:	WRKeCU00004
 *              CnctFecReg:	2018-04-01
 *              mobjcod : WD00123
 *              CnctCodSta : inactivo
 *              CnctFecLiq : 2022-10-01
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
 *                          type: object
 *                          $ref: '#/components/schemas/Termination'
 *          responses : 
 *              200:
 *                  description: Registros agregados 
 */  


//---------------------------------------------------------
app.post('/datatermination', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let head  = JSON.stringify(req.headers);
    let query = 'SP_Insert_Termination';
    //console.log(JSON.stringify(datos));
    datosCliente(query, datos,head).then(datoscliente => {
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
 *          type: object
 *          properties:
 *              DERIVED_EVENT_CODE:
 *                  type: string
 *                  description: Event Code       
 *              EFECTIVE_MOMENT: 
 *                  type: string
 *                  description: Fecha efectiva Expatriado
 *              emplcod_wd:
 *                  required: true
 *                  type: string
 *                  description: Codigo Empleado Work Day
 *              Contratos_Empleados:
 *                  type: object 
 *                  properties:
 *                      CnctFecReg:
 *                          required: true
 *                          type : string
 *                          description: Fecha de Registro del Empleado
 *                      Estado_CnctFecReg:
 *                          type: string  
 *                          description: Estado Fecha Registreo
 *                      tconcod:
 *                          type: string
 *                          description: Tipo de Contrato del empleado
 *                      Estado_tconcod:
 *                          type: string
 *                          description: Estado tipo contrato
 *                      cnctclscnt:
 *                          type: string
 *                          description: Tipo de Contrato
 *                      Estado_cnctclscnt:
 *                          type: string 
 *                          description: Estado Tipo de Contrato
 *                      cnctno:
 *                          type : number 
 *                          description: Permite registrar el numero de contrato
 *                      Estado_cnctno:
 *                          type: string
 *                          description: Estado  numero de contrato
 *                      emplconcon:
 *                          type: string
 *                          description: Permite registrar las condiciones de contratacion
 *                      Estado_emplconcon:
 *                          type: string
 *                          description: Estado condiciones de contratacion
 *              Planes_Compensaciones:              
 *                  type: object
 *                  properties: 
 *                      Salarios:
 *                          type: object
 *                          properties:
 *                              EmplValSue:
 *                                  type: money
 *                                  description: Salario del empleado
 *                              Estado_EmplValSue:
 *                                  type: string
 *                                  description: Estado Salario del Empleado
 *                              cnctfeccds:
 *                                  type: string
 *                                  description: Fecha de Cambio de Sueldo
 *                              Estado_cnctfeccds:
 *                                  type: string
 *                                  description: Estado Fecha Cambio de Sueldo
 *                              END_DATE:
 *                                  type: string
 *                                  description: fecha finalizacion
 *                              Estado_END_DATE:
 *                                  type: string
 *                                  description: estado fecha finalizacion
 *                      Bonus:
 *                          type: object
 *                          properties:
 *                              rhcnct1_bonocod: 
 *                                  type: string
 *                                  description: Tipo de Bonificacion
 *                              Estado_rhcnct1_bonocod:
 *                                  type: string
 *                                  description: estado tipo de bonificacion
 *                              rhcnct1_cnctvbnwd:
 *                                  type: money
 *                                  description: Tipo de Compensacion
 *                              Estado_rhcnct1_cnctvbnwd:
 *                                  type: string
 *                                  description: Estado tipo de compensacion
 *              CnctCodSta:
 *                 type: string
 *                 description: Estado del Contrato 
 *              emplfecant:
 *                  type: string
 *                  description: Fecha del contrato
 *              Posiciones:
 *                  type: object
 *                  properties:
 *                      job_cod:
 *                          type: string
 *                          description: JOb Cod de Workday
 *                      Estado_job_cod:
 *                          type: string
 *                          description: Estadi de Job Cod WorkDay
 *                      PRIMARY_JOB:
 *                          type: string
 *                          description: primer trabajo
 *                      Estado_PRIMARY_JOB:
 *                          type: string
 *                          description: estado primer trabajo
 *                      Organizaciones:
 *                          type: object
 *                          properties:
 *                              org_id:
 *                                  type: string
 *                                  description: organization id
 *                              Estado_org_id:
 *                                  type: string
 *                                  description: estado oganizacion id
 *                              Organization_Type:
 *                                  type: string 
 *                                  description: tipo org id
 *                              Estado_Organization_Type:
 *                                  type: string
 *                                  description: estado tipo org id
 *                      rhcnct_cnctfinent:
 *                          type: string
 *                          description: fecha finalizacion entrenamiento
 *                      Estado_rhcnct_cnctfinent:
 *                          type: string
 *                          description: Estado fecha finalizacion entrenamiento
 *              emplfecing:
 *                  type: string
 *                  description: Fecha ingreso del colaborador
 *              Direcciones:
 *                  type: object
 *                  properties:
 *                      empldir: 
 *                          type: string
 *                          description: Direccion del empleado
 *                      Estado_empldir:
 *                          type: string
 *                          description: Estado de direccion del empleado
 *              Nombres_Legales:
 *                  type: object
 *                  properties:
 *                      emplnompri: 
 *                          type: string
 *                          description: Primer Nombre del empleado
 *                      Estado_emplnompri:
 *                          type: string
 *                          description: Estado Primer Nombre del empleado
 *                      emplnomseg:
 *                          type: string
 *                          description: Segundo Nombre
 *                      Estado_emplnomseg:
 *                          type: string
 *                          description: Estado  Segundo Nombre
 *                      emplapepat:
 *                          type:  string
 *                          description: Primer Apellido paterno
 *                      Estado_emplapepat:
 *                          type: string
 *                          description: Estado Apellido paterno
 *                      emplapemat:
 *                          type: string
 *                          description: Segundo Apellido
 *                      Estado_emplapemat:
 *                          type: string
 *                          description: Estado Segundo Apellido
 *              emplfecnac:
 *                  type: string
 *                  description: Fecha de Nacimiento
 *              Documentos:
 *                  type: objact
 *                  properties:
 *                      EmplNumCed: 
 *                          type: string
 *                          description: Numero de Cedula
 *                      Estado_EmplNumCed: 
 *                          type: string
 *                          description: Estado Numero de Cedula
 *                      emplTipLic:
 *                          type: string
 *                          description: tipo licencia
 *                      Estado_emplTipLic:
 *                          type: string
 *                          description: Estado tipo licencia
 *              mobjcod:
 *                  type: string
 *                  description: Motivo de baja del empleado
 *              CnctFecLiq:
 *                  type: string
 *                  description: Periodo de Pago QUincenal , etc
 *              Emplfecifp:
 *                  type: string
 *                  description: Permite registrar la fecha donde inicia la forma de pago
 *              rhcnct_grpgcod:
 *                  type : string 
 *                  description : grupo de Pago
 *              Pagos_Unicos_De_Compensaciones:
 *                  type: objact
 *                  properties: 
 *                      rhCnct7_onetcodwd: 
 *                          type: string
 *                          description: Descripcion Otros Incentivos
 *                      Estado_rhCnct7_onetcodwd:
 *                          type: string
 *                          description: Estado Descripcion Otros Incentivos
 *                      rhCnct7_onetdol:
 *                          type: money
 *                          description: Valor en Dolares    
 *                      Estado_rhCnct7_onetdol: 
 *                          type: string
 *                          description: Estado Valor en Dolares
 *              Elecciones_Pagos:
 *                  type: object
 *                  properties:
 *                      rhcnct_tctacod:
 *                          type: string
 *                          description: Tipo de Eleccion de Pago
 *                      Estado_rhcnct_tctacod:
 *                          type: string
 *                          description: Estado de Elecciones de Pago
 *                      rhcnct_TpagCod:
 *                          type: string
 *                          description:  Tipo de Pago
 *                      Estado_rhcnct_TpagCod:
 *                          type: string
 *                          description: Estado Tipo de Pago
 *                      rhcnct_banccod:
 *                          type: string
 *                          description: Banco
 *                      Estado_banccod:
 *                          type: string
 *                          description: Estado banco
 *                      rhcnct_EmplNumCta:
 *                          type: string
 *                          description: Numero de Cedula
 *                      Estado_rhcnct_EmplNumCta:
 *                          type: string
 *                          description: Estado Numero de Cedula
 *              rhempl_EmplDesNac:
 *                  type : string
 *                  description : Nacionalidad del empleado
 *              rhempl_ecivcod:
 *                  type : string
 *                  description : Estado Civil 
 *              rhempl_sexocod:
 *                  type : string
 *                  description : Descripcion del Sexo
 *              Estados_Discapacidad:
 *                  type: object
 *                  properties:
 *                      rhempl_emplcnsxds:
 *                          type: string
 *                          description: discapacidad
 *                      Estado_rhempl_emplcnsxds:
 *                          type: string
 *                          description: estado discapacidad
 *                      rhempl_emplgrdmrl:
 *                          type: money
 *                          description: Porcentaje Discapacidad
 *                      Estado_rhempl_emplgrdmrl:
 *                          type: string
 *                          description: Estado Porcentaje Discapacidad
 *              Excedencias:
 *                  type: object
 *                  properties: 
 *                      PermFini: 
 *                          type: string
 *                          description:  fecha Inicial del permiso 
 *                      Estado_PermFini:
 *                          type: string
 *                          description:   Estado  fecha Inicial del permiso 
 *                      PermFfin:
 *                          type: string
 *                          description: Fecha Fin
 *                      Estado_PermFfin:
 *                          type: string 
 *                          description: Estado Fecha Fin
 *                      PermSta01:
 *                          type: string
 *                          description: Tipo de Permiso
 *                      Estado_PermSta01:
 *                          type: string
 *                          description: estado tipo de permiso
 *              MuleSoft_Id:
 *                  type: string
 *                  description: Mulesoft ID
 *              Fecha_WD:
 *                  type: string
 *                  description: Fecha Wd
 *              TIME_OFFS:
 *                  type: object
 *                  properties: 
 *                      ID_TIME_OFF: 
 *                          type:   string
 *                          description: Id Time Off
 *                      ESTADO_ID_TIME_OFF:
 *                          type: string
 *                          description: Estado Id Time Off
 *                      NOMBRE_TIME_OFF:
 *                          type: string
 *                          description: Nombre Time Off
 *                      ESTADO_NOMBRE_TIME_OFF:
 *                          type: string
 *                          description: Estado nombre time off
 *                      TIPO_TIME_OFF:
 *                          type: string
 *                          description: Tipo Time Off
 *                      ESTADO_TIPO_TIME_OFF:
 *                          type: string
 *                          description: Estado Tipo Time Off
 *                      UNIDAD_DE_MEDIDA:
 *                          type: string
 *                          description: Unidad de Medida Time Off
 *                      ESTADO_UNIDAD_DE_MEDIDA:
 *                          type: string
 *                          description: Estado Unidad de Medida Time Off
 *                      FECHA_EFECTIVA: 
 *                          type: string
 *                          description: Fecha Efectiva
 *                      TIME_OFF_ENTRIES:
 *                          type: object
 *                          properties: 
 *                              CANTIDAD: 
 *                                  type: string
 *                                  description: Cantidad  
 *                              ESTADO_CANTIDAD:
 *                                  type: string
 *                                  description: Estado Cantidad
 *                              INICIO:
 *                                  type: string
 *                                  description: Inicio del Time Off
 *                              ESTADO_INICIO:
 *                                  type: string
 *                                  description: Estado Incio el Time Off
 *                              FIN:
 *                                  type: string
 *                                  description: Fin del Time Off
 *                              ESTADO_FIN:
 *                                  type: string
 *                                  description: Estado Fin del Time Off
 *          example:
 *              DERIVED_EVENT_CODE: DTA
 *              EFECTIVE_MOMENT: 2022-09-27T
 *              emplcod_wd: WRKeCU00004
 *              Contratos_Empleados:
 *                  CnctFecReg: 2018-04-01
 *                  Estado_CnctFecReg: null
 *                  tconcod: QUINCENAL
 *                  Estado_tconcod: null
 *                  cnctclscnt: I
 *                  Estado_cnctclscnt: null
 *                  cnctno: 1
 *                  Estado_cnctno: null
 *                  emplconcon: loremipsum loremipsum loremi
 *                  Estado_emplconcon: null
 *              Planes_Compensaciones:              
 *                  Salarios:
 *                      EmplValSue: 5000.23
 *                      Estado_EmplValSue: null
 *                      cnctfeccds: 2018-04-01
 *                      Estado_cnctfeccds: null
 *                      END_DATE: 2018-04-01
 *                      Estado_END_DATE: null
 *                  Bonus:
 *                      rhcnct1_bonocod: MENSUAL
 *                      Estado_rhcnct1_bonocod: null
 *                      rhcnct1_cnctvbnwd: 1500
 *                      Estado_rhcnct1_cnctvbnwd: null
 *              CnctCodSta: ACTIVO
 *              emplfecant: 2022-07-01
 *              Posiciones:
 *                  job_cod: D000025
 *                  Estado_job_cod: null
 *                  PRIMARY_JOB:  42
 *                  Estado_PRIMARY_JOB: null
 *                  Organizaciones: 
 *                      org_id: D000141
 *                      Estado_org_id: null
 *                      Organization_Type: Cost Center
 *                      Estado_Organization_Type: null
 *                  rhcnct_cnctfinent: 2022-01-01
 *                  Estado_rhcnct_cnctfinent: null
 *              emplfecing: 2018-04-01
 *              Direcciones: 
 *                      empldir: Milagro, ciudadela bellavista av de las aguas
 *                      Estado_empldir: null
 *              Nombres_Legales:
 *                  emplnompri: Bairon
 *                  Estado_emplnompri: null
 *                  emplnomseg: EDwin
 *                  Estado_emplnomseg: null
 *                  emplapepat: Reyes 
 *                  Estado_emplapepat: null
 *                  emplapemat: Campuzano
 *                  Estado_emplapemat: null
 *              emplfecnac: 1990-08-06
 *              Documentos:
 *                  EmplNumCed:  1206702175
 *                  Estado_EmplNumCed:  null
 *                  emplTipLic: ECU_CI
 *                  Estado_emplTipLic: null
 *              mobjcod:  D00123
 *              CnctFecLiq: 2022-01-01
 *              Emplfecifp: 2022-01-01
 *              rhcnct_grpgcod: PG_ECU_1_QUI
 *              Pagos_Unicos_De_Compensaciones:
 *                  rhCnct7_onetcodwd: OTROS INCENTIVOS
 *                  Estado_rhCnct7_onetcodwd: null
 *                  rhCnct7_onetdol: 1600.32
 *                  Estado_rhCnct7_onetdol: null
 *              Elecciones_Pagos:
 *                  rhcnct_tctacod: CUENTA
 *                  Estado_rhcnct_tctacod: null
 *                  rhcnct_TpagCod: DEPOSITO BANCARIO
 *                  Estado_rhcnct_TpagCod: null
 *                  rhcnct_banccod: GUAYAQUIL
 *                  Estado_banccod: null
 *                  rhcnct_EmplNumCta: 1025320-5
 *                  Estado_rhcnct_EmplNumCta: null
 *              rhempl_EmplDesNac: ECUATORIANO
 *              rhempl_ecivcod: SOLTERO
 *              rhempl_sexocod: MASCULINO
 *              Estados_Discapacidad:
 *                  rhempl_emplcnsxds: NINGUNO
 *                  Estado_rhempl_emplcnsxds: null
 *                  rhempl_emplgrdmrl: 12.30
 *                  Estado_rhempl_emplgrdmrl: null
 *              Excedencias:
 *                  PermFini: 2022-02-02
 *                  Estado_PermFini: null
 *                  PermFfin: 2022-02-02
 *                  Estado_PermFfin: null
 *                  PermSta01: LT_ECU_1
 *                  Estado_PermSta01: null
 *              MuleSoft_Id: Wdfttt122633
 *              Fecha_WD: 2022-06-08
 *              TIME_OFFS:
 *                  ID_TIME_OFF: null
 *                  ESTADO_ID_TIME_OFF: null
 *                  NOMBRE_TIME_OFF: null
 *                  ESTADO_NOMBRE_TIME_OFF: null 
 *                  TIPO_TIME_OFF: TOT_ESP_Salida particular no retribuida
 *                  ESTADO_TIPO_TIME_OFF: null
 *                  UNIDAD_DE_MEDIDA: HOURS
 *                  ESTADO_UNIDAD_DE_MEDIDA: null
 *                  FECHA_EFECTIVA:  2022-11-15T00:00:00.000-08:002022-11-15T00:00:00.000-08:00
 *                  TIME_OFF_ENTRIES:
 *                      CANTIDAD: 2
 *                      ESTADO_CANTIDAD: null
 *                      INICIO: 09:03:00
 *                      ESTADO_INICIO: isAdded
 *                      FIN: 10:39:00
 *                      ESTADO_FIN: isAdded
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
 *                          type: object
 *                          $ref: '#/components/schemas/Changes'
 *          responses : 
 *              200:
 *                  description: Registros agregados correctamente
 */     
//---------------------------------------------------------
/* app.post('/datoschanges', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let head   = JSON.stringify(req.headers);

    

    let query = 'SP_Insert_Changes';
    console.log(head);
    //console.log(JSON.stringify(datos));
    datosCliente(query, datos,head).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })
    

}) */
app.post('/datoschanges', function(req, respuesta) {
    let datos   = JSON.stringify(req.body);
    let head    = JSON.stringify(req.headers);
    let query   = 'SP_Insert_Json_Tmp';
    let query2  = 'SP_Insert_Datos_Changes_Json';
    contador=0;
    //-----------------------
    /*-- Llamada a la Funcion que descompone el Json*/
    //-----------------------
    fnLeerJson(req.body);
    
    //-----------------------
    /*-- Llamada a la Funcion q invoca el sp principal*/
    //-----------------------
    datosCliente(query2, datos,head).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })
    

})
function fnLeerJson (json){
    let DERIVED_EVENT_CODE= '';
    let emplcod_wd='';
    let EFFECTIVE_MOMENT='';

    let CnctFecReg='';
    let Estado_CnctFecReg='';
    let tconcod='';
    let Estado_tconcod='';
    let cnctclscnt;
    let Estado_cnctclscnt;
    let cnctno;
    let Estado_cnctno;
    let emplconcon;
    let Estado_emplconcon;

    let EmplValSue;
    let Estado_EmplValSue;
    let cnctfeccds;
    let Estado_cnctfeccds;
    let END_DATE;
    let Estado_END_DATE;

    let rhcnct1_bonocod;
    let Estado_rhcnct1_bonocod;
    let rhcnct1_cnctvbnwd;
    let Estado_rhcnct1_cnctvbnwd;

    let CnctCodSta;
    let emplfecant;

    let job_cod;
    let Estado_job_cod;
    let PRIMARY_JOB;
    let Estado_PRIMARY_JOB;
    let org_id;
    let Estado_org_id;
    let Organization_Type;
    let Estado_Organization_Type;
    let rhcnct_cnctfinent;
    let Estado_rhcnct_cnctfinent;

    let emplfecing;

    let empldir;
    let Estado_empldir;

    let emplnompri;
    let Estado_emplnompri;
    let emplnomseg;
    let Estado_emplnomseg;
    let emplapepat;
    let Estado_emplapepat;
    let emplapemat;
    let Estado_emplapemat;

    let mobjcod;
    let CnctFecLiq;
    let Emplfecifp;
    let rhcnct_grpgcod;

    let rhcnct_tctacod;
    let Estado_rhcnct_tctacod;
    let rhcnct_TpagCod;
    let Estado_rhcnct_TpagCod;
    let rhcnct_banccod;
    let Estado_banccod;
    let rhcnct_EmplNumCta;
    let Estado_rhcnct_EmplNumCta;

    let rhempl_EmplDesNac;
    let rhempl_ecivcod;
    let rhempl_sexocod;

    let rhempl_emplcnsxds;
    let Estado_rhempl_emplcnsxds;
    let rhempl_emplgrdmrl;
    let Estado_rhempl_emplgrdmrl;

    let PermFini;
    let Estado_PermFini;
    let PermFfin;
    let Estado_PermFfin;
    let PermSta01;
    let Estado_PermSta01;

    let MuleSoft_Id;
    let Fecha_WD;
    let ES_ASIGNACION_INTERNACIONAL;

    let ID_TIME_OFF;
    let ESTADO_ID_TIME_OFF;
    let NOMBRE_TIME_OFF;
    let ESTADO_NOMBRE_TIME_OFF;
    let TIPO_TIME_OFF;
    let ESTADO_TIPO_TIME_OFF;
    let UNIDAD_DE_MEDIDA;
    let ESTADO_UNIDAD_DE_MEDIDA;
    let FECHA_EFECTIVA;

    let CANTIDAD;
    let ESTADO_CANTIDAD;
    let INICIO;
    let ESTADO_INICIO;
    let FIN;
    let ESTADO_FIN;
    let query = 'SP_Insert_Changes_Pruebas';
    //console.log(JSON.stringify(datos));
    for(propiedad in json){
        //----------------------
        //--Base-Root
        //----------------------
        if(propiedad==="DERIVED_EVENT_CODE") {
            DERIVED_EVENT_CODE=json[propiedad];
            contador_contratos      =   0;
            contador_salarios       =   0;
            contador_bonus          =   0;
            contador_posiciones     =   0;
            contador_direcciones    =   0;
            contador_nombres        =   0;
            contador_documentos     =   0;
            contador_pagos          =   0;
            contador_elecciones     =   0;
            contador_discapacidad   =   0;
            contador_excedencias    =   0;
            contador                =   contador+1; 
            fecha_actual            =   new Date();
            fecha_actual            =   fecha_actual.getFullYear()+"-"+(fecha_actual.getMonth()+1)+"-"+fecha_actual.getDate()+'-'+fecha_actual.getHours()+'-'+fecha_actual.getMinutes()+'-'+fecha_actual.getMilliseconds()
            pk_unidos               =   DERIVED_EVENT_CODE+'-'+fecha_actual.toString()+'-'+contador.toString();
            
            datosTabla(query, pk_unidos,'DERIVED_EVENT_CODE',DERIVED_EVENT_CODE,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="emplcod_wd") {
                emplcod_wd=json[propiedad]; 
                datosTabla(query, pk_unidos,'emplcod_wd',emplcod_wd,'1-Principal',0).then(datostabla => {})
                
        }
        if(propiedad==="EFFECTIVE_MOMENT") {
            EFFECTIVE_MOMENT=json[propiedad]; 
            datosTabla(query, pk_unidos,'EFFECTIVE_MOMENT',EFFECTIVE_MOMENT,'1-Principal',0).then(datostabla => {})
        }
        
        //----------------------
        //--Contratos
        //----------------------
        if(propiedad==="CnctFecReg") {
            CnctFecReg=json[propiedad]; 
            contador_contratos=contador_contratos+1;
            datosTabla(query, pk_unidos,'CnctFecReg',CnctFecReg,'2-Contrato',contador_contratos).then(datostabla => {
            })
        }
        if(propiedad==="Estado_CnctFecReg") {
            Estado_CnctFecReg=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_CnctFecReg',Estado_CnctFecReg,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="tconcod") {
            tconcod=json[propiedad]; 
            datosTabla(query, pk_unidos,'tconcod',tconcod,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="Estado_tconcod") {
            Estado_tconcod=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_tconcod',Estado_tconcod,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="cnctclscnt") {
            cnctclscnt=json[propiedad]; 
            datosTabla(query, pk_unidos,'cnctclscnt',cnctclscnt,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="Estado_cnctclscnt") {
            Estado_cnctclscnt=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_cnctclscnt',Estado_cnctclscnt,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="cnctno") {
            cnctno=json[propiedad]; 
            datosTabla(query, pk_unidos,'cnctno',cnctno,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="Estado_cnctno") {
            Estado_cnctno=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_cnctno',Estado_cnctno,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="emplconcon") {
            emplconcon=json[propiedad]; 
            datosTabla(query, pk_unidos,'emplconcon',emplconcon,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="Estado_emplconcon") { 
            Estado_emplconcon=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_emplconcon',Estado_emplconcon,'2-Contrato',contador_contratos).then(datostabla => {})
        }
        //----------------------
        //--Salarios
        //----------------------
        if(propiedad==="EmplValSue") {
            EmplValSue=json[propiedad]; 
            contador_salarios=contador_salarios+1;
            datosTabla(query, pk_unidos,'EmplValSue',EmplValSue,'3-Salarios',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="Estado_EmplValSue") {
            Estado_EmplValSue=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_EmplValSue',Estado_EmplValSue,'3-Salarios',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="cnctfeccds") {
            cnctfeccds=json[propiedad]; 
            datosTabla(query, pk_unidos,'cnctfeccds',cnctfeccds,'3-Salarios',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="Estado_cnctfeccds") {
            Estado_cnctfeccds=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_cnctfeccds',Estado_cnctfeccds,'3-Salarios',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="END_DATE") {
            END_DATE=json[propiedad]; 
            datosTabla(query, pk_unidos,'END_DATE',END_DATE,'3-Salarios',contador_contratos).then(datostabla => {})
        }
        if(propiedad==="Estado_END_DATE") {
            Estado_END_DATE=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_END_DATE',Estado_END_DATE,'3-Salarios',contador_contratos).then(datostabla => {})
        }
        //----------------------
        //--Bonos
        //----------------------
        if(propiedad==="rhcnct1_bonocod") {
            rhcnct1_bonocod=json[propiedad]; console.log(rhcnct1_bonocod);
            contador_bonus=contador_bonus+1;
            datosTabla(query, pk_unidos,'rhcnct1_bonocod',rhcnct1_bonocod,'4-Bonos',contador_bonus).then(datostabla => {})
        }
        if(propiedad==="Estado_rhcnct1_bonocod") {
            Estado_rhcnct1_bonocod=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhcnct1_bonocod',Estado_rhcnct1_bonocod,'4-Bonos',contador_bonus).then(datostabla => {})
        }
        if(propiedad==="rhcnct1_cnctvbnwd") {
            rhcnct1_cnctvbnwd=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhcnct1_cnctvbnwd',rhcnct1_cnctvbnwd,'4-Bonos',contador_bonus).then(datostabla => {})
        }
        if(propiedad==="Estado_rhcnct1_cnctvbnwd") {
            Estado_rhcnct1_cnctvbnwd=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhcnct1_cnctvbnwd',Estado_rhcnct1_cnctvbnwd,'4-Bonos',contador_bonus).then(datostabla => {})
        }
        //----------------------
        //--Base-Root
        //----------------------
        if(propiedad==="CnctCodSta") {
            CnctCodSta=json[propiedad]; 
            datosTabla(query, pk_unidos,'CnctCodSta',CnctCodSta,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="emplfecant") {
            emplfecant=json[propiedad]; 
            datosTabla(query, pk_unidos,'emplfecant',emplfecant,'1-Principal',0).then(datostabla => {})
        }
        //----------------------
        //--Posiciones
        //----------------------
        if(propiedad==="job_cod") {
            job_cod=json[propiedad]; 
            contador_posiciones =   contador_posiciones+1;
            datosTabla(query, pk_unidos,'job_cod',job_cod,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="Estado_job_cod") {
            Estado_job_cod=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_job_cod',Estado_job_cod,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="PRIMARY_JOB") {
            PRIMARY_JOB=json[propiedad]; 
            datosTabla(query, pk_unidos,'PRIMARY_JOB',PRIMARY_JOB,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="Estado_PRIMARY_JOB") {
            Estado_PRIMARY_JOB=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_PRIMARY_JOB',Estado_PRIMARY_JOB,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="org_id") {
            org_id=json[propiedad]; 
            datosTabla(query, pk_unidos,'org_id',org_id,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="Estado_org_id") {
            Estado_org_id=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_org_id',Estado_org_id,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="Organization_Type") {
            Organization_Type=json[propiedad]; 
            datosTabla(query, pk_unidos,'Organization_Type',Organization_Type,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="Estado_Organization_Type") {
            Estado_Organization_Type=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_Organization_Type',Estado_Organization_Type,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="rhcnct_cnctfinent") {
            rhcnct_cnctfinent=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhcnct_cnctfinent',rhcnct_cnctfinent,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="Estado_rhcnct_cnctfinent") {
            Estado_rhcnct_cnctfinent=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhcnct_cnctfinent',Estado_rhcnct_cnctfinent,'5-Posiciones',contador_posiciones).then(datostabla => {})
        }
        //----------------------
        //--Base-Root
        //----------------------
        if(propiedad==="emplfecing") {
            emplfecing=json[propiedad]; 
            datosTabla(query, pk_unidos,'emplfecing',emplfecing,'1-Principal',0).then(datostabla => {})
        }
        //----------------------
        //--Direcciones
        //----------------------
        if(propiedad==="empldir") {
            empldir=json[propiedad]; 
            contador_direcciones=contador_direcciones+1;
            datosTabla(query, pk_unidos,'empldir',empldir,'6-Direcciones',contador_posiciones).then(datostabla => {})
        }
        if(propiedad==="Estado_empldir") {
            Estado_empldir=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_empldir',Estado_empldir,'6-Direcciones',contador_posiciones).then(datostabla => {})
        }
        //----------------------
        //--Nombres
        //----------------------
        if(propiedad==="emplnompri") {
            emplnompri=json[propiedad]; 
            contador_nombres=contador_nombres+1;
            datosTabla(query, pk_unidos,'emplnompri',emplnompri,'7-Nombres',contador_nombres).then(datostabla => {})
        }
        if(propiedad==="Estado_emplnompri") {
            Estado_emplnompri=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_emplnompri',Estado_emplnompri,'7-Nombres',contador_nombres).then(datostabla => {})
        }
        if(propiedad==="emplnomseg") {
            emplnomseg=json[propiedad]; 
            datosTabla(query, pk_unidos,'emplnomseg',emplnomseg,'7-Nombres',contador_nombres).then(datostabla => {})
        }
        if(propiedad==="Estado_emplnomseg") {
            Estado_emplnomseg=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_emplnomseg',Estado_emplnomseg,'7-Nombres',contador_nombres).then(datostabla => {})
        }
        if(propiedad==="emplapepat") {
            emplapepat=json[propiedad]; 
            datosTabla(query, pk_unidos,'emplapepat',emplapepat,'7-Nombres',contador_nombres).then(datostabla => {})
        }
        if(propiedad==="Estado_emplapepat") {
            Estado_emplapepat=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_emplapepat',Estado_emplapepat,'7-Nombres',contador_nombres).then(datostabla => {})
        }
        if(propiedad==="emplapemat") {
            emplapemat=json[propiedad]; 
            datosTabla(query, pk_unidos,'emplapemat',emplapemat,'7-Nombres',contador_nombres).then(datostabla => {})
        }
        if(propiedad==="Estado_emplapemat") {
            Estado_emplapemat=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_emplapemat',Estado_emplapemat,'7-Nombres',contador_nombres).then(datostabla => {})
        }
        //----------------------
        //--Base-Root
        //----------------------
        if(propiedad==="emplfecnac") {
            emplfecnac=json[propiedad]; 
            datosTabla(query, pk_unidos,'emplfecnac',emplfecnac,'1-Principal',0).then(datostabla => {})
        }
        //----------------------
        //--Documentos
        //----------------------
        if(propiedad==="EmplNumCed") {
            EmplNumCed=json[propiedad]; 
            contador_documentos=contador_documentos+1;
            datosTabla(query, pk_unidos,'EmplNumCed',EmplNumCed,'8-Documentos',contador_documentos).then(datostabla => {})
        }
        if(propiedad==="Estado_EmplNumCed") {
            Estado_EmplNumCed=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_EmplNumCed',Estado_EmplNumCed,'8-Documentos',contador_documentos).then(datostabla => {})
        }
        if(propiedad==="emplTipLic") {
            emplTipLic=json[propiedad]; console.log(emplTipLic);
            datosTabla(query, pk_unidos,'emplTipLic',emplTipLic,'8-Documentos',contador_documentos).then(datostabla => {})
        }
        if(propiedad==="Estado_emplTipLic") {
            Estado_emplTipLic=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_emplTipLic',Estado_emplTipLic,'8-Documentos',contador_documentos).then(datostabla => {})
        }
        //----------------------
        //--Base-Root
        //----------------------
        if(propiedad==="mobjcod") {
            mobjcod=json[propiedad]; 
            datosTabla(query, pk_unidos,'mobjcod',mobjcod,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="CnctFecLiq") {
            CnctFecLiq=json[propiedad]; 
            datosTabla(query, pk_unidos,'CnctFecLiq',CnctFecLiq,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="Emplfecifp") {
            Emplfecifp=json[propiedad]; 
            datosTabla(query, pk_unidos,'Emplfecifp',Emplfecifp,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="rhcnct_grpgcod") {
            rhcnct_grpgcod=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhcnct_grpgcod',rhcnct_grpgcod,'1-Principal',0).then(datostabla => {})
        }
        //----------------------
        //--Pagos Unico de Comensaciones
        //----------------------
        if(propiedad==="rhCnct7_onetcodwd") {
            rhCnct7_onetcodwd=json[propiedad]; 
            contador_pagos=contador_pagos+1;
            datosTabla(query, pk_unidos,'rhCnct7_onetcodwd',rhCnct7_onetcodwd,'9-Pagos',contador_pagos).then(datostabla => {})
        }
        if(propiedad==="Estado_rhCnct7_onetcodwd") {
            Estado_rhCnct7_onetcodwd=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhCnct7_onetcodwd',Estado_rhCnct7_onetcodwd,'9-Pagos',contador_pagos).then(datostabla => {})
        }
        if(propiedad==="rhCnct7_onetdol") {
            rhCnct7_onetdol=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhCnct7_onetdol',rhCnct7_onetdol,'9-Pagos',contador_pagos).then(datostabla => {})
        }
        if(propiedad==="Estado_rhCnct7_onetdol") {
            Estado_rhCnct7_onetdol=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhCnct7_onetdol',Estado_rhCnct7_onetdol,'9-Pagos',contador_pagos).then(datostabla => {})
        }
        //----------------------
        //--Elecciones Pago
        //----------------------
        if(propiedad==="rhcnct_tctacod") {
            rhcnct_tctacod=json[propiedad]; 
            contador_elecciones=contador_elecciones+1;
            datosTabla(query, pk_unidos,'rhcnct_tctacod',rhcnct_tctacod,'10-Elecciones',contador_elecciones).then(datostabla => {})
        }
        if(propiedad==="Estado_rhcnct_tctacod") {
            Estado_rhcnct_tctacod=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhcnct_tctacod',Estado_rhcnct_tctacod,'10-Elecciones',contador_elecciones).then(datostabla => {})
        }
        if(propiedad==="rhcnct_TpagCod") {
            rhcnct_TpagCod=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhcnct_TpagCod',rhcnct_TpagCod,'10-Elecciones',contador_elecciones).then(datostabla => {})
        }
        if(propiedad==="Estado_rhcnct_TpagCod") {
            Estado_rhcnct_TpagCod=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhcnct_TpagCod',Estado_rhcnct_TpagCod,'10-Elecciones',contador_elecciones).then(datostabla => {})
        }
        if(propiedad==="rhcnct_banccod") {
            rhcnct_banccod=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhcnct_banccod',rhcnct_banccod,'10-Elecciones',contador_elecciones).then(datostabla => {})
        }
        if(propiedad==="Estado_banccod") {
            Estado_banccod=json[propiedad]; console.log(Estado_banccod);
            datosTabla(query, pk_unidos,'rhcnct_banccod',rhcnct_banccod,'10-Elecciones',contador_elecciones).then(datostabla => {})
        }
        if(propiedad==="rhcnct_EmplNumCta") {
            rhcnct_EmplNumCta=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhcnct_EmplNumCta',rhcnct_EmplNumCta,'10-Elecciones',contador_elecciones).then(datostabla => {})
        }
        if(propiedad==="Estado_rhcnct_EmplNumCta") {
            Estado_rhcnct_EmplNumCta=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhcnct_EmplNumCta',Estado_rhcnct_EmplNumCta,'10-Elecciones',contador_elecciones).then(datostabla => {})
        }
        //----------------------
        //--Base-Root
        //----------------------
        if(propiedad==="rhempl_EmplDesNac") {
            rhempl_EmplDesNac=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhempl_EmplDesNac',rhempl_EmplDesNac,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="rhempl_ecivcod") {
            rhempl_ecivcod=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhempl_ecivcod',rhempl_ecivcod,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="rhempl_sexocod") {
            rhempl_sexocod=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhempl_sexocod',rhempl_sexocod,'1-Principal',0).then(datostabla => {})
        }
        //----------------------
        //--Discapacidad
        //----------------------
        if(propiedad==="rhempl_emplcnsxds") {
            rhempl_emplcnsxds=json[propiedad]; 
            contador_discapacidad   =   contador_discapacidad+1;
            datosTabla(query, pk_unidos,'rhempl_emplcnsxds',rhempl_emplcnsxds,'11-Discapacidad',contador_discapacidad).then(datostabla => {})
        }
        if(propiedad==="Estado_rhempl_emplcnsxds") {
            Estado_rhempl_emplcnsxds=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhempl_emplcnsxds',Estado_rhempl_emplcnsxds,'11-Discapacidad',contador_discapacidad).then(datostabla => {})
        }
        if(propiedad==="rhempl_emplgrdmrl") {
            rhempl_emplgrdmrl=json[propiedad]; 
            datosTabla(query, pk_unidos,'rhempl_emplgrdmrl',rhempl_emplgrdmrl,'11-Discapacidad',contador_discapacidad).then(datostabla => {})
        }
        if(propiedad==="Estado_rhempl_emplgrdmrl") {
            Estado_rhempl_emplgrdmrl=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_rhempl_emplgrdmrl',Estado_rhempl_emplgrdmrl,'11-Discapacidad',contador_discapacidad).then(datostabla => {})
        }
        //----------------------
        //--Excedencias
        //----------------------
        if(propiedad==="PermFini") {
            PermFini=json[propiedad]; 
            contador_excedencias=contador_excedencias+1;
            datosTabla(query, pk_unidos,'PermFini',PermFini,'12-Excedencias',contador_excedencias).then(datostabla => {})

        }

        if(propiedad==="Estado_PermFini") {
            Estado_PermFini=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_PermFini',Estado_PermFini,'12-Excedencias',contador_excedencias).then(datostabla => {})
        }
        if(propiedad==="PermFfin") {
            PermFfin=json[propiedad]; 
            datosTabla(query, pk_unidos,'PermFfin',PermFfin,'12-Excedencias',contador_excedencias).then(datostabla => {})
        }
        if(propiedad==="Estado_PermFfin") {
            Estado_PermFfin=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_PermFfin',Estado_PermFfin,'12-Excedencias',contador_excedencias).then(datostabla => {})
        }
        if(propiedad==="PermSta01") {
            PermSta01=json[propiedad]; 
            datosTabla(query, pk_unidos,'PermSta01',PermSta01,'12-Excedencias',contador_excedencias).then(datostabla => {})
        }
        if(propiedad==="Estado_PermSta01") {
            Estado_PermSta01=json[propiedad]; 
            datosTabla(query, pk_unidos,'Estado_PermSta01',Estado_PermSta01,'12-Excedencias',contador_excedencias).then(datostabla => {})
        }
        //----------------------
        //--Base-Root
        //----------------------
        if(propiedad==="MuleSoft_Id") {
            MuleSoft_Id=json[propiedad]; 
            datosTabla(query, pk_unidos,'MuleSoft_Id',MuleSoft_Id,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="Fecha_WD") {
            Fecha_WD=json[propiedad]; 
            datosTabla(query, pk_unidos,'Fecha_WD',Fecha_WD,'1-Principal',0).then(datostabla => {})
        }
        if(propiedad==="ES_ASIGNACION_INTERNACIONAL") {
            ES_ASIGNACION_INTERNACIONAL=json[propiedad]; 
            datosTabla(query, pk_unidos,'ES_ASIGNACION_INTERNACIONAL',ES_ASIGNACION_INTERNACIONAL,'1-Principal',0).then(datostabla => {})
        }
        

        //----------------------
        //--Time Offs
        //----------------------    
        if(propiedad==="ID_TIME_OFF") {
            ID_TIME_OFF=json[propiedad]; 
            contador_timeoffs=contador_timeoffs+1;
            datosTabla(query, pk_unidos,'ID_TIME_OFF',ID_TIME_OFF,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="ESTADO_ID_TIME_OFF") {
            ESTADO_ID_TIME_OFF=json[propiedad]; 
            datosTabla(query, pk_unidos,'ESTADO_ID_TIME_OFF',ESTADO_ID_TIME_OFF,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="NOMBRE_TIME_OFF") {
            NOMBRE_TIME_OFF=json[propiedad]; 
            datosTabla(query, pk_unidos,'NOMBRE_TIME_OFF',NOMBRE_TIME_OFF,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="ESTADO_NOMBRE_TIME_OFF") {
            ESTADO_NOMBRE_TIME_OFF=json[propiedad]; 
            datosTabla(query, pk_unidos,'ESTADO_NOMBRE_TIME_OFF',ESTADO_NOMBRE_TIME_OFF,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="TIPO_TIME_OFF") {
            TIPO_TIME_OFF=json[propiedad]; 
            datosTabla(query, pk_unidos,'TIPO_TIME_OFF',TIPO_TIME_OFF,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="ESTADO_TIPO_TIME_OFF") {
            ESTADO_TIPO_TIME_OFF=json[propiedad]; 
            datosTabla(query, pk_unidos,'ESTADO_TIPO_TIME_OFF',ESTADO_TIPO_TIME_OFF,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="UNIDAD_DE_MEDIDA") {
            UNIDAD_DE_MEDIDA=json[propiedad]; 
            datosTabla(query, pk_unidos,'UNIDAD_DE_MEDIDA',UNIDAD_DE_MEDIDA,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="ESTADO_UNIDAD_DE_MEDIDA") {
            ESTADO_UNIDAD_DE_MEDIDA=json[propiedad]; 
            datosTabla(query, pk_unidos,'ESTADO_UNIDAD_DE_MEDIDA',ESTADO_UNIDAD_DE_MEDIDA,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="FECHA_EFECTIVA") {
            FECHA_EFECTIVA=json[propiedad]; 
            datosTabla(query, pk_unidos,'FECHA_EFECTIVA',FECHA_EFECTIVA,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        //----------------------
        //--Time Offs Entries
        //----------------------
        if(propiedad==="CANTIDAD") {
            CANTIDAD=json[propiedad]; 
            datosTabla(query, pk_unidos,'CANTIDAD',CANTIDAD,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="ESTADO_CANTIDAD") {
            ESTADO_CANTIDAD=json[propiedad]; 
            datosTabla(query, pk_unidos,'ESTADO_CANTIDAD',ESTADO_CANTIDAD,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="INICIO") {
            INICIO=json[propiedad]; 
            datosTabla(query, pk_unidos,'INICIO',INICIO,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="ESTADO_INICIO") {
            ESTADO_INICIO=json[propiedad]; 
            datosTabla(query, pk_unidos,'ESTADO_INICIO',ESTADO_INICIO,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="FIN") {
            FIN=json[propiedad]; 
            datosTabla(query, pk_unidos,'FIN',FIN,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        if(propiedad==="ESTADO_FIN") {
            ESTADO_FIN=json[propiedad]; 
            datosTabla(query, pk_unidos,'ESTADO_FIN',ESTADO_FIN,'13-TimeOffs',contador_timeoffs).then(datostabla => {})
        }
        

        //----------------------
        //--nvocar funcion para los childs del json
        //----------------------
        if(typeof(json[propiedad]) != "string") {
            /* console.log(datosmap); */
            fnLeerJson (json[propiedad])
        }
    }
}
/*Conexion a Sp que devuelve los datos de los clientes*/
let datosTabla = async(query, RegWdIdentificador,RegWdNombreCampo,RegWdValorCampo,RegWdNombDetalle,RegWdAgrDet) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('RegWdIdentificador', sql.Char, RegWdIdentificador)
            .input('RegWdNombreCampo', sql.Char, RegWdNombreCampo)
            .input('RegWdValorCampo', sql.Char, RegWdValorCampo)
            .input('RegWdNombDetalle', sql.Char, RegWdNombDetalle)
            .input('RegWdAgrDet', sql.Char, RegWdAgrDet)
            .execute(query);
        /* console.log(clientes); */
        return clientes.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}

/*Conexion a Sp que devuelve los datos de los clientes*/
let datosCliente = async(query, pJson,head) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('pJson', sql.Char, pJson)
            .input('headers', sql.Char, head)
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