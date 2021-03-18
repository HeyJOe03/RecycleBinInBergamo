using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RaccoltaDifferenziata
{
    public partial class Utente : Form
    {
        public Utente()
        {
            InitializeComponent();
            Program.selectedForm = "";
        }

        private const string urlRegistra = "http://localhost:3000/registraUtente";
        private const string urlAccedi =   "http://localhost:3000/getCF";

        private async void BTN_registrazione_Click(object sender, EventArgs e)
        {
            //Rcognome.Text = "Kumar";
            //Rnome.Text = "Uday";
            //Rcodicefiscale.Text = "UDYKMR1203A437L";
            //Rindirizzo.Text = "Via Zanica 12";


            if (Rcodicefiscale.Text != "" && Rnome.Text != "" && Rcognome.Text != "" && Rindirizzo.Text != "")
            {

                Program.utente["CF"] = Rcodicefiscale.Text;
                Program.utente["nome"] = Rnome.Text;
                Program.utente["cognome"] = Rcognome.Text;
                Program.utente["indirizzo"] = Rindirizzo.Text;
                Famigliari m = new Famigliari();
                m.ShowDialog();

                using (var client = new HttpClient())
                {
                    string jsonRequest = Program.DictionaryToString(Program.utente);
                    //label1.Text = jsonRequest;
                    var response = await client.PostAsync(
                        urlRegistra,
                         new StringContent(jsonRequest, Encoding.UTF8, "application/json")
                         );
                    string result = response.Content.ReadAsStringAsync().Result;
                    if (result == "{\"Message\":\"Query successfull\"}")
                    {
                        label1.Text = "Registrazione effettuata con successo: accedere";
                        Rcognome.Text = "";
                        Rnome.Text = "";
                        Rcodicefiscale.Text = "";
                        Rindirizzo.Text = "";
                        Acodicefiscale.Text = Program.utente["CF"];
                    }
                    else label1.Text = "Errore nella registrazione: " + result + ", ricontrolla i campi";
                }
            }

            //this.Close();
        }
        private async void BTN_user_Click(object sender, EventArgs e)
        {
            
            if(Acodicefiscale.Text != "")
            {
                using (var client = new HttpClient())
                {
                    string jsonRequest = "{\"CF\":\"" + Acodicefiscale.Text +"\"}";
                    //label1.Text = jsonRequest;
                    var response = await client.PostAsync(
                         urlAccedi,
                         new StringContent(jsonRequest, Encoding.UTF8, "application/json")
                         );
                    string result = response.Content.ReadAsStringAsync().Result;

                    //altrimenti ritorna tutta la tabella
                    if (result == "{\"Message\" : \"Bad query\"}") { label1.Text = "Il codice fiscale non è registrato"; }
                    //else if (true) label1.Text = result;
                    else
                    {
                        Program.selectedForm = "Home";

                        Program.utente = new Dictionary<string, string>();
                        Program.utente = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);

                        this.Close();
                    }
                }
            }
            //per spostarsi su pagina Home
        }

        //private void Rnome_Click(object sender, EventArgs e)
        //{

        //}

        //private void Rcognome_Click(object sender, EventArgs e)
        //{

        //}

        //private void Rindirizzo_Click(object sender, EventArgs e)
        //{

        //}

        //private void Rcodicefiscale_Click(object sender, EventArgs e)
        //{

        //}

        //private void Acodicefiscale_Click(object sender, EventArgs e)
        //{

        //}


    }
}
