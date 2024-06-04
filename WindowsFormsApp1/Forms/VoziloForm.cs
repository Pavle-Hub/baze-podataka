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

        private void izbrisiVozilo_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da obrisete!");
                return;
            }

            string registarskaOznaka = listBox1.SelectedItem.ToString().Split(' ')[0];
            string poruka = "Da li zelite da obrisete izabrano vozilo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVozilo(registarskaOznaka);
                MessageBox.Show("Uspesno obrisano vozilo!");
                this.PopuniListuVozila();
            }
        }

        private void izmeniVozilo_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati vozilo koje zelite izmeniti!");
                return;
            }
            else
            {
                var regOznakaVozila = (listBox1.SelectedItem).ToString().Split(' ')[0];
                VoziloDTO vozilo = DTOManager.VratiVoziloPoRegistarskojOznaci(regOznakaVozila);
                if (vozilo == null)
                {
                    MessageBox.Show("Odabrano vozilo ne postoji u bazi podataka!");
                    return;
                }
                IzmeniVoziloForm frm = new IzmeniVoziloForm(vozilo);
                DialogResult dlg = frm.ShowDialog();
                this.PopuniListuVozila();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati vozilo!");
                return;
            }

            string selectedRegistarskaOznaka = (listBox1.SelectedItem).ToString().Split(' ')[0];
            VoziloDTO voziloDTO = DTOManager.VratiVoziloPoRegistarskojOznaci(selectedRegistarskaOznaka);

            if (voziloDTO == null)
            {
                MessageBox.Show("Odabrano vozilo ne postoji u bazi podataka!");
                return;
            }

            string message = $"Regionalni centar:\n" +
                             $"Id RC: {voziloDTO.RC.Id}\n" +
                             $"Adresa: {voziloDTO.RC.Adresa}\n\n" +
                             $"Broj ekipe: {voziloDTO.DuziGaEkipa.RedniBroj}";

            MessageBox.Show(message, "Informacije o vozilu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
