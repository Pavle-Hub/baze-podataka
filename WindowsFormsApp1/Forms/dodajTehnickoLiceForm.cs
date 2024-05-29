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
            try
            {
                ISession s = DataLayer.GetSession();

                long maticniBroj = long.Parse(textBox1.Text);
                string ime = textBox2.Text;
                string prezime = textBox3.Text;
                char? pol = null;
                if (!string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    pol = char.Parse(comboBox1.Text);
                }

                string strucnaSprema = textBox6.Text;
                string oblast = textBox5.Text;
                DateTime datumRodjenja = dateTimePicker1.Value;

                TehnickoLice t = new TehnickoLice();
                    
                t.MaticniBroj = maticniBroj;
                t.Ime = ime;
                t.Prezime = prezime;
                t.Pol = pol;
                t.StrucnaSprema = strucnaSprema;
                t.Oblast = oblast;
                t.DatumRodjenja = datumRodjenja;
              

                s.Save(t);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno dodato novo tehnicko lice!");

                this.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("oh no\n" + ec.Message);
            }
        }
    }
}
