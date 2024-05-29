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
    public partial class dodajTehnickoLiceForm : Form
    {
        public dodajTehnickoLiceForm()
        {
            InitializeComponent();
        }

        private void ProslediTehickoLice_Click(object sender, EventArgs e)
        {

            //if (!ValidacijaKontrola())
            //    return;

            TehnickoLiceDTO t = new TehnickoLiceDTO();

            t.MaticniBroj = long.Parse(textBox1.Text);
            t.Ime = textBox2.Text;
            t.Prezime = textBox3.Text;
            t.Pol = null;
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                t.Pol = char.Parse(comboBox1.Text);
            }
            t.StrucnaSprema = textBox6.Text;
            t.Oblast = textBox5.Text;
            t.DatumRodjenja = dateTimePicker1.Value;

            DTOManager.dodajTehnickoLice(t);

            MessageBox.Show("Uspesno dodato novo tehnicko lice!");
            this.Close();
        }
    }
}
