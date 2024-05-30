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
    public partial class RegionalniCentarForm : Form
    {
        public RegionalniCentarForm()
        {
            InitializeComponent();
            
        }
        private void PopuniListuRegionalnihCentara()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Loading...");

            List<RegionalniCentarDTO> lista = DTOManager.PopuniRegionalneCentre();

            listBox1.Items.Clear();

            foreach (RegionalniCentarDTO rc in lista)
            {
                string brojeviTelefona = rc.BrojeviTelefona != null && rc.BrojeviTelefona.Count > 0
                    ? string.Join(", ", rc.BrojeviTelefona)
                    : "N/A";
                string imenaGradova = rc.ImenaGradova != null && rc.ImenaGradova.Count > 0
                    ? string.Join(", ", rc.ImenaGradova)
                    : "N/A";
                string regOznakeVozila = rc.RegOznakaVozila != null && rc.RegOznakaVozila.Count > 0
                    ? string.Join(", ", rc.RegOznakaVozila)
                    : "N/A";

                listBox1.Items.Add(
                   rc.Adresa + " - " + rc.ImeMenadzera + " - " +
                   brojeviTelefona + " - " + imenaGradova + " - " + regOznakeVozila
                );
            }
        }


        private void RegionalniCentarForm_Load(object sender, EventArgs e)
        {
            PopuniListuRegionalnihCentara();
        }
    }
}
