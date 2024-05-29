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
            try
            {

                ISession s = DataLayer.GetSession();
                int redniBrojEkipe;

                long maticniBroj = long.Parse(textBox1.Text);
                string ime = textBox2.Text;
                string prezime = textBox3.Text;
                char pol = char.Parse(comboBox1.Text);

              
                DateTime datumRodjenja = datumRodj.Value;


                Menadzer f = new Menadzer();
                f.MaticniBroj = maticniBroj;
                f.Ime = ime;
                f.Prezime = prezime;
                f.Pol = pol;
               
                f.DatumRodjenja = datumRodjenja;

               

                s.Save(f);

                s.Flush();

                s.Close();

                MessageBox.Show("Uspesno dodat nov menadzer!");

                this.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("oh no\n" + ec.Message);
            }
        }
    }
}
