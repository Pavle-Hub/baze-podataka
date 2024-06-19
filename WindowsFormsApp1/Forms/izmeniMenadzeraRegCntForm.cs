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
    public partial class izmeniMenadzeraRegCntForm : Form
    {
        public izmeniMenadzeraRegCntForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idRegCnt = int.Parse(textBox1.Text);
            long maticni = long.Parse(textBox2.Text);

            DTOManager.DodajMenadzeraZaCentar(idRegCnt, maticni);
            MessageBox.Show("Novi menadzer je uspešno dodat.");
            this.Close();
        }
    }
}
