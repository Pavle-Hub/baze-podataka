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
    public partial class ObjekatForm : Form
    {
        public ObjekatForm()
        {
            InitializeComponent();
            PopuniListView();
        }

        private void PopuniListView()
        {
            listView1.Items.Clear();

            List<ObjekatDTO> objekti = DTOManager.vratiSveObjekte();

            foreach (var objekat in objekti)
            {
                ListViewItem item = new ListViewItem(objekat.Id.ToString());
                item.SubItems.Add(objekat.Adresa);
                item.SubItems.Add(objekat.Tip);
                item.SubItems.Add(objekat.Povrsina.ToString());

                listView1.Items.Add(item);
            }
        }

        private void nazadDugme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajDugme_Click(object sender, EventArgs e)
        {
            dodajObjekatForm frm = new dodajObjekatForm();
            DialogResult dlg = frm.ShowDialog();
            PopuniListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ObjekatForm_Load(object sender, EventArgs e)
        {
            PopuniListView();
        }

        private void izbrisiDugme_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati objekat koji želite obrisati!");
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];
            int objekatId = int.Parse(selectedItem.SubItems[0].Text);

            DTOManager.ObrisiObjekat(objekatId);

            MessageBox.Show("Objekat je uspešno obrisan.");
            PopuniListView();
        }

        private void alarmDugme_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati objekat!");
                return;
            }

            ListViewItem selectedItem = listView1.SelectedItems[0];
            int objekatId = int.Parse(selectedItem.SubItems[0].Text);

            List<AlarmniSistemDTO> alarmniSistemi = DTOManager.vratiAlarmneSistemeZaObjekat(objekatId);

            if (alarmniSistemi.Count == 0)
            {
                MessageBox.Show("Nema alarmnih sistema za odabrani objekat.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Alarmni sistemi za odabrani objekat:");

            foreach (var alarm in alarmniSistemi)
            {
                sb.AppendLine($"ID: {alarm.Id}, Proizvodjac: {alarm.Proizvodjac}, Godina Proizvodnje: {alarm.GodinaProizvodnje}, Datum instalacije: {alarm.DatumInstalacije}");
            }

            MessageBox.Show(sb.ToString(), "Alarmni sistemi");
        }

        private void telefoniDugme_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            int idObjekta = int.Parse(selectedItem.SubItems[0].Text);
            ObjekatDTO objekat = DTOManager.vratiObjekat(idObjekta);
            objekat.KontaktTelefoni = DTOManager.vratiTelefoneZaObjekat(objekat.Id);
            KontaktTelefoniObjektaForm frm = new KontaktTelefoniObjektaForm(objekat);
            DialogResult dlg = frm.ShowDialog();
        }

        private void smeneDugme_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete objekat.");
                return;
            }

            int objekatId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            List<SmenaDTO> smene = DTOManager.VratiSmeneZaObjekat(objekatId);

            if (smene.Any())
            {
                StringBuilder smeneText = new StringBuilder();
                smeneText.AppendLine("Smene za izabrani objekat:");

                foreach (var smena in smene)
                {
                    smeneText.AppendLine($"Smena ID: {smena.Id}, Vreme pocetka: {smena.VremePocetka}, Vreme kraja: {smena.VremeKraja}");
                }

                MessageBox.Show(smeneText.ToString());
            }
            else
            {
                MessageBox.Show("Nema smena za izabrani objekat.");
            }
        }

        private void intervencijeDugme_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas da izaberete objekat.");
                return;
            }

            int objekatId = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            List<IntervencijaDTO> intervencije = DTOManager.VratiIntervencijeZaObjekat(objekatId);

            if (intervencije.Any())
            {
                StringBuilder IntervencijeText = new StringBuilder();
                IntervencijeText.AppendLine("Intervencije za izabrani objekat:");

                foreach (var i in intervencije)
                {
                    IntervencijeText.AppendLine($"Intervencija ID: {i.Id}, Vreme: {i.Vreme}, Datum: {i.Datum}, Ekipa:{i.IntervencijaEkipe.RedniBroj}");
                }

                MessageBox.Show(IntervencijeText.ToString());
            }
            else
            {
                MessageBox.Show("Nema intervencija za izabrani objekat.");
            }
        }
    }
}