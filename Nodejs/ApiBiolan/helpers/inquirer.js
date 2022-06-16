const inquirer = require('inquirer');
const { insertarRegBiolan} = require('../data/queries');
const readMapBiolan = async( datos_biolan = [] ) => {
    // Leemos el mapa para iterar y enviar a guardar a la bd los datos de la iteraciòn 
    const datos_limpios = datos_biolan.map( (dato_bio, i) => {
        //const idx = `${i + 1}.`.green;
        //const ingresoDatos = insertarRegBiolan(dato_bio.resultado,dato_bio.bin,dato_bio.lote,dato_bio.orden,dato_bio.guia,dato_bio.sku,dato_bio.secuencia);
        insertarRegBiolan(dato_bio.resultado,dato_bio.bin,dato_bio.lote,dato_bio.orden,dato_bio.guia,dato_bio.sku,dato_bio.secuencia)
        .then( insertados =>{
            console.log(insertados)
        });
        
        
        //console.log(ingresoDatos);
        
        //console.log(`Resultado => ${dato_bio.resultado}  #Bin => ${dato_bio.bin}   #Lote => ${dato_bio.lote}   #Orden => ${dato_bio.orden}     #DatoGuia => ${dato_bio.guia}   #SKU => ${dato_bio.sku}   #Secuencia => ${dato_bio.secuencia}`  )
        //Aqui se envia a guardar en SQL
    });
    //console.log(datos_limpios);
}



module.exports = {
   readMapBiolan
}
