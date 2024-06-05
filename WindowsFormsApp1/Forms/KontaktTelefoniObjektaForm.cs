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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Forms
{
    public partial class KontaktTelefoniObjektaForm : Form
    {
        ObjekatDTO objekat = new ObjekatDTO();
        public KontaktTelefoniObjektaForm()
        {
            InitializeComponent();
        }
        public KontaktTelefoniObjektaForm(ObjekatDTO o)
        {
            InitializeComponent();
            objekat = o;
            PopuniListViewTelefona();
        }

        public void PopuniListViewTelefona()
        {
            listView1.Items.Clear();
            if (objekat.KontaktTelefoni != null &&  objekat != null)
            {
                foreach (var item in objekat.KontaktTelefoni)
                {
                    listView1.Items.Add(new ListViewItem(item.ToString()));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int brojTelefona = int.Parse(textBox1.Text);
            if (string.IsNullOrWhiteSpace(brojTelefona.ToString()))
            {
                MessageBox.Show("Unesite broj telefona.");
                return;
            }
            DTOManager.DodajBrojTelefonaObjektu(objekat.Id, brojTelefona);
            objekat.KontaktTelefoni = DTOManager.vratiTelefoneZaObjekat(objekat.Id);
            PopuniListViewTelefona();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int brojTelefona = int.Parse(selectedItem.SubItems[0].Text);
                DTOManager.ObrisiBrojTelefonaObjektu(brojTelefona, objekat.Id);
                objekat.KontaktTelefoni = DTOManager.vratiTelefoneZaObjekat(objekat.Id);
                PopuniListViewTelefona();
            }
            else
            {
                MessageBox.Show("Izaberite broj koji zelite da obrisete!");
            }
        }
    }
}
