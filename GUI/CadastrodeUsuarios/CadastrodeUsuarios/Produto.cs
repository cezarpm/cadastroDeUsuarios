using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeUsuarios
{
    class Produto
    {
        public string id { get; set; }
        public string name { get; set; }
        public string descricao { get; set; }
        public string preco { get; set; }

        public Produto(string id, string name, string description, string price)
        {
            this.id = id;
            this.name = name;
            this.descricao = description;
            this.preco = price;

        }
    }
}
