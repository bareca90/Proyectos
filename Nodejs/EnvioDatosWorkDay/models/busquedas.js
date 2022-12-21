const axios = require('axios');
const http = require('https');
const { Z_DEFAULT_COMPRESSION } = require('zlib');

class Busquedas  {
    /* historial = ['Tegucigalpa','Madrid','San Josè']; */
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
    /* async loguearBiolan (correo,clave){
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
    } */
    /*
    =====================================
    ----------------WorkDay--------------
    =====================================
    */
    //-------------------------------------
    //Consumir Api de Mulesoft para Enviar Map
    //-------------------------------------
    async enviarDatosPayRoll (mapacabpayroll,tipocsv){
        const headers =  {
            /* 'Content-Type' : 'application/json', */
            Authorization : 'Basic dGVzdGluZy13ZDpINGNpM25kMCFUM3N0MW5n'
        };
        try{

            // Send a POST request
            const resp = await axios({
                method: 'post',
                //url: `http://pscnv-e-payroll-results-dev.ir-e1.eu1.cloudhub.io/api/${tipocsv}/ECU`,
                url:`https://pscnv-e-payroll-results-dev.ir-e1.eu1.cloudhub.io/api/${tipocsv}/ECU`,
                
                headers:{
                    'Authorization' : 'Basic dGVzdGluZy13ZDpINGNpM25kMCFUM3N0MW5n'
                },
                data: mapacabpayroll
            });
            /* const respuesta = await axios.post('http://pscnv-e-payroll-results-dev.ir-e1.eu1.cloudhub.io/api/payroll/ECU',mapacabpayroll,{headers }); */
            /* const instance = axios.create({
                url : 'http://pscnv-e-payroll-results-dev.ir-e1.eu1.cloudhub.io/api/payroll/ECU',
                headers:{
                    'Authorization': 'Basic dGVzdGluZy13ZDpINGNpM25kMCFUM3N0MW5n'
                },
                data:mapacabpayroll,
            }) */
            //let datos = mapacabpayroll;
            /* const resp = await instance.post(); */
            
            /* console.log(mapacabpayroll); */
            /* return resp.data; */
            return resp.data;
        }catch(error){
            console.log(error);
        }
    }


}

module.exports = Busquedas;