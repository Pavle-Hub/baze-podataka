using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1.Forms
{
    public partial class GradoviMenadzeraForm : Form
    {
        MenadzerDTO m = new MenadzerDTO();
        public GradoviMenadzeraForm()
        {
            InitializeComponent();
        }

        public GradoviMenadzeraForm(MenadzerDTO men)
        {
            InitializeComponent();
            m = men;
        }

        private void Popuni()
        {
            listBox1.Items.Clear();
            m.Gradovi = DTOManager.dodajMenadzeruGradove(m);
            foreach (string grad in m.Gradovi)
            {
                listBox1.Items.Add(grad);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajGradDugme_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DTOManager.dodajMenadzeruGrad(textBox1.Text, m);
                Popuni();
            }
            else
            {
                MessageBox.Show("Unesite naziv grada!");
            }
        }

        private void GradoviMenadzeraForm_Load(object sender, EventArgs e)
        {
            Popuni();
        }

        private void IzbrisiGradDugme_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite grad koji zelite da izbrisete");
            }
            else
            {
                DTOManager.obrisiMenadzeruGrad(listBox1.SelectedItem.ToString(), m);
                Popuni();
            }
        }
    }
}
