/* const sql = require('mssql'); */
const express = require('express');
const sql = require('mssql/msnodesqlv8');
const config_rpa = require('../configuraciones/configuracion_base_rpa');
const app = express();

/*Conexion a la bd de rpa para obtener los Bookings que se generan*/
let datosBookings = async(query, fechaini) => {
    try {
        let pool = await sql.connect(config_rpa);
        let bookings = await pool.request()
            //.input('fechainicio', sql.Char, fechaini)
            .execute(query);
        /* console.log(clientes); */
        return bookings.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}

/*Conexion a Sp para actualiar Booking*/
let updateBookings = async(query, idbooking) => {
    try {
        let pool = await sql.connect(config_rpa);
        let bookings = await pool.request()
            .input('idBooking', sql.Int, idbooking)
            .execute(query);
        /* console.log(clientes); */
        return bookings.recordsets;
        /* return clientes; */
    } catch (error) {
        console.log(error);
    }


}

/*Ruta para Obtener Los Bookings para anular */
app.get('/datosbookings', function(req, respuesta) {
    let fechaini    =   req.query.fechaini;
    //let cliente = req.query.cliente ;
    let query = 'GNR_BKN.Sp_Obtener_Bookings';
    datosBookings(query, fechaini).then(datosbookings => {
        respuesta.json(datosbookings[0]);
    })

})

/*Actualizar Registros de el Booiking */
app.post('/updatebookings', function(req, respuesta) {
    let idbooking   =    req.query.idbooking;
    //let cliente = req.query.cliente ;
    let query = 'GNR_BKN.SOLICITAR_ANULACION_BOOKING';
    updateBookings(query, idbooking).then(updatebookings => {
        respuesta.json(updatebookings[0]);
    })

})
module.exports = app;