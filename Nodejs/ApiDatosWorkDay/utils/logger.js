const {createLogger,format,transports} = require('winston');

module.exports= createLogger({
    format: format.combine(
        format.simple(),
        format.timestamp(),
        format.printf(info => `[${info.timestamp}] ${info.level} ${info.message}`)
    ),
    transports:[
        new transports.File({
            maxsize: 2052000,
            maxFiles: 10,
            filename: `${__dirname}/../Logs/log-apiwd.log`
        }),  
        new transports.Console({
            level:'debug'

        })
    ]
})