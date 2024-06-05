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
    public partial class TelefoniGradoviRegCntForm : Form
    {
        RegionalniCentarDTO regcnt = new RegionalniCentarDTO();
        public TelefoniGradoviRegCntForm()
        {
            InitializeComponent();
        }

        public TelefoniGradoviRegCntForm(RegionalniCentarDTO rc)
        {
            InitializeComponent();
            regcnt = rc;
            PopuniListViewGradova();
            PopuniListViewTelefona();
            PopuniListViewVozila();
        }
        public void PopuniListViewGradova()
        {
            listView1.Items.Clear();
            if (regcnt != null && regcnt.ImenaGradova != null)
            {
                foreach (var item in regcnt.ImenaGradova)
                {
                    listView1.Items.Add(new ListViewItem(item));
                }
            }
        }

        public void PopuniListViewTelefona()
        {
            listView2.Items.Clear();
            if (regcnt.BrojeviTelefona != null && regcnt != null)
            {
                foreach (var item in regcnt.BrojeviTelefona)
                {
                    listView2.Items.Add(new ListViewItem(item.ToString()));
                }
            }
        }

        public void PopuniListViewVozila()
        {
            listView3.Items.Clear();
            if (regcnt.RegOznakaVozila != null && regcnt != null)
            {
                foreach (var item in regcnt.RegOznakaVozila)
                {
                    listView3.Items.Add(new ListViewItem(item));
                }
            }
        }

        private void nazadDugme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelefoniGradoviRegCntForm_Load(object sender, EventArgs e)
        {
            PopuniListViewGradova();
            PopuniListViewTelefona();
            PopuniListViewVozila();
        }

        private void dodajGradDugme_Click(object sender, EventArgs e)
        {
            string imeGrada = textBox1.Text;
            if (string.IsNullOrWhiteSpace(imeGrada))
            {
                MessageBox.Show("Unesite ime grada.");
                return;
            }
            DTOManager.DodajNoviGrad(imeGrada, regcnt.Id);
            MessageBox.Show("Uspesno dodat Grad!");
            regcnt.ImenaGradova = DTOManager.vratiGradoveZaRegCentar(regcnt.Id);
            PopuniListViewGradova();
        }

        private void izbrisiGradDugme_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            string imeGrada = selectedItem.SubItems[0].Text;
            DTOManager.ObrisiGrad(imeGrada, regcnt.Id);
            regcnt.ImenaGradova = DTOManager.vratiGradoveZaRegCentar(regcnt.Id);
            PopuniListViewGradova();

        }

        private void dodajBrojDugme_Click(object sender, EventArgs e)
        {
            int brojTelefona = int.Parse(textBox2.Text);
            if (string.IsNullOrWhiteSpace(brojTelefona.ToString()))
            {
                MessageBox.Show("Unesite broj telefona.");
                return;
            }
            DTOManager.DodajBrojTelefona(regcnt.Id, brojTelefona);
            regcnt.BrojeviTelefona = DTOManager.vratiTelefoneZaRegCentar(regcnt.Id);
            PopuniListViewTelefona();
        }

        private void izbrisiBrojDugme_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView2.SelectedItems[0];
            int brojTelefona = int.Parse(selectedItem.SubItems[0].Text);
            DTOManager.ObrisiBrojTelefona(brojTelefona, regcnt.Id);
            regcnt.BrojeviTelefona = DTOManager.vratiTelefoneZaRegCentar(regcnt.Id);
            PopuniListViewTelefona();
        }
    }
}
