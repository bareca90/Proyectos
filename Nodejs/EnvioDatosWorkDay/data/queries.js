const config = require('../configuraciones/config');
const sql = require('mssql/msnodesqlv8');


//-------------------------------------
//Invocamos el Store Procedure para Cabecera
//-------------------------------------
const consultarCabecera = async(tipo,apertura)=> {
    try{
        let query = 'Sp_Datos_Envio_WD';
        let pool = await sql.connect(config);
        let datosCabWD = await pool.request()
            .input('tipo', sql.Char, tipo)
            .input('apertura', sql.Char, apertura)
            .execute(query);
        return datosCabWD.recordsets;
    }catch(error){
        console.log(error);
    }
            
}
module.exports={
    /* insertarRegBiolan, */
    consultarCabecera
}