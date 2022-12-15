let express = require('express');
let app = express();
const sql = require('mssql/msnodesqlv8');
let config = require('./configuraciones/configuracion_base');

const bodyParser = require('body-parser');
// parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: false }))
    // parse application/json
app.use(bodyParser.json());
app.use(require('./rutas/consultar_sp'));



sql.connect(config).then(pool => {

}).then(result => {
    console.log('Se conecto a la Base Sipedes Correctamente ');
}).catch(err => {
    console.log(err);

});


let port = process.env.PORT || 8086;
app.listen(port);
console.log('Aplicacion Corriendo en el Puerto ' + port);