const inquirer = require('inquirer');
const { insertarRegBiolan,consultarCabecera} = require('../data/queries');
const fs = require('fs');
const path = require("path");


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
//------------------------------------------
//Obtiene los Datos de la cabecera Payroll y PayLips
//------------------------------------------
const datosCabecera = async(tipo,apertura)=>{
    try{
        const valorcab = await consultarCabecera(tipo,apertura);
        return valorcab[0][0];
    }catch(error){
        console.log(error);
        return error;
    }
}
//------------------------------------------
//Obtiene los Datos de la cabecera Payroll y PayLips
//------------------------------------------
const datosDetallePaLips = async(tipo,apertura)=>{
    try{
        const valordet = await consultarCabecera(tipo,apertura);
        return valordet[0];
    }catch(error){
        console.log(error);
        return error;
    }
}
//------------------------------------------
//Recibe los Datos , los convierte en Mapa y Retorna PayRoll
//------------------------------------------
const mapaCabPayRoll = async(datoscab)=>{
    let filename = datoscab.FileNameCsv;
    let path = datoscab.PathCsv;
    let content = await fileBase64(path);
    
    if (content.length > 0 && filename.length>0 && path.length> 0){
        let datosmap = {
            filename:filename,
            content:content
        }
        return datosmap;
    }else{
        return [];
    }
    
}
//------------------------------------------
//Recibe los Datos de Paylips , los convierte en Mapa y Retorna Paylips
//------------------------------------------
const mapaDetPayLips = async(filenamecsv,pathcsv,datosdet)=>{
    let filenamecsvpl = filenamecsv;
    let content = await fileBase64(pathcsv);
    //let datosdet =[];
    
    const result = datosdet.map(datosdeta => ({ 
        filename: datosdeta.FileNamePdf, 
        content: fs.readFileSync(datosdeta.PathPdf, {encoding: 'base64'})
    }));
    

    /* const map = new Map();
    map.set(NaN, 123);
    map.get(NaN) */
    /* console.log('Datos de Mapa ',result); */

    return {
        csv : {
            filename:filenamecsv,
            content:pathcsv
        },
        payslips:result
    };
}


//------------------------------------------
//Convertir Archivo a Base 64
//------------------------------------------
const fileBase64 = async(path)=>{
    try{
        const contents=fs.readFileSync(path, {encoding: 'base64'});
        return contents;

    }catch(error){
        console.log(error);
        return '';
    }
}


module.exports = {
   readMapBiolan,
   datosCabecera,
   mapaCabPayRoll,
   datosDetallePaLips,
   mapaDetPayLips
}
