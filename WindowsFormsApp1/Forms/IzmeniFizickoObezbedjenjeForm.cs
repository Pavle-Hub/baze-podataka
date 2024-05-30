using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Forms
{
    public partial class IzmeniFizickoObezbedjenjeForm : Form
    {
        FizickoObezbedjenjeDTO fo;
        public IzmeniFizickoObezbedjenjeForm()
        {
            InitializeComponent();
        }

        public IzmeniFizickoObezbedjenjeForm(FizickoObezbedjenjeDTO o)
        {
            InitializeComponent();
            fo = o;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = fo.Ime;
            textBox2.Text = fo.Prezime;
            comboBox1.Text = fo.Pol.ToString();
            textBox3.Text = fo.BorilackaVestina;
            dateTimePicker1.Value = fo.DatumRodjenja;
            if (fo.PEkipi != null)
            textBox4.Text = fo.PEkipi.RedniBroj.ToString();
        }

        private bool ValidacijaKontrolaFizickoObezbedjenje()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ime ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Prezime ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Borilacka vestina ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (dateTimePicker1.Value.Year + 18 > DateTime.Now.Year)
            {
                MessageBox.Show("Clan fizickog obezbedjenja mora imati minimum 18 godina.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                return false;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite pol",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                return false;
            }

            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || comboBox1.SelectedIndex == -1
                || textBox3.Text == String.Empty || dateTimePicker1.Value.Year + 18 > DateTime.Now.Year)
            {
                MessageBox.Show("Sva polja moraju biti popunjena.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void ProslediDugme_Click(object sender, EventArgs e)
        {
            if (!ValidacijaKontrolaFizickoObezbedjenje())
                return;
            int redniBrojEkipe;
            fo.Ime = textBox1.Text;
            fo.Prezime = textBox2.Text;
            fo.Pol = char.Parse(comboBox1.Text);
            fo.BorilackaVestina = textBox3.Text;
            fo.DatumRodjenja = dateTimePicker1.Value;
            if (textBox4.Text != "")
                redniBrojEkipe = int.Parse(textBox4.Text);
            else
                redniBrojEkipe = -1;

            DTOManager.azurirajFizickoObezbedjenje(fo, redniBrojEkipe);

            MessageBox.Show("Uspesno azurirano fizicko obezbedjenje!");
            this.Close();
        }
    }
}
