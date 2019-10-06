using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace CadastrodeUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Get();
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //Method GET
        private void Get()
        {
            try
            {
                var client = new RestClient(@"http://localhost:3000/produtos");
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                InsertDataView(response);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method DELETE
        private void Delete(string p)
        {
            try
            {
                var client = new RestClient(@"http://localhost:3000/produtos");
                var request = new RestRequest(Method.DELETE);
                JObject obj = new JObject(
                new JProperty("id", p));
                string json = obj.ToString();
                request.AddJsonBody(json);
                client.Execute(request);
            }
            catch (Exception ex)
            {   
                Console.WriteLine(ex);
            }

        }


        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(id_box.Text, name_box.Text, desc_box.Text, price_box.Text);
            Post(produto);
            Get();

        }

        private void InsertDataView(IRestResponse response)
        {
            var result = JsonConvert.DeserializeObject<List<Produto>>(response.Content);

            tabela_produtos.DataSource = result;

        }

        private void Tabela_produtos_SelectionChanged(object sender, EventArgs e)
        {
            tabela_produtos.ClearSelection();
        }

        private void Remover_btn_Click(object sender, EventArgs e)
        {
            Delete(remove_box.Text);
            Get();
        }
    }
}
