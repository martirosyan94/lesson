using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;
using Shop.Business.Models;

namespace Shop.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationProducts_Click(object sender, EventArgs e)
        {
            var productViewModel = new ProductViewModel()
            {
                Name = "Or",
                Price = 500,
                Quantity = 1000
            };
            var client = new RestClient("https://localhost:44333");

            string jsonString = JsonSerializer.Serialize(productViewModel);

            var request = new RestRequest("Product/Add", DataFormat.Json);
            request.AddJsonBody(jsonString);
            var response = client.Post(request);

        }
    }
}
