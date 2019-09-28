const mongoose = require('mongoose');

const  CreateConnection = async () => {
    try {
        await mongoose.connect(process.env.CONNSTRING, {
            useNewUrlParser: true,
            useUnifiedTopology: true,
            useCreateIndex: true,
            useFindAndModify: false
        });

    } catch (error) {
        console.log('Não foi possivel conectar ao mongodb');

    }

}

module.exports = CreateConnection;