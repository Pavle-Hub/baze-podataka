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
    public partial class dodajVodjuForm : Form
    {

        private EkipaDTO ekipa;
        private IList<FizickoObezbedjenjeDTO> clanoviEkipe;

        public dodajVodjuForm()
        {
            InitializeComponent();
        }

        public dodajVodjuForm(EkipaDTO ekipa)
        {
            InitializeComponent();
            this.ekipa = ekipa;
            this.clanoviEkipe = ekipa.clanoviEkipe;
            popuniComboBox();
        }
        private void popuniComboBox()
        {
            foreach (var clan in clanoviEkipe)
            {
                comboBox1.Items.Add($"{clan.MaticniBroj}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                var maticniBroj = long.Parse((comboBox1.SelectedItem).ToString());
                DTOManager.PostaviVodju(ekipa.RedniBroj, maticniBroj);
                MessageBox.Show("Uspesno dodati vodja!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Izaberite člana iz liste.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
