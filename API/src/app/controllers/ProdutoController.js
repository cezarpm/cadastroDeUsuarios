const ProdutosSchema = require('../models/ProdutoSchema');

module.exports = {  
     store(req, res) {
        const { id, name, descricao, preco } = req.body;

        if (!id || !descricao || !name || !preco) {
            return res.status(400).json({ err: "Todos campos são obrigatorios" })
        }

        const produto = new ProdutosSchema({
            id,
            name,
            descricao,
            preco,
        });

        produto.save(function (err) {

            if (err) return res.status(500).json(err);

            return res.status(201).json(produto);
        })

    },

     index(req, res) {

        ProdutosSchema.find({}, (err, users) => {

            if (err) {
                return res.status(500).json(err);
            }

            res.status(200).json(users);
        });
    },

     update(req, res) {
        const { id, name, descricao, preco } = req.body;

        ProdutosSchema.findOne({ id: id }, (err, produto) => {
            produto.id = id;
            produto.name = name;
            produto.descricao = descricao;
            produto.preco = preco;

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
