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


/*Ruta para Obtener Datos Cliente */
app.get('/datoscliente', function(req, respuesta) {
    let cliente = req.query.cliente ;
    let query = 'Sp_Datos_Cliente';
    datosCliente(query, cliente).then(datoscliente => {
        respuesta.json(datoscliente[0]);
    })

})

module.exports = app;