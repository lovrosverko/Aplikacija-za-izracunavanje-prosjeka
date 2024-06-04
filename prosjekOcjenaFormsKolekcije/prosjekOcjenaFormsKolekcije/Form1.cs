using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosjekOcjenaFormsKolekcije
{
    public partial class Form1 : Form
    {
        List<Prosjek> listaOcjena = new List<Prosjek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            // Ovdje ide kod za učitavanje .csv datoteke
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            // TODO: napraviti provjeru podataka
            // try..catch
            // ocjena mora biti od 1 do 5
            // predmet ne smije biti prazan string

            Prosjek prosjek = new Prosjek(cmbPredmeti.Text, 
                Convert.ToInt32(txtOcjena.Text));

            listaOcjena.Add(prosjek);
            txtOcjena.Clear();
            txtOcjena.Focus();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
            foreach (Prosjek prosjek in listaOcjena)
            {
                txtIspis.AppendText(prosjek.NazivPredmeta
                    + "\t" +
                    prosjek.Ocjena + "\r\n");
            }
        }
    }
}
