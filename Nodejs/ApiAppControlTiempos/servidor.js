let express = require('express');
let app = express();
const sql = require('mssql/msnodesqlv8');
let config = require('./configuraciones/configuracion_base');
const path = require('path');
const bodyParser = require('body-parser');
// parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: false }))
// parse application/json
//swagger
const swaggerUI = require('swagger-ui-express');
const swaggerJsDoc = require('swagger-jsdoc');
const swaggerSpec = {
    definition : {
        openapi : "3.0.0",
        info : {
            title : "Work Day API Integration ",
            description:"Permitira Recibir los Datos enviados por Mulesoft, esto se lo realizarà mediante Post & Get en base a cada una de las necesidades ",
            version : "1.0.0"
        },
        servers: [
            {
                url : "http://10.20.4.38:8077"
            }
        ]
    },
    apis:[`${path.join(__dirname,"./rutas/*.js")}`]
}
//Middleware
app.use(bodyParser.json());
app.use("/api-app-control-time",require('./rutas/consultar_sp'));
app.use("/api-app-control-time-doc",swaggerUI.serve,swaggerUI.setup(swaggerJsDoc(swaggerSpec)));



sql.connect(config).then(pool => {

}).then(result => {
    console.log('Se conecto a la Base Correctamente');
}).catch(err => {
    console.log(err);

});

let port = process.env.PORT || 8077;
app.listen(port);
console.log('Aplicacion Corriendo en el Puerto ' + port);