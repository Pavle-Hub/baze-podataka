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
    public partial class dodajRegionalniCentar : Form
    {
        public dodajRegionalniCentar()
        {
            InitializeComponent();
            PopuniComboBoxMenadzeri(comboBox1);
        }

        public void PopuniComboBoxMenadzeri(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            var menadzeri = DTOManager.VratiSveMenadzere();
            foreach (var menadzer in menadzeri)
            {
                comboBox.Items.Add(menadzer);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string adresa = textBox1.Text;
            if (comboBox1.SelectedItem is MenadzerDTO izabraniMenadzer)
            {
                long menadzerId = izabraniMenadzer.MaticniBroj;
                DTOManager.DodajNoviRegionalniCentar(adresa, menadzerId);
                MessageBox.Show("Novi regionalni centar je uspešno dodat.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Molimo izaberite menadžera.");
            }

        }
    }
}
