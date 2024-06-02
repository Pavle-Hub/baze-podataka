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
    public partial class LicaIObjektiZaAlarmForm : Form
    {

        AlarmniSistemDTO alsis = new AlarmniSistemDTO();
        TehnickoLiceDTO lice = new TehnickoLiceDTO();
        public LicaIObjektiZaAlarmForm()
        {
            InitializeComponent();
        }

        public LicaIObjektiZaAlarmForm(AlarmniSistemDTO asis)
        {
            InitializeComponent();
            alsis = asis;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LicaIObjektiZaAlarmForm_Load(object sender, EventArgs e)
        {
            popuniListuObjekta();
            popuniListuTehnickih();
        }

        public void popuniListuObjekta()
        {
            if (alsis.Obj != null)
            {
                ObjekatDTO objekat = DTOManager.vratiObjekat(alsis.Obj.Id);
                ListViewItem item = new ListViewItem(new string[] { objekat.Id.ToString(), objekat.Adresa, objekat.Tip, objekat.Povrsina.ToString() });
                this.listView2.Items.Add(item);
            }
        }

        public void popuniListuTehnickih()
        {
            alsis.LiceKojeOdrzava = DTOManager.vratiListuTehnickih(alsis.Id);
            foreach (TehnickoLiceDTO tl in alsis.LiceKojeOdrzava)
            {
                ListViewItem item = new ListViewItem(new string[] { tl.MaticniBroj.ToString(), tl.Ime, tl.Prezime, tl.DatumRodjenja.ToString(), tl.Pol.ToString() });
                this.listView1.Items.Add(item);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            string firstColumnValue = selectedItem.SubItems[0].Text;
            long maticniBrojTehnickog = long.Parse(firstColumnValue);
            lice = DTOManager.vratiTehnickoLice(maticniBrojTehnickog);
            OdrzavaDTO odrzavanje = DTOManager.vratiOdrzavanje(alsis, lice);
            string poruka = $"Pocetak odrzavanja: {odrzavanje.DatumOd}, kraj odrzavanja: {odrzavanje.DatumDo}";
            string title = "Datum odrzavanja";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

        }
    }
}
