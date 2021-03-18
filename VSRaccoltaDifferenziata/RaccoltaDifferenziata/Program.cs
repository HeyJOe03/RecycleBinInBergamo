using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaccoltaDifferenziata
{

    static class Program
    {
        static public string selectedForm = "";
        static public int distr = 0;
        static public Dictionary<string, string> utente = new Dictionary<string, string>();
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Program.utente.Add("CF", "");
            Program.utente.Add("nome", "");
            Program.utente.Add("cognome", "");
            Program.utente.Add("indirizzo", "");
            Program.utente.Add("MAXplastica", "");
            Program.utente.Add("MAXsecco", "");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            selectedForm = "Utente";
            while(selectedForm != "")
            {
                if (selectedForm == "Utente") Application.Run(new Utente());
                else if (selectedForm == "Home") Application.Run(new Home());
                else if (selectedForm == "Distributore") Application.Run(new Distributore());
            }
        }

        static public string DictionaryToString(Dictionary<string, string> dictionary)
        {
            string dictionaryString = "{";
            foreach (KeyValuePair<string, string> keyValues in dictionary)
            {
                dictionaryString += "\"" + keyValues.Key + "\"" + " : " + "\"" + keyValues.Value + "\"" + ", ";
            }
            return dictionaryString.TrimEnd(',', ' ') + "}";
        }

        
    }
}
