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
    public partial class RegionalniCentarForm : Form
    {
        public RegionalniCentarForm()
        {
            InitializeComponent();
            PopuniListView();

        }
        private void PopuniListView()
        {
            listView1.Items.Clear();

            List<RegionalniCentarDTO> centri = DTOManager.VratiRegionalneCentre();

            foreach (var centar in centri)
            {
                ListViewItem item = new ListViewItem(centar.Id.ToString());
                item.SubItems.Add(centar.Adresa);
                if (centar.Menadzer != null)
                {
                    item.SubItems.Add(centar.Menadzer.MaticniBroj.ToString());
                    item.SubItems.Add(centar.Menadzer.Ime);
                    item.SubItems.Add(centar.Menadzer.Prezime);
                }
                else
                {
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                }

                listView1.Items.Add(item);
            }
        }


        private void RegionalniCentarForm_Load(object sender, EventArgs e)
        {
            PopuniListView();
        }

        private void nazadDugme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite regionalni centar cije gradove zelite da vidite!");
                return;
            }
            ListViewItem selectedItem = listView1.SelectedItems[0];
            int idRegCnt = int.Parse(selectedItem.SubItems[0].Text);
            RegionalniCentarDTO rc = DTOManager.vratiRegCnt(idRegCnt);
            rc.ImenaGradova = DTOManager.vratiGradoveZaRegCentar(idRegCnt);
            rc.BrojeviTelefona = DTOManager.vratiTelefoneZaRegCentar(idRegCnt);
            rc.RegOznakaVozila = DTOManager.vratiVozilaZaRegCentar(idRegCnt);
            TelefoniGradoviRegCntForm frm = new TelefoniGradoviRegCntForm(rc);
            DialogResult dlg = frm.ShowDialog();
        }

        private void dodajDugme_Click(object sender, EventArgs e)
        {
            dodajRegionalniCentar frm = new dodajRegionalniCentar();
            DialogResult dlg = frm.ShowDialog();
            PopuniListView();
        }

        private void izbrisiDugme_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int regCentarId = int.Parse(selectedItem.SubItems[0].Text);

                var result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj regionalni centar?",
                                              "Potvrda brisanja",
                                              MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DTOManager.ObrisiRegionalniCentar(regCentarId);
                    MessageBox.Show("Regionalni centar je uspešno obrisan.");
                    PopuniListView();
                }
            }
            else
            {
                MessageBox.Show("Molimo izaberite regionalni centar za brisanje.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            izmeniMenadzeraRegCntForm frm = new izmeniMenadzeraRegCntForm();
            DialogResult dlg = frm.ShowDialog();
            PopuniListView();
        }
    }
}
