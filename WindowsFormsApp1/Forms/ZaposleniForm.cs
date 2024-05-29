﻿using NHibernate.Linq.Functions;
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
    public partial class ZaposleniForm : Form
    {
        public ZaposleniForm()
        {
            InitializeComponent();
        }

        private void ZaposleniForm_Load(object sender, EventArgs e)
        {
            PopuniListuFizickoObezbedjenje();
            PopuniListuTehnickoLice();
            PopuniListuMenadzera();
        }

        private void PopuniListuFizickoObezbedjenje()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Loading...");

            List<FizickoObezbedjenjeDTO> lista = DTOManager.PopuniFizickoObezbedjenje();

            listBox1.Items.Clear();

            foreach (FizickoObezbedjenjeDTO a in lista)
            {
                if (a.PripadaEkipi != null)
                    listBox1.Items.Add(a.MaticniBroj + " - " + a.Ime + " " + a.Prezime + " - " + a.DatumRodjenja.ToString().Split(' ')[0] + " - " + a.Pol + " - " + a.BorilackaVestina + " - " + a.PripadaEkipi.RedniBroj);
                else
                    listBox1.Items.Add(a.MaticniBroj + " - " + a.Ime + " " + a.Prezime + " - " + a.DatumRodjenja.ToString().Split(' ')[0] + " - " + a.Pol + " - " + a.BorilackaVestina + " -  null");
            }

        }

        private void PopuniListuTehnickoLice()
        {
            listBox2.Items.Clear();
            listBox2.Items.Add("Loading...");

            List<TehnickoLiceDTO> lista = DTOManager.PopuniTehnickoLice();

            listBox2.Items.Clear();

            foreach (TehnickoLiceDTO a in lista)
            {
                listBox2.Items.Add(a.MaticniBroj + " - " + a.Ime + " " + a.Prezime + " - " + a.DatumRodjenja.ToString().Split(' ')[0] + " - " + a.Pol + " - " + a.StrucnaSprema + " " + a.Oblast);
            }
        }

        private void PopuniListuMenadzera()
        {
            listBox3.Items.Clear();
            listBox3.Items.Add("Loading...");

            List<MenadzerDTO> lista = DTOManager.PopuniMenadzera();

            listBox3.Items.Clear();

            foreach (MenadzerDTO a in lista)
            {
                listBox3.Items.Add(a.MaticniBroj + " - " + a.Ime + " " + a.Prezime + " - " + a.DatumRodjenja.ToString().Split(' ')[0] + " - " + a.Pol);
            }
        }

        private void dodajObezbedjenje_Click(object sender, EventArgs e)
        {
            try
            { 

                ObezbedjenjeForm frm = new ObezbedjenjeForm();
                DialogResult dlg = frm.ShowDialog();

                PopuniListuFizickoObezbedjenje();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void izbrisiObezbedjenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje f = s.Load<FizickoObezbedjenje>(Convert.ToInt64((listBox1.SelectedItem).ToString().Substring(0,13)));
                s.Delete(f);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno obrisano fizicko obezbedjenje!");

                PopuniListuFizickoObezbedjenje();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void izmeniObezbedjenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje f = s.Load<FizickoObezbedjenje>(1987465230128);

                f.Pol = 'Z';
                f.Ime = "Stoja";
                f.Prezime = "Hrebeljanovic";

                s.SaveOrUpdate(f);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno azurirano fizicko obezbedjenje!");


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajTehnickoLice_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                ObezbedjenjeForm frm = new ObezbedjenjeForm();//treba da se izmeni na TehnickoLice_form

                DialogResult dlg = frm.ShowDialog();

                TehnickoLice f = new TehnickoLice();

                f.MaticniBroj = 222222222;
                f.Ime = "Stefan";
                f.Prezime = "Gejovic";
                f.DatumRodjenja = new DateTime(2002, 11, 10);
                f.Pol = 'M';
                f.StrucnaSprema = "osnovna skola";
                f.Oblast = "informatika";
                s.Save(f);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno dodato novo tehnicko lice!");

                PopuniListuFizickoObezbedjenje();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje f = s.Load<FizickoObezbedjenje>(222222222);

                f.Pol = 'Z';
                f.Ime = "Stoja";
                f.Prezime = "Hrebeljanovic";

                s.SaveOrUpdate(f);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno azurirano tehicko lice!");


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
