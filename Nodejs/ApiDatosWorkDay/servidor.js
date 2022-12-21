let express = require('express');
let app = express();
const sql = require('mssql/msnodesqlv8');
const logger = require('./utils/logger')
let config = require('./configuraciones/configuracion_base');
const path = require('path');
const bodyParser = require('body-parser');
// parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: false }));
app.use(express.json({limit: '50mb'}));
// parse application/json
//swagger
const swaggerUI = require('swagger-ui-express');
const swaggerJsDoc = require('swagger-jsdoc');
const { Console } = require('console');
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
                url : "http://10.20.4.38:8075"
            }
        ]
    },
    apis:[`${path.join(__dirname,"./rutas/*.js")}`]
}
//Middleware
app.use(bodyParser.json());
app.use("/apiwd",require('./rutas/consultar_sp'));
app.use("/apiwd-doc",swaggerUI.serve,swaggerUI.setup(swaggerJsDoc(swaggerSpec)));



sql.connect(config).then(pool => {

}).then(result => {
    logger.info('Se conecto a la Base Correctamente');
}).catch(err => {
    logger.info(err);

});

let port = process.env.PORT || 8075;
app.listen(port);
logger.info('Aplicacion Corriendo en el Puerto ' + port);