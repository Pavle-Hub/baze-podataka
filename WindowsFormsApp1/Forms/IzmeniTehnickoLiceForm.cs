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
    public partial class IzmeniTehnickoLiceForm : Form
    {
        TehnickoLiceDTO t = new TehnickoLiceDTO();
        public IzmeniTehnickoLiceForm()
        {
            InitializeComponent();
        }

        public IzmeniTehnickoLiceForm(TehnickoLiceDTO itl)
        {
            InitializeComponent();
            t = itl;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            textBox1.Text = t.Ime;
            textBox2.Text = t.Prezime;
            comboBox1.Text = t.Pol.ToString();
            dateTimePicker1.Value = t.DatumRodjenja;
            textBox3.Text = t.StrucnaSprema;
            textBox4.Text = t.Oblast;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidacijaKontrolaTehnickoLice()
        {


            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ime ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
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

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Stručna sprema ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Oblast ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidacijaKontrolaTehnickoLice())
              return;

            t.Ime = textBox1.Text;
            t.Prezime = textBox2.Text;
            t.Pol = char.Parse(comboBox1.Text);
            t.DatumRodjenja = dateTimePicker1.Value;
            t.StrucnaSprema = textBox3.Text;
            t.Oblast = textBox4.Text;

            DTOManager.azurirajTehnickoLice(t);

            MessageBox.Show("Uspesno azurirano tehnicko lice!");
            this.Close();
        }
    }
}
