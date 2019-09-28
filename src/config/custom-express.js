require('dotenv').config();
const express = require('express');
const cors = require('cors');
const createconnection = require('../app/db/ConnectionFactory');

const routes = require('../routes');

const app = express();

app.use(cors());
app.use(express.json());
app.use(routes);

createconnection();

module.exports = app;
