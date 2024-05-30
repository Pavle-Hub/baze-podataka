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
            ObjekatDTO objekat = DTOManager.vratiObjekat(alsis.Obj.Id);
            ListViewItem item = new ListViewItem(new string[] { objekat.Id.ToString(), objekat.Adresa, objekat.Tip, objekat.Povrsina.ToString() });
            this.listView2.Items.Add(item);
        }

        public void popuniListuTehnickih()
        {
            alsis.LiceKojeOdrzava = DTOManager.vratiListuTehnickih(alsis.Id);
            foreach(TehnickoLiceDTO tl in alsis.LiceKojeOdrzava)
            {
                ListViewItem item = new ListViewItem(new string[] { tl.MaticniBroj.ToString(), tl.Ime, tl.Prezime, tl.DatumRodjenja.ToString() });
                this.listView1.Items.Add(item);
            }
        }
    }
}
