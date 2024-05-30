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
    public partial class dodajTehnickoLiceForm : Form
    {
        public dodajTehnickoLiceForm()
        {
            InitializeComponent();
        }

        private bool ValidacijaKontrolaTehnickoLice()
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

            if (dateTimePicker1.Value.Year + 18 > DateTime.Now.Year)
            {
                MessageBox.Show("Tehničko lice mora imati minimum 18 godina.",
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

            if (String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Stručna sprema ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Oblast ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        private void ProslediTehickoLice_Click(object sender, EventArgs e)
        {

            if (!ValidacijaKontrolaTehnickoLice())
                return;

            TehnickoLiceDTO t = new TehnickoLiceDTO();

            t.MaticniBroj = long.Parse(textBox1.Text);
            t.Ime = textBox2.Text;
            t.Prezime = textBox3.Text;
            t.Pol = null;
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                t.Pol = char.Parse(comboBox1.Text);
            }
            t.StrucnaSprema = textBox6.Text;
            t.Oblast = textBox5.Text;
            t.DatumRodjenja = dateTimePicker1.Value;

            DTOManager.dodajTehnickoLice(t);

            MessageBox.Show("Uspesno dodato novo tehnicko lice!");
            this.Close();
        }
    }
}
