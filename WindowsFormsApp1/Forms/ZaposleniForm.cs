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

            foreach(FizickoObezbedjenjeDTO a in lista)
            {
                if(a.PripadaEkipi != null)
                    listBox1.Items.Add(a.MaticniBroj + " - " + a.Ime + " " + a.Prezime + " - " + a.DatumRodjenja.ToString().Split(' ')[0] + " - " + a.Pol + " - " + a.BorilackaVestina + " - " + a.PripadaEkipi.RedniBroj);
                else
                    listBox1.Items.Add(a.MaticniBroj + " - " + a.Ime + " " + a.Prezime + " - " + a.DatumRodjenja.ToString().Split(' ')[0] + " - " + a.Pol + " - " + a.BorilackaVestina + " -  null");
            }

        }

        private void PopuniListuTehnickoLice()
        {

        }

        private void PopuniListuMenadzera()
        {

        }

        private void dodajObezbedjenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoObezbedjenje f = new FizickoObezbedjenje();

                f.MaticniBroj = 1111111111;
                f.Ime = "Pavle";
                f.Prezime = "Petrovic";
                f.DatumRodjenja = new DateTime(2020, 12, 12);
                f.Pol = 'M';
                f.BorilackaVestina = "tekvondo";
                f.PripadaEkipi = null;
                s.Save(f);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno dodato novo fizicko obezbedjenje!");

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

                FizickoObezbedjenje f = s.Load<FizickoObezbedjenje>(Convert.ToInt64(1111111111));
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
    }
}
