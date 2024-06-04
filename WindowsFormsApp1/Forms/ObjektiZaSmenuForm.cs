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
using WindowsFormsApp1.Entiteti;

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
            PopuniDetalje();
        }

        private void PopuniDetalje()
        {
            listView1.Items.Clear();
            foreach (var objekat in smena.ObjektiZaSmenu)
            {
                var item = new ListViewItem((objekat.Id).ToString());
                item.SubItems.Add(objekat.Adresa);
                item.SubItems.Add(objekat.Tip);
                item.SubItems.Add((objekat.Povrsina).ToString());
                listView1.Items.Add(item);
            }

            listView2.Items.Clear();
            foreach (var clan in smena.EkipaZaSmenu.clanoviEkipe)
            {
                var item = new ListViewItem(clan.MaticniBroj.ToString());
                item.SubItems.Add(clan.Ime);
                item.SubItems.Add(clan.Prezime);
                listView2.Items.Add(item);
            }

        }

        private void ObjektiZaSmenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
