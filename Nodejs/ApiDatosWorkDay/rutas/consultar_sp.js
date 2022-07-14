const config = require('../configuraciones/configuracion_base');
/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const app = express();


/*Conexion a Sp que devuelve los datos de los clientes*/
/* let datosEmpleados = async(query, situacion,IDEmpleadoWorkday,emplnompri,emplnomseg,emplapepat,emplapemat,emplcod,CnctFecReg,rhcgcod,emplfecing,seccCod,emplcodcco,fpagcod,emplvalsue,emplstasob,emplmdcsob,EmplStaBen,tconcod,TconAniVig,TpagCod,tctacod,banccod,EmplNumCta,EmplPerPag,TnomCod,CnctCodSta,Cnctusrlog,Cnctfeclog,Cncthralog,Emplfecifp,cnctentsn,cnctfinent,cnctinient,emplfecant,Emplsubirt,Emplsubies,Emplbonvac,cnctpagfdr,cnctidnsuc,cnctmodpgo,secccodori,cnctpagapt,cnctpagd14,cnctpagd13,cnctpersnd,cnctclscnt,cncttltrsn,hirefeclog,hireusrlog) => {
    try {
        let pool = await sql.connect(config);
        let clientes = await pool.request()
            .input('situacion', sql.Char, situacion)
            .input('IDEmpleadoWorkday', sql.Char, IDEmpleadoWorkday)
            .input('emplnompri', sql.Char, emplnompri)
            .input('emplnomseg', sql.Char, emplnomseg)
            .input('emplapepat', sql.Char, emplapepat)
            .input('emplapemat', sql.Char, emplapemat)
            .input('emplcod', sql.Char, emplcod)
            .input('CnctFecReg', sql.Date, CnctFecReg)
            .input('rhcgcod', sql.Char, rhcgcod)
            .input('emplfecing', sql.Date, emplfecing)
            .input('seccCod', sql.Char, seccCod)
            .input('emplcodcco', sql.Char, emplcodcco)
            .input('fpagcod', sql.Char, fpagcod)
            .input('emplvalsue', sql.Money, emplvalsue)
            .input('emplstasob', sql.Char, emplstasob)
            .input('emplmdcsob', sql.Char, emplmdcsob)
            .input('EmplStaBen', sql.Char, EmplStaBen)
            .input('tconcod', sql.Char, tconcod)
            .input('TconAniVig', sql.Int, TconAniVig)
            .input('TpagCod', sql.Char, TpagCod)
            .input('tctacod', sql.Char, tctacod)
            .input('banccod', sql.Char, banccod)
            .input('EmplNumCta', sql.Char, EmplNumCta)
            .input('EmplPerPag', sql.Char, EmplPerPag)
            .input('TnomCod', sql.Char, TnomCod)
            .input('CnctCodSta', sql.Char, CnctCodSta)
            .input('Cnctusrlog', sql.Char, Cnctusrlog)
            .input('Cnctfeclog', sql.Date, Cnctfeclog)
            .input('Cncthralog', sql.Char, Cncthralog)
            .input('Emplfecifp', sql.Date, Emplfecifp)
            .input('cnctentsn', sql.Char, cnctentsn)
            .input('cnctfinent', sql.Date, cnctfinent)
            .input('cnctinient', sql.Date, cnctinient)
            .input('emplfecant', sql.Date, emplfecant)
            .input('Emplsubirt', sql.Char, Emplsubirt)
            .input('Emplsubies', sql.Char, Emplsubies)
            .input('Emplbonvac', sql.Char, Emplbonvac)
            .input('cnctpagfdr', sql.Char, cnctpagfdr)
            .input('cnctidnsuc', sql.Char, cnctidnsuc)
            .input('cnctmodpgo', sql.Char, cnctmodpgo)
            .input('secccodori', sql.Char, secccodori)
            .input('cnctpagapt', sql.Char, cnctpagapt)
            .input('cnctpagd14', sql.Char, cnctpagd14)
            .input('cnctpagd13', sql.Char, cnctpagd13)
            .input('cnctpersnd', sql.Char, cnctpersnd)
            .input('cnctclscnt', sql.Char, cnctclscnt)
            .input('cncttltrsn', sql.Char, cncttltrsn)
            .input('hirefeclog', sql.Date, hirefeclog)
            .input('hireusrlog', sql.Char, hireusrlog)
            .execute(query);
        
        return clientes.recordsets;
        
    } catch (error) {
        console.log(error);
    }
} */
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


/*Ruta para Obtener Datos Cliente */
/* app.get('/datoscliente', function(req, respuesta) {
    let cliente = req.query.cliente ;
    let query = 'Sp_Datos_Cliente';
    datosCliente(query, cliente).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })

}) */
/*Ruta para Post de los empleados que se reciben */
app.post('/dataemployees', function(req, respuesta) {
    let datos = JSON.stringify(req.body);
    let query = 'SP_Insert_Hire';
    //console.log(JSON.stringify(datos));
    datosCliente(query, datos).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })
    /* const usersByLikes = datos.map(item => {
        datosEmpleados( query,item.situation,item.codworkday,item.firstname,item.secondname,item.firstlastname,item.secondlastname,item.employeecode,item.dateregistre,item.rhcgcod,item.emplfecing,item.secccod,
                        item.emplcodcco,item.fpagcod,item.emplvalsue,item.emplstasob,item.emplmdcsob,
                        item.emplstaBen,
                        item.tconcod,
                        item.tconanivig,
                        item.tpagCod,
                        item.tctacod,
                        item.banccod,
                        item.emplNumCta,
                        item.emplPerPag,
                        item.tnomCod,
                        item.cnctcodsta,
                        item.cnctusrlog,
                        item.cnctfeclog,
                        item.cncthralog,
                        item.emplfecifp,
                        item.cnctentsn,
                        item.cnctfinent,
                        item.emplfecant,
                        item.emplsubirt,
                        item.emplsubies,
                        item.emplbonvac,
                        item.cnctpagfdr,
                        item.cnctidnsuc,
                        item.cnctmodpgo,
                        item.secccodori,
                        item.cnctpagapt,
                        item.cnctpagd14,
                        item.cnctpagd13,
                        item.cnctpersnd,
                        item.cnctclscnt,
                        item.cncttltrsn,
                        item.hirefeclog,
                        item.hireusrlog
                        ).then(datosempleados => {
                            respuesta.json(datosempleados[0]);
                        })
    }) */




    //let cliente = req.query.cliente ;
    //let query = 'Sp_Datos_Cliente';
    /* datosCliente(query, cliente).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    }) */

})
module.exports = app;