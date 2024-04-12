using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ClientWebService
{
    public partial class Form1 : Form
    {
        private const string BaseUrl = "http://localhost/phpmyadmin";

        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync(BaseUrl + "resource");
            string responseBody = await response.Content.ReadAsStringAsync();

            // Gestione del codice di risposta
            if (response.IsSuccessStatusCode)
            {
                // Conversione da JSON a oggetto
                var data = JsonConvert.DeserializeObject(responseBody);
                // Rappresentazione grafica dei dati
                // Esempio: dataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("Errore: " + response.StatusCode);
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var data = new { a = Int32.Parse(txtA.Text), b = Int32.Parse(txtB.Text) };
            string json = JsonConvert.SerializeObject(data);

            var content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await client.PostAsync(BaseUrl + "resource", content);

            // Gestione del codice di risposta
            if (response.IsSuccessStatusCode)
            {
                // Esegue operazioni se necessario
            }
            else
            {
                MessageBox.Show("Errore: " + response.StatusCode);
            }
        }
    }
}
