const express = require('express');
const ProdutoController = require('./app/controllers/ProdutoController');

const routes = express.Router();


routes.get('/produtos',ProdutoController.index);
routes.post('/produtos',ProdutoController.store);
routes.put('/produtos', ProdutoController.update);
routes.delete('/produtos', ProdutoController.delete);

module.exports = routes;