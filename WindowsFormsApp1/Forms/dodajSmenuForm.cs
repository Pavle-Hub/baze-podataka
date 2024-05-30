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
    public partial class dodajSmenuForm : Form
    {
        public dodajSmenuForm()
        {
            InitializeComponent();
        }

        private void ProslediSmenu_Click(object sender, EventArgs e)
        {

            //if (!ValidacijaKontrolaSmena())
                //return;

            SmenaDTO s = new SmenaDTO();

            s.Id = int.Parse(textBox1.Text);
            s.EkipaZaSmenu = DTOManager.vratiEkipuSmene(int.Parse(textBox2.Text));
            s.VremePocetka = dateTimePicker1.Value;
            s.VremeKraja = dateTimePicker2.Value;           

            DTOManager.dodajSmenu(s);

            MessageBox.Show("Uspesno dodato novo tehnicko lice!");
            this.Close();
        }

    }
}
