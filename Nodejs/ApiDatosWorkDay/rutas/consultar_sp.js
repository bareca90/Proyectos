const config = require('../configuraciones/configuracion_base');
/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const app = express();
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
app.post('/datoschanges', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let head   = JSON.stringify(req.headers);

    /* console.log(JSON.stringify(req.headers)); */

    let query = 'SP_Insert_Changes';
    console.log(head);
    //console.log(JSON.stringify(datos));
    datosCliente(query, datos,head).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })
    

})
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