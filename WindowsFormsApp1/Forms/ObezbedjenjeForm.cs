using FluentNHibernate.Conventions.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

        private bool ValidacijaKontrola()
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ime ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Prezime ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Maticni broj ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (textBox1.Text.Length != 13)
            {
                MessageBox.Show("Maticni broj mora sadrzati 13 cifara.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                return false;
            }
            if (textBox2.Text == String.Empty || textBox3.Text == String.Empty || comboBox1.SelectedIndex == -1
                || textBox1.Text == String.Empty || datumRodj.Value.DayOfYear == DateTime.Now.DayOfYear || textBox5.Text == String.Empty)
            {
                MessageBox.Show("Sva polja moraju biti popunjena.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void ProslediObezbedjenje_Click(object sender, EventArgs e)
        {
            
            if (!ValidacijaKontrola())
                return;

            int redniBrojEkipe;
            FizickoObezbedjenjeDTO f = new FizickoObezbedjenjeDTO();
            f.MaticniBroj = long.Parse(textBox1.Text);
            f.Ime = textBox2.Text;
            f.Prezime = textBox3.Text;
            f.Pol = char.Parse(comboBox1.Text);
            f.BorilackaVestina = textBox5.Text;
            f.DatumRodjenja = datumRodj.Value;
            if (textBox6.Text != "")
            {
               redniBrojEkipe = int.Parse(textBox6.Text);
            }
            else
            {
               redniBrojEkipe = -1;
            }

            DTOManager.dodajFizickoObezbedjenje(f, redniBrojEkipe);

            MessageBox.Show("Uspesno dodato novo fizicko obezbedjenje!");
            this.Close();

        }
    }
}
