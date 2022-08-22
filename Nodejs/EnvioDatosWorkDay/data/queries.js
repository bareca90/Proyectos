const config = require('../configuraciones/config');
const sql = require('mssql/msnodesqlv8');


//-------------------------------------
//Insertamos los datos en la bd mediante un sp
//-------------------------------------
const insertarRegBiolan = async(BioValResidual,BioNoBin,BioLote,NroOrden,BioNoGuia,BioCodSKU,BioSecGuia)=> {
    try{
        let query = 'SP_Llenar_Tmp_Biolan';
        let pool = await sql.connect(config);
        let datosBiolan = await pool.request()
            .input('BioNoBin', sql.Char, BioNoBin)
            .input('BioNoGuia', sql.Char, BioNoGuia)
            .input('BioSecGuia', sql.Char, BioSecGuia)
            .input('BioLote', sql.Char, BioLote)
            .input('NroOrden', sql.Char, NroOrden)
            .input('BioCodSKU', sql.Char, BioCodSKU)
            .input('BioValResidual', sql.Money, BioValResidual)
            .execute(query);
            
                

        //console.log(BioValResidual,BioNoBin,BioLote,NroOrden,BioNoGuia,BioCodSKU,BioSecGuia);
        return datosBiolan.recordsets;
        //return 
        //return console.log(`Ingreso Satisfactorio Guia # => ${guia}  Lote # => ${lote}`)
    }catch(error){
        console.log(error);
    }
}
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
    insertarRegBiolan,
    consultarCabecera
}