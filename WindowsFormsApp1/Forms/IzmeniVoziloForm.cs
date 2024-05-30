using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entiteti;

namespace WindowsFormsApp1.Forms
{
    public partial class IzmeniVoziloForm : Form
    {
        VoziloDTO vozilo;
        public IzmeniVoziloForm()
        {
            InitializeComponent();
        }
        public IzmeniVoziloForm(VoziloDTO v)
        {
            InitializeComponent();
            vozilo = v;
            popuniPodacima();
        }

        public void popuniPodacima()
        {

            textBox1.Text = vozilo.Boja;
            textBox4.Text = vozilo.Tip;
            textBox3.Text = vozilo.Model;
            textBox2.Text = vozilo.Proizvodjac;
            dateTimePicker1.Value = vozilo.DatumOd;
            dateTimePicker2.Value = vozilo.DatumDo;
            // Prepopunite comboBox kontrole sa odgovarajućim vrednostima
            //textBox5.Text = vozilo.RC?.Naziv; 
            //textBox6.Text = long.Parse(vozilo.DuziGaEkipa?);
        }

        private bool ValidacijaKontrolaVozilo()
        {


            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Boja ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Tip ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Model ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Proizvođač ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        private void izmeniVozilo_Click(object sender, EventArgs e)
        {

        }

        private void IzmeniVoziloForm_Load(object sender, EventArgs e)
        {

        }
    }
}
