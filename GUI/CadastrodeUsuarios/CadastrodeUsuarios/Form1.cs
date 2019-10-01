using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CadastrodeUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //method POST

        private void Post(Produto p)
        {
            try
            {
                var client = new RestClient(@"http://localhost:3000/produtos");
                var request = new RestRequest(Method.POST);
                string json = JsonConvert.SerializeObject(p);
                request.AddJsonBody(json);
                client.Execute(request);

            }
            catch (Exception e)
            {
                
            }
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(id_box.Text, name_box.Text, desc_box.Text, price_box.Text);
            Post(produto);
        }

    }
}
