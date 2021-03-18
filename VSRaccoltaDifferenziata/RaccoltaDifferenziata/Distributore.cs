using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace RaccoltaDifferenziata
{
    

    public partial class Distributore : Form
    {
        private const string urlPrendiSacchi = "http://localhost:3000/prendiSacchi";
        private const string path = "./Scontrino.txt";
        public Distributore()
        {
            InitializeComponent();
            Program.selectedForm = "";
            //troia.Text = Program.distr;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Program.selectedForm = "Home";
            this.Close();
        }

        private async void BTN_file_Click(object sender, EventArgs e)
        {

            try
            {
                int plastica = Int32.Parse(Text_plastica.Text);
                int secco = Int32.Parse(Text_secco.Text);
                Dictionary<string, string> richiesta = new Dictionary<string, string>();
                richiesta.Add("CF", Program.utente["CF"]);
                richiesta.Add("ID", Program.distr.ToString());
                richiesta.Add("plastica", Text_plastica.Text);
                richiesta.Add("secco", Text_secco.Text);

                string request = Program.DictionaryToString(richiesta);

                using (var client = new HttpClient())
                {

                    var response = await client.PostAsync(
                         urlPrendiSacchi,
                         new StringContent(request, Encoding.UTF8, "application/json")
                    );
                    string result = response.Content.ReadAsStringAsync().Result;

                    label4.Text = result;
                    Program.utente = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                    //if (File.Exists(path))
                    //{
                        using (StreamWriter sw = new StreamWriter(path)) 
                        {
                            sw.WriteLine("---------------------------------------------------");
                            sw.WriteLine("ID cassonetto: " + Program.distr.ToString());
                            sw.WriteLine("Codice Fiscale: " + Program.utente["CF"]);
                            sw.WriteLine("-Nome: " + Program.utente["nome"]);
                            sw.WriteLine("-Cognome: " + Program.utente["cognome"]);
                            sw.WriteLine("-Indirizzo: " + Program.utente["indirizzo"]);
                            sw.WriteLine("-Sacchi plastica ritirati: " + Text_plastica.Text + "/" + Program.utente["MAXplastica"]);
                            sw.WriteLine("-Sacchi secco ritirati: " + Text_secco.Text + "/" + Program.utente["MAXsecco"]);
                            sw.WriteLine("---------------------------------------------------");
                        }
                    //}

                }
            }
            catch (Exception exception)
            {
                label4.Text = "Errore nei campi, inserire numeri di sacchi e riprovare";
            }

            

        }
    }
}
