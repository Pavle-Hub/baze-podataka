﻿using System;
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
            textBox4.Text = fo.PEkipi.RedniBroj.ToString();
        }

        private void ProslediDugme_Click(object sender, EventArgs e)
        {
          
            fo.Ime = textBox1.Text;
            fo.Prezime = textBox2.Text;
            fo.Pol = char.Parse(comboBox1.Text);
            fo.BorilackaVestina = textBox3.Text;
            fo.DatumRodjenja = dateTimePicker1.Value;
            int redniBrojEkipe = int.Parse(textBox4.Text);

            DTOManager.azurirajFizickoObezbedjenje(fo, redniBrojEkipe);
            this.Close();
        }
    }
}
