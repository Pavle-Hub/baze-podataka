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
            ObezbedjenjeForm frm = new ObezbedjenjeForm();
            DialogResult dlg = frm.ShowDialog();

            PopuniListuFizickoObezbedjenje();
        }

        private void izbrisiObezbedjenje_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite obezbedjenje koje zelite da obrisete!");
                return;
            }

            long maticniBrojFizickog = Convert.ToInt64((listBox1.SelectedItem).ToString().Substring(0, 13));
            string poruka = "Da li zelite da obrisete izabranog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiFizickoObezbedjenje(maticniBrojFizickog);
                MessageBox.Show("Uspesno obrisano fizicko obezbedjenje!");
                this.PopuniListuFizickoObezbedjenje();
            }

        }

        private void izmeniObezbedjenje_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite obezbedjenje cije podatke zelite da izmenite!");
                return;
            }

            long maticniBrojFizickog = Convert.ToInt64((listBox1.SelectedItem).ToString().Substring(0, 13));
            FizickoObezbedjenjeDTO fo = DTOManager.vratiFizickoObezbedjenje(maticniBrojFizickog);
            IzmeniFizickoObezbedjenjeForm frm = new IzmeniFizickoObezbedjenjeForm(fo);
            DialogResult dlg = frm.ShowDialog();

            PopuniListuFizickoObezbedjenje();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajTehnickoLice_Click(object sender, EventArgs e)
        {

            dodajTehnickoLiceForm frm = new dodajTehnickoLiceForm();
            DialogResult dlg = frm.ShowDialog();

            PopuniListuTehnickoLice();

        }

        private void izmeniTehnickoLice_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite tehnicko lice cije podatke zelite da izmenite!");
                return;
            }
            long maticniBrojTehnickog = Convert.ToInt64((listBox2.SelectedItem).ToString().Substring(0, 13));
            TehnickoLiceDTO t = DTOManager.vratiTehnickoLice(maticniBrojTehnickog);
            IzmeniTehnickoLiceForm frm = new IzmeniTehnickoLiceForm(t);
            DialogResult dlg = frm.ShowDialog();

            PopuniListuTehnickoLice();

        }

        private void obrisiTehnickoLice_Click(object sender, EventArgs e)
        {


            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite tehnicko lice koje zelite da obrisete!");
                return;
            }

            long maticniBrojTehnickog = Convert.ToInt64((listBox2.SelectedItem).ToString().Substring(0, 13));
            string poruka = "Da li zelite da obrisete izabranog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiTehnickoLice(maticniBrojTehnickog);
                MessageBox.Show("Uspesno obrisano tehnicko lice!");
                this.PopuniListuTehnickoLice();
            }
        }

        private void dodajMenadzera_Click(object sender, EventArgs e)
        {
            try
            {
                dodajMenadzeraForm frm = new dodajMenadzeraForm();
                DialogResult dlg = frm.ShowDialog();

                PopuniListuMenadzera();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite menadzera kojeg zelite da obrisete!");
                return;
            }

            long maticniBrojMenadzera = Convert.ToInt64((listBox3.SelectedItem).ToString().Substring(0, 13));
            string poruka = "Da li zelite da obrisete izabranog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiMenadzera(maticniBrojMenadzera);
                MessageBox.Show("Uspesno obrisan menadzer!");
                this.PopuniListuMenadzera();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite menadzera cije podatke zelite da izmenite!");
                return;
            }
            long maticniBrojMenadzer = Convert.ToInt64((listBox3.SelectedItem).ToString().Substring(0, 13));
            MenadzerDTO m = DTOManager.vratiMenadzera(maticniBrojMenadzer);
            IzmeniMenadzeraForm frm = new IzmeniMenadzeraForm(m);
            DialogResult dlg = frm.ShowDialog();

            PopuniListuMenadzera();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite menadzera cije gradove zelite da vidite!");
                return;
            }
            else
            {
                long maticniBrojMenadzer = Convert.ToInt64((listBox3.SelectedItem).ToString().Substring(0, 13));
                MenadzerDTO m = DTOManager.vratiMenadzera(maticniBrojMenadzer);
                GradoviMenadzeraForm frm = new GradoviMenadzeraForm(m);
                DialogResult dlg = frm.ShowDialog();
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite tehnicko lice cije podatke zelite da vidite!");
                return;
            }
            long maticniBroj = Int64.Parse((listBox2.SelectedItem).ToString().Split(' ')[0]);
            TehnickoLiceDTO tl = DTOManager.vratiTehnickoLice(maticniBroj);
            ListaAlarmaZaTehnickoForm frm = new ListaAlarmaZaTehnickoForm(tl);
            DialogResult dlg = frm.ShowDialog();
        }
    }
}
