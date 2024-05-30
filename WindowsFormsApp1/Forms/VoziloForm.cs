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
    public partial class VoziloForm : Form
    {
        public VoziloForm()
        {
            InitializeComponent();
        }



        private void dodajVozilo_Click(object sender, EventArgs e)
        {
            dodajVozilo frm = new dodajVozilo();
            DialogResult dlg = frm.ShowDialog();

            PopuniListuVozila();

        }

        private void PopuniListuVozila()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Loading...");

            List<VoziloDTO> lista = DTOManager.PopuniVozila();

            listBox1.Items.Clear();

            foreach (VoziloDTO v in lista)
            {
                listBox1.Items.Add(
                   v.RegOznaka + " - " + v.Boja + " - " + (v.Tip ?? "N/A") + " - " +
                   (v.Model ?? "N/A") + " - " + (v.Proizvodjac ?? "N/A") + " - " +
                   v.DatumOd.ToString().Split(' ')[0] + " - " + v.DatumDo.ToString().Split(' ')[0]
               );
            }
        }


        private void VoziloForm_Load(object sender, EventArgs e)
        {
            PopuniListuVozila();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
