const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const ProdutoSchema = new Schema({
    id: Number,
    name: String,
    descricao: String,
    preco: Number,
});

module.exports = mongoose.model('Produto', ProdutoSchema);