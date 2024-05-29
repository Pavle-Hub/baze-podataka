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
    public partial class IzmeniMenadzeraForm : Form
    {
        MenadzerDTO m = new MenadzerDTO();
        public IzmeniMenadzeraForm()
        {
            InitializeComponent();
        }

        public IzmeniMenadzeraForm(MenadzerDTO men)
        {
            InitializeComponent();
            m = men;
            popuniPodacima();
        }


        public void popuniPodacima()
        {
            textBox1.Text = m.Ime;
            textBox2.Text = m.Prezime;
            comboBox1.Text = m.Pol.ToString();
            datumRodj.Value = m.DatumRodjenja;
        }

        private bool ValidacijaKontrolaMenadzer()
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

        private void button1_Click(object sender, EventArgs e)
        {
            //if (!ValidacijaKontrola())
            //  return;

            m.Ime = textBox1.Text;
            m.Prezime = textBox2.Text;
            m.Pol = char.Parse(comboBox1.Text);
            m.DatumRodjenja = datumRodj.Value;

            DTOManager.azurirajMenadzera(m);

            MessageBox.Show("Uspesno azuriran menadzer!");
            this.Close();
        }
    }
}
