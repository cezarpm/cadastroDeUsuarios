const app = require('./config/custom-express');

const port = process.env.PORT || 3000;


app.listen(port, () => {
    console.log('Servidor rodando na porta ' + port);
})