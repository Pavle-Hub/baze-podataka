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
    public partial class dodajMenadzeraForm : Form
    {
        public dodajMenadzeraForm()
        {
            InitializeComponent();
        }


        private void ProslediMenadzera_Click(object sender, EventArgs e)
        {

            //if (!ValidacijaKontrola())
            //    return;

            MenadzerDTO m = new MenadzerDTO();

            m.MaticniBroj = long.Parse(textBox1.Text);
            m.Ime = textBox2.Text;
            m.Prezime = textBox3.Text;
            m.Pol = null;
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                m.Pol = char.Parse(comboBox1.Text);
            }
            m.DatumRodjenja = datumRodj.Value;

            DTOManager.dodajMenadzera(m);

            MessageBox.Show("Uspesno dodat novi menadzer!");
            this.Close();
        }
    }
}
