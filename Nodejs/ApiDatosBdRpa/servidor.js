let express = require('express');
let app = express();
const sql = require('mssql/msnodesqlv8');
const bodyParser = require('body-parser');
const config_rpa = require('./configuraciones/configuracion_base_rpa');
// parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: false }))
    // parse application/json
app.use(bodyParser.json());
app.use(require('./rutas/consultar_sp'));


sql.connect(config_rpa).then(pool => {

}).then(result => {
    console.log('Se conecto a la Base Rpa Correctamente ');
}).catch(err => {
    console.log(err);

});

let port = process.env.PORT || 8075;
app.listen(port);
console.log('Aplicacion Corriendo en el Puerto ' + port);