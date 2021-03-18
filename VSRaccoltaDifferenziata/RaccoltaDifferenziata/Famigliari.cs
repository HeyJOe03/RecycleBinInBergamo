using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaccoltaDifferenziata
{
    public partial class Famigliari : Form
    {
        //private Dictionary<string, string> json;
        private int plastica, secco;
        

        public Famigliari()
        {
            InitializeComponent();
            //json = new Dictionary<string, string>();
            //json.Add("CF", CF);
            //json.Add("nome", nome);
            //json.Add("cognome", cognome);
            //json.Add("indirizzo", indirizzo);
            plastica = 60;
            secco = 20;


        }



        private /*async*/ void BTN_famigliari_Click(object sender, EventArgs e)
        {
            if (comboBoxN.Text != "Seleziona il numero di componenti famigliari" && comboBox1.Text != "Seleziona l'età" && comboBox2.Text != "Seleziona l'età" && comboBox3.Text != "Seleziona l'età" && comboBox4.Text != "Seleziona l'età" && comboBox5.Text != "Seleziona l'età")
            {

                //fa avvenire iscrizione

                Program.selectedForm = "Home";
                numsacc();
                this.Close();
            }

        }


        private void numsacc()
        {
            int fam = Int32.Parse(comboBoxN.Text);
            int min3 = 0;
            if (comboBox1.Text == "Età<4 ")
            {
                min3++;
            }
            else if (comboBox2.Text == "Età<4 ")
            {
                min3++;
            }
            else if (comboBox3.Text == "Età<4 ")
            {
                min3++;
            }
            else if (comboBox4.Text == "Età<4 ")
            {
                min3++;
            }
            else if (comboBox5.Text == "Età<4 ")
            {
                min3++;
            }
            plastica = plastica * fam;
            fam = fam - min3;
            secco = secco * fam + 10 * min3;

            ciromario.Text = "secco: " + secco + " plastica: " + plastica;

            Program.utente["MAXplastica"] = plastica.ToString();
            Program.utente["MAXsecco"] = secco.ToString();
        }

        private void comboBoxN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxN.Text == "1")
            {
                comboBox1.Visible = true;
            }
            else if (comboBoxN.Text == "2")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
            }
            else if (comboBoxN.Text == "3")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
            }
            else if (comboBoxN.Text == "4")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
            }
            else if (comboBoxN.Text == "5")
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
            }
        }
    }
}
