const ProdutosSchema = require('../models/ProdutoSchema');

module.exports = {
    store(req, res) {
        const { id, name, description, price } = req.body;

        if (!id || !description || !name || !price) {
            return res.status(400).json({ err: "Todos campos são obrigatorios" })
        }

        const produto = new ProdutosSchema({
            id,
            name,
            description,
            price,
        });

        produto.save(function (err) {

            if (err) return res.status(500).json(err);

            return res.status(201).json(produto);
        })

    },

    index(req, res) {

        ProdutosSchema.find({}, { _id: 0, __v: 0 }, (err, users) => {

            if (err) {
                return res.status(500).json(err);
            }

            res.status(200).json(users);
        });
    },

    update(req, res) {
        const { id, name, description, price } = req.body;

        ProdutosSchema.findOne({ id: id }, (err, produto) => {
            produto.id = id;
            produto.name = name;
            produto.description = description;
            produto.price = price;  

            produto.save(function (err) {
                if (err) {
                    return console.error('ERROR!');
                }
                return res.status(202).json(produto);
            });
        });
    },

    delete(req, res) {
        const { id } = req.body;

        ProdutosSchema.findOne({ id: id }, (err, produto) => {

            produto.remove(function (err) {
                if (err) {
                    return console.error('ERROR!');
                }
                return res.status(204).json(produto);
            });
        });
    }
}
