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
    public partial class dodajObjekatForm : Form
    {
        public dodajObjekatForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjekatDTO objekat = new ObjekatDTO();
            objekat.Adresa = textBox1.Text;
            objekat.Tip = textBox2.Text;
            objekat.Povrsina = float.Parse(textBox3.Text);

            DTOManager.dodajObjekat(objekat);
            MessageBox.Show("Uspesno dodat novi objekat!");
            this.Close();
        }
    }
}
