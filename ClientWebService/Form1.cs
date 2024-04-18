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
        public class Prodotto 
        {
            string Prodottoid;
            string nome;
            string prezzo;
            string categoria;
            string sviluppatore;
            string pubblicatore;
        }

        private const string BaseUrl = "http://localhost/wsphp/index.php/prodotti";

        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            pnlPost.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private async void btnGet_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response;
            string responseBody;

            if (txtRecord.Text == "")
            {
                response = await client.GetAsync(BaseUrl);
                responseBody = await response.Content.ReadAsStringAsync();
            }
            else 
            {
                response = await client.GetAsync((BaseUrl) + "/" + txtRecord.Text);
                responseBody = await response.Content.ReadAsStringAsync();
            }

            //codice risposta
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(responseBody);
                //conversione
                var data = JsonConvert.DeserializeObject(responseBody);
                //visualizza
                dataGridView1.DataSource = data;
                MessageBox.Show("GET eseguito con successo: " + response.StatusCode);
            }
            else
            {
                MessageBox.Show("Errore: " + response.StatusCode);
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            if (txtPostNome.Text != null && txtPostPrezzo.Text != null && txtPostCategoria.Text != null && txtPostSviluppatore.Text != null && txtPostPubblicatore.Text != null )
            {
                //crea aggetto
                var data = new { nome = txtPostNome.Text, prezzo = txtPostPrezzo.Text, categoria = txtPostCategoria.Text, sviluppatore = txtPostSviluppatore.Text, pubblicatore = txtPostPubblicatore.Text };

                
                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                //converti in json
                string json = JsonConvert.SerializeObject(data, settings);

                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                //richiesta post
                HttpResponseMessage response = await client.PostAsync(BaseUrl + "/add", content);

                //risposta
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Record aggiunto con successo:" + response.StatusCode);
                }
                else
                {
                    MessageBox.Show("Errore: " + response.StatusCode);
                }
                pnlPost.Hide();
            }
            else
            {
                MessageBox.Show("Campi non validi.");
            }
            
        }


        private async void btnPut_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var data = new { a = Int32.Parse(txtRecord.Text), b = Int32.Parse(txtPostPrezzo.Text) };
            string json = JsonConvert.SerializeObject(data);

            var content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await client.PutAsync($"{BaseUrl}/put/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                // Esegue operazioni se necessario
            }
            else
            {
                MessageBox.Show("Errore: " + response.StatusCode);
            }
            txtId.Clear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text); // Assumi che l'ID dell'elemento da eliminare sia inserito in un campo di testo chiamato txtId

            HttpResponseMessage response = await client.DeleteAsync($"{BaseUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                // Esegue operazioni se necessario
            }
            else
            {
                MessageBox.Show("Errore: " + response.StatusCode);
            }
        }

        private void btnApriPost_Click(object sender, EventArgs e)
        {
            pnlPost.Show();
            btnPost.Show();
            btnPut.Hide();
        }

        private void btnPostIndietro_Click(object sender, EventArgs e)
        {
            pnlPost.Hide();
        }

        private void btnApriPut_Click(object sender, EventArgs e)
        {
            btnPost.Hide();
            btnPut.Show();
            if (txtId.Text != "" && int.TryParse(txtId.Text, out int id))
            {
                pnlPost.Show();
            }
            else
            {
                MessageBox.Show("Bisogna specificare un id numerico.");
            }
        }
    }
}
