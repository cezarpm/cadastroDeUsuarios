const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const ProdutoSchema = new Schema({
    id: { type: Number, unique: true },
    name: String,
    description: String,
    price: Number,
});

module.exports = mongoose.model('Produto', ProdutoSchema);