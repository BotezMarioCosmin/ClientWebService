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
            public string Prodottoid { get; set; }
            public string nome { get; set; }
            public string prezzo { get; set; }
            public string categoria { get; set; }
            public string sviluppatore { get; set; }
            public string pubblicatore { get; set; }
        }


        private const string BaseUrl = "http://localhost/wsphp/index.php/prodotti";

        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            pnlPostPut.Hide();
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

                if (response.IsSuccessStatusCode)
                {
                    //deserializ
                    var productList = JsonConvert.DeserializeObject<List<Prodotto>>(responseBody);

                    dataGridView1.DataSource = productList;

                    MessageBox.Show("GET eseguito con successo: " + response.StatusCode);
                }
            }
            else
            {
                response = await client.GetAsync($"{BaseUrl}/{txtRecord.Text}");

                if (response.IsSuccessStatusCode)
                {
                    responseBody = await response.Content.ReadAsStringAsync();

                    //deserializ
                    Prodotto prodotto = JsonConvert.DeserializeObject<Prodotto>(responseBody);

                    var singleProductList = new List<Prodotto> { prodotto };

                    dataGridView1.DataSource = singleProductList;

                    MessageBox.Show($"Prodotto ID: {prodotto.Prodottoid}\nNome: {prodotto.nome}\nPrezzo: {prodotto.prezzo}\nCategoria: {prodotto.categoria}\nSviluppatore: {prodotto.sviluppatore}\nPubblicatore: {prodotto.pubblicatore}");
                }
                else
                {
                    MessageBox.Show("Errore: " + response.StatusCode);
                }
            }
            txtRecord.Clear();
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
            }
            else
            {
                MessageBox.Show("Campi non validi.");
            }
            txtPostNome.Clear();
            txtPostPrezzo.Clear();
            txtPostCategoria.Clear();
            txtPostSviluppatore.Clear();
            txtPostPubblicatore.Clear();
            pnlPostPut.Hide();
            btnGet_Click(sender, e);
        }


        private async void btnPut_Click(object sender, EventArgs e)
        {
            if (txtPostNome.Text != null && txtPostPrezzo.Text != null && txtPostCategoria.Text != null && txtPostSviluppatore.Text != null && txtPostPubblicatore.Text != null)
            {
                int id = Convert.ToInt32(txtId.Text);
                //crea aggetto
                var data = new { Prodottoid = id, nome = txtPostNome.Text, prezzo = txtPostPrezzo.Text, categoria = txtPostCategoria.Text, sviluppatore = txtPostSviluppatore.Text, pubblicatore = txtPostPubblicatore.Text };

                string json = JsonConvert.SerializeObject(data);

                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await client.PutAsync($"{BaseUrl}/put/{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Record aggiornato con successo:" + response.StatusCode);
                }
                else
                {
                    MessageBox.Show("Errore: " + response.StatusCode);
                }
            }
            else
            {
                MessageBox.Show("Campi non validi.");
            }
            txtPostNome.Clear();
            txtPostPrezzo.Clear();
            txtPostCategoria.Clear();
            txtPostSviluppatore.Clear();
            txtPostPubblicatore.Clear();
            pnlPostPut.Hide();
            txtId.Clear();
            btnGet_Click(sender, e);
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteId.Text != "")
            {
                try
                {
                    int id = Convert.ToInt32(txtDeleteId.Text);
                    //verifica esistenza elemento
                    HttpResponseMessage checkResponse = await client.GetAsync($"{BaseUrl}/{id}");

                    if (checkResponse.IsSuccessStatusCode)
                    {
                        //se elemento esiste eliminalo
                        HttpResponseMessage response = await client.DeleteAsync($"{BaseUrl}/del/{id}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Record eliminato con successo:" + response.StatusCode);
                            btnGet_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Errore durante l'eliminazione: " + response.StatusCode);
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'elemento con l'ID specificato non esiste.");
                    }
                }
                catch 
                {
                    MessageBox.Show("L'ID deve essere un numero.");
                }

            }
            else
            {
                MessageBox.Show("Specificare un ID.");
            }
            txtDeleteId.Clear();
        }


        private void btnApriPost_Click(object sender, EventArgs e)
        {
            pnlPostPut.Show();
            btnPost.Show();
            btnPut.Hide();
        }

        private void btnPostIndietro_Click(object sender, EventArgs e)
        {
            pnlPostPut.Hide();
            txtId.Clear();
        }

        private async void btnApriPut_Click(object sender, EventArgs e)
        {
            btnPost.Hide();
            btnPut.Show();

            if (txtId.Text != "" && int.TryParse(txtId.Text, out int id))
            {
                //verifica esistenza
                HttpResponseMessage checkResponse = await client.GetAsync($"{BaseUrl}/{id}");

                if (checkResponse.IsSuccessStatusCode)
                {
                    //info
                    Prodotto prodotto = await GetProdotto(id);

                    
                    if (prodotto != null)
                    {
                        txtPostNome.Text = prodotto.nome;
                        txtPostPrezzo.Text = prodotto.prezzo;
                        txtPostCategoria.Text = prodotto.categoria;
                        txtPostSviluppatore.Text = prodotto.sviluppatore;
                        txtPostPubblicatore.Text = prodotto.pubblicatore;

                        pnlPostPut.Show();
                    }
                    else
                    {
                        MessageBox.Show("Errore nel recupero delle informazioni del prodotto.");
                    }
                }
                else
                {
                    MessageBox.Show("L'elemento con l'ID specificato non esiste.");
                    txtId.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bisogna specificare un ID numerico.");
            }
        }

        private async Task<Prodotto> GetProdotto(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{BaseUrl}/{id}");

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                Prodotto prodotto = JsonConvert.DeserializeObject<Prodotto>(responseBody);
                return prodotto;
            }
            else
            {
                return null;
            }
        }

    }
}
