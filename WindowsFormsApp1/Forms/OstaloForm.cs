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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            VoziloForm f = new VoziloForm();
            f.ShowDialog();

            Show();
        }
    }
}
