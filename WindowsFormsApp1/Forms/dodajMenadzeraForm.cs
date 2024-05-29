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
    public partial class dodajMenadzeraForm : Form
    {
        public dodajMenadzeraForm()
        {
            InitializeComponent();
        }

        private bool ValidacijaKontrolaMenadzer()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Matični broj ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (textBox1.Text.Length != 13)
            {
                MessageBox.Show("Matični broj mora sadržati 13 cifara.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Ime ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Prezime ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (datumRodj.Value.Year + 18 > DateTime.Now.Year)
            {
                MessageBox.Show("Menadžer mora imati minimum 18 godina.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite pol.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        private void ProslediMenadzera_Click(object sender, EventArgs e)
        {

            if (!ValidacijaKontrolaMenadzer())
                return;

            MenadzerDTO m = new MenadzerDTO();

            m.MaticniBroj = long.Parse(textBox1.Text);
            m.Ime = textBox2.Text;
            m.Prezime = textBox3.Text;
            m.Pol = null;
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                m.Pol = char.Parse(comboBox1.Text);
            }
            m.DatumRodjenja = datumRodj.Value;

            DTOManager.dodajMenadzera(m);

            MessageBox.Show("Uspesno dodat novi menadzer!");
            this.Close();
        }
    }
}
