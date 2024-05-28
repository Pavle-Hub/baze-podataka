using FluentNHibernate.Conventions.Helpers;
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
    public partial class ObezbedjenjeForm : Form
    {
        public ObezbedjenjeForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ProslediObezbedjenje_Click(object sender, EventArgs e)
        {
            try
            {
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
