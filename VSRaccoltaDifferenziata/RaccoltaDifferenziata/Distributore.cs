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

namespace RaccoltaDifferenziata
{
    

    public partial class Distributore : Form
    {
        private const string urlPrendiSacchi = "http://localhost:3000/prendiSacchi";

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
                }


            }
            catch(Exception exception)
            {
                label4.Text = "Errore nei campi, inserire numeri di sacchi e riprovare";
            }

            

        }
    }
}
