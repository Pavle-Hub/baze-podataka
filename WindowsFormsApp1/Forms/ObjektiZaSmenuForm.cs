using NHibernate.SqlCommand;
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
    public partial class ObjektiZaSmenuForm : Form
    {

        SmenaDTO smena = new SmenaDTO();

        public ObjektiZaSmenuForm()
        {
            InitializeComponent();
        }

        public ObjektiZaSmenuForm(SmenaDTO sm)
        {
            InitializeComponent();
            smena = sm;
        }

        public void popuniListuObjekta()
        {
            smena.ObjektiZaSmenu = DTOManager.vratiListuObjekataSmene(smena.Id);
            foreach (ObjekatDTO obj in smena.ObjektiZaSmenu)
            {
                ListViewItem item = new ListViewItem(new string[] { obj.Id.ToString(), obj.Tip, obj.Povrsina.ToString(), obj.Adresa });
                this.listView1.Items.Add(item);
            }
        }

        public void popuniListuClanovaEkipeSmene()
        {
            smena.clanoviSmene = DTOManager.vratiListuClanovaEkipeSmene(smena.Id);
            foreach (FizickoObezbedjenjeDTO fo in smena.clanoviSmene)
            {
                ListViewItem item = new ListViewItem(new string[] { fo.MaticniBroj.ToString(), fo.Ime, fo.Prezime, fo.DatumRodjenja.ToString(), fo.Pol.ToString(), fo.BorilackaVestina});
                this.listView2.Items.Add(item);
            }
        }

        private void ObjektiZaSmenuForm_Load(object sender, EventArgs e)
        {
            popuniListuObjekta();
            popuniListuClanovaEkipeSmene();
        }
    }
}
