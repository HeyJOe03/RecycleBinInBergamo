using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// FIXME: se si preme il bottone registra ma si ha compilato il campo accedi il form di chiude
namespace RaccoltaDifferenziata
{
    public partial class Home : Form
    {
        private const string target = "https://www.apricaspa.it/progetti/mi-piace-un-sacco";

        public Home()
        {
            InitializeComponent();
            Program.selectedForm = "";
        }

        private void LINK(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(target);
        }

        private void BTN_NewForm(object sender, EventArgs e)
        {
            Program.distr = 1;
            Program.selectedForm = "Distributore";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.selectedForm = "Utente";
            this.Close();
        }

        private void Bidone_4_Click(object sender, EventArgs e)
        {
            Program.distr = 4;
            Program.selectedForm = "Distributore";
            this.Close();
        }

        private void Bidone_3_Click(object sender, EventArgs e)
        {
            Program.distr = 3;
            Program.selectedForm = "Distributore";
            this.Close();
        }

        private void Bidone_2_Click(object sender, EventArgs e)
        {
            Program.distr = 2;
            Program.selectedForm = "Distributore";
            this.Close();
        }

        private void Bidone_5_Click(object sender, EventArgs e)
        {
            Program.distr = 5;
            Program.selectedForm = "Distributore";
            this.Close();
        }
    }
}
