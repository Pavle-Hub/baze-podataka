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
            dateTimePicker1.Value = m.DatumRodjenja;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (!ValidacijaKontrola())
            //  return;

            m.Ime = textBox1.Text;
            m.Prezime = textBox2.Text;
            m.Pol = char.Parse(comboBox1.Text);
            m.DatumRodjenja = dateTimePicker1.Value;

            DTOManager.azurirajMenadzera(m);

            MessageBox.Show("Uspesno azuriran menadzer!");
            this.Close();
        }
    }
}
