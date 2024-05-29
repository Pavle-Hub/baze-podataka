using NHibernate.Linq.Functions;
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

                FizickoObezbedjenje f = s.Load<FizickoObezbedjenje>(Convert.ToInt64((listBox1.SelectedItem).ToString().Substring(0, 13)));
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

                dodajTehnickoLiceForm frm = new dodajTehnickoLiceForm();
                DialogResult dlg = frm.ShowDialog();

                PopuniListuTehnickoLice();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void izmeniTehnickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice f = s.Load<TehnickoLice>(222222222);

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

        private void obrisiTehnickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TehnickoLice f = s.Load<TehnickoLice>(Convert.ToInt64((listBox2.SelectedItem).ToString().Substring(0, 13)));
                s.Delete(f);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno obrisano Tehnicko Lice!");

                PopuniListuTehnickoLice();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void dodajMenadzera_Click(object sender, EventArgs e)
        {
            try
            {
                dodajMenadzeraForm frm = new dodajMenadzeraForm();
                DialogResult dlg = frm.ShowDialog();

                PopuniListuTehnickoLice();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Menadzer f = s.Load<Menadzer>(Convert.ToInt64((listBox2.SelectedItem).ToString().Substring(0, 13)));
                s.Delete(f);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno obrisan Menadzer!");

                PopuniListuMenadzera();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
