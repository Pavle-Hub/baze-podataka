using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entiteti;

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
                if(a.EkipaSmene != null)
                listBoxSmena.Items.Add(a.Id + " - " + a.VremePocetka.ToString("dd MMM yyyy") + " " + a.VremeKraja.ToString("dd MMM yyyy") + " - " + a.EkipaSmene.RedniBroj);
                else
                    listBoxSmena.Items.Add(a.Id + " - " + a.VremePocetka.ToString("dd MMM yyyy") + " " + a.VremeKraja.ToString("dd MMM yyyy") + " - " + "Nema ekipe");
            }
        }

        private void listBoxSmena_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxSmena.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas da selektujete smenu.");
                return;
            }

            int smenaId = int.Parse(listBoxSmena.SelectedItem.ToString().Split(' ')[0]);

            SmenaDTO smena = DTOManager.VratiPodatkeOSmeni(smenaId);
           // smena.ObjektiZaSmenu = DTOManager.VratiListuObjekataSmene(smenaId);

            if (smena == null)
            {
                MessageBox.Show("Nisu pronađeni podaci za selektovanu smenu.");
                return;
            }

            ObjektiZaSmenuForm formSmenaDetalji = new ObjektiZaSmenuForm(smena);
            formSmenaDetalji.ShowDialog();

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

        private void izbrisiSmenu_Click(object sender, EventArgs e)
        {
            if (listBoxSmena.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smenu koju zelite da obrisete!");
                return;
            }
            int smenaId = int.Parse(listBoxSmena.SelectedItem.ToString().Split(' ')[0]);
            string poruka = "Da li zelite da obrisete izabranu smenu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiSmenu(smenaId);
                MessageBox.Show("Uspesno obrisana smena!");
                this.PopuniListuSmena();
            }


        }

        private void izmeniSmenu_Click(object sender, EventArgs e)
        {
            if (listBoxSmena.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite smenu koju zelite da izmenite!");
                return;
            }
            int smenaId = int.Parse(listBoxSmena.SelectedItem.ToString().Split(' ')[0]);
            SmenaDTO smena = DTOManager.VratiPodatkeOSmeni(smenaId);
            IzmeniSmenuForm frm = new IzmeniSmenuForm(smena);
            DialogResult dlg = frm.ShowDialog();

            PopuniListuSmena();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
