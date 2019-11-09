process.env.NODE_ENV = process.env.NODE_ENV || 'development';
const configureExpress = require('./config/express');
const app = configureExpress();
app.listen(1570);
module.exports = app;