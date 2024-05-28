using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class ObezbedjenjeForm : Form
    {
        public ObezbedjenjeForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ProslediObezbedjenje_Click(object sender, EventArgs e)
        {
            long maticniBroj = long.Parse(textBox1.Text);
            string ime = textBox2.Text;
            string prezime = textBox3.Text;
            char pol = char.Parse(comboBox1.Text);
            string borilackaVestina = textBox5.Text;
            DateTime datumRodjenja = datumRodj.Value;
            int redniBrojEkipe = int.Parse(textBox6.Text);

            FizickoObezbedjenje f = new FizickoObezbedjenje();
            f.MaticniBroj = maticniBroj;
            f.Ime = ime;
            f.Prezime = prezime;
            f.Pol = pol;
            f.BorilackaVestina = borilackaVestina;
            f.DatumRodjenja = datumRodjenja;
            f.PripadaEkipi = new Ekipa();
        }
    }
}
