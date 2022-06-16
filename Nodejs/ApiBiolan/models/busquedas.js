const axios = require('axios');
const http = require('https');
const { Z_DEFAULT_COMPRESSION } = require('zlib');

class Busquedas  {
    historial = ['Tegucigalpa','Madrid','San Josè'];
    constructor(){
        //TODO: Leer DB sis existe 
    }
    /*
    =====================================
    ----------------Biolan---------------
    =====================================
    */
    //-------------------------------------
    //Obtiene el Token para Loguearse
    //-------------------------------------
    async loguearBiolan (correo,clave){
        try{
            let url = 'https://api-dev.biolanglobal.com/biolan/data/api/api-token/' //Prueba
            //let url = 'https://api.biolanglobal.com/biolan/data/api/api-token/' //Produccion
            let datos = {
                email:correo,
                password:clave
            }
            const resp = await axios.post(url,datos)
            return resp.data.access;
        }catch(error){
            console.log(error)
        }
    }
    //-------------------------------------
    //Obtener los datos del Dia , se lo debe retornar en un mapa
    //-------------------------------------
    async obtenerDatos(token,fecha=''){
        try{
            const instance = axios.create({
                baseURL : 'https://api-dev.biolanglobal.com/biolan/data/api/analysis',
                params: fecha,
                headers:{
                    'Authorization': `Bearer ${token}`
                }
            })
            const resp = await instance.get();
            
            return resp.data.map(datos=>({
                resultado : datos.result,
                bin : datos.extra.bin,
                lote:datos.extra.lote,
                orden:datos.extra.orden,
                guia:datos.extra.noGuia,
                sku:datos.extra.codigoSku,
                secuencia: datos.extra.secuencia

            }));
        }catch(error){
            console.log(error);
        }
    }

}

module.exports = Busquedas;