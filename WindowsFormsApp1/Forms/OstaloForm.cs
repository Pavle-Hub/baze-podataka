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
    public partial class OstaloForm : Form
    {
        public OstaloForm()
        {
            InitializeComponent();
        }

        private void prikaziEkipe_Click(object sender, EventArgs e)
        {
            EkipaForm frm = new EkipaForm();
            DialogResult dlg = frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VoziloForm frm = new VoziloForm();
            DialogResult dlg = frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SmenaForm frm = new SmenaForm();
            DialogResult dl = frm.ShowDialog();
        }

        private void OstaloForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegionalniCentarForm frm = new RegionalniCentarForm();
            DialogResult dlg = frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObjekatForm frm = new ObjekatForm();
            DialogResult dlg = frm.ShowDialog();
        }
    }
}
