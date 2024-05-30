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
    public partial class SmenaForm : Form
    {
        public SmenaForm()
        {
            InitializeComponent();
        }

        private void PopuniListuSmena()
        {
            listBoxSmena.Items.Clear();
            listBoxSmena.Items.Add("Loading...");

            List<SmenaDTO> lista = DTOManager.PopuniSmenu();

            listBoxSmena.Items.Clear();

            foreach (SmenaDTO a in lista)
            {
                listBoxSmena.Items.Add(a.Id + " - " + a.VremePocetka.ToString("MMM dd yyyy,hh:mm:ss") + " " + a.VremeKraja.ToString("MMM dd yyyy, hh: mm:ss") + " - " + a.EkipaSmene.RedniBroj);
            }
        }

        private void dodajSmenu_Click(object sender, EventArgs e)
        {
            dodajSmenuForm frm = new dodajSmenuForm();
            DialogResult dlg = frm.ShowDialog();

            PopuniListuSmena();
        }

        private void SmenaForm_Load(object sender, EventArgs e)
        {
            PopuniListuSmena();
        }
    }
}
