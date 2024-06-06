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
    public partial class IntervencijaForm : Form
    {
        public IntervencijaForm()
        {
            InitializeComponent();
            PopuniListViewIntervencijama();
        }

        private void PopuniListViewIntervencijama()
        {
            listView1.Items.Clear();

            try
            {
                List<IntervencijaDTO> sveIntervencije = DTOManager.VratiSveIntervencije();
                foreach (var intervencija in sveIntervencije)
                {
                    ListViewItem item = new ListViewItem(intervencija.Id.ToString());
                    item.SubItems.Add(intervencija.Vreme.ToShortTimeString());
                    item.SubItems.Add(intervencija.Datum.ToShortDateString());
                    item.SubItems.Add(intervencija.Tip);
                    item.SubItems.Add(intervencija.IntervencijaObjekta.Id.ToString());
                    item.SubItems.Add(intervencija.IntervencijaEkipe.RedniBroj.ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Greška pri popunjavanju ListView-a: {ex.Message}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IntervencijaForm_Load(object sender, EventArgs e)
        {
            PopuniListViewIntervencijama();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker2.Value;
            DateTime vreme = dateTimePicker1.Value;
            string tip = textBox3.Text;
            int redniBrojEkipe = int.Parse(textBox5.Text);
            int idObjekta = int.Parse(textBox4.Text);

            DTOManager.DodajIntervenciju(vreme, datum, tip, idObjekta, redniBrojEkipe);
            PopuniListViewIntervencijama();
        }
    }
}
