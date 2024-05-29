﻿using FluentNHibernate.Conventions.Helpers;
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
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ime ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Prezime ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Maticni broj ne sme biti prazno polje.",
                                "Obavestenje",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Borilacka vestina ne sme biti prazno polje.",
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

            if (datumRodj.Value.Year + 18 > DateTime.Now.Year)
            {
                MessageBox.Show("Clan fizickog obezbedjenja mora imati minimum 18 godina.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                return false;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite pol",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                return false;
            }

            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || comboBox1.SelectedIndex == -1
                || textBox3.Text == String.Empty || datumRodj.Value.Year + 18 > DateTime.Now.Year || textBox5.Text == String.Empty)
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
            try
            {
                if (!ValidacijaKontrola())
                    return;

                ISession s = DataLayer.GetSession();
                int redniBrojEkipe;

                long maticniBroj = long.Parse(textBox1.Text);
                string ime = textBox2.Text;
                string prezime = textBox3.Text;
                char pol = char.Parse(comboBox1.Text);
                
                string borilackaVestina = textBox5.Text;
                DateTime datumRodjenja = datumRodj.Value;

                if (textBox6.Text != "")
                {
                    redniBrojEkipe = int.Parse(textBox6.Text);
                }
                else
                {
                    redniBrojEkipe = -1;
                }


                FizickoObezbedjenje f = new FizickoObezbedjenje();
                f.MaticniBroj = maticniBroj;
                f.Ime = ime;
                f.Prezime = prezime;
                f.Pol = pol;
                f.BorilackaVestina = borilackaVestina;
                f.DatumRodjenja = datumRodjenja;

                if (redniBrojEkipe == -1)
                {
                    f.PripadaEkipi = null;
                }
                else
                {
                    f.PripadaEkipi = s.Load<Ekipa>(redniBrojEkipe);
                }

                s.Save(f);

                s.Flush();

                s.Close();

                MessageBox.Show("Uspesno dodato novo fizicko obezbedjenje!");

                this.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("oh no\n" + ec.Message);
            }
        }
    }
}
