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
    public partial class dodajOdrzavanjeAlarmaForm : Form
    {
        AlarmniSistemDTO alarm;
        public dodajOdrzavanjeAlarmaForm()
        {
            InitializeComponent();
        }
        public dodajOdrzavanjeAlarmaForm(AlarmniSistemDTO al)
        {
            InitializeComponent();
            alarm = al;
        }

        private void proslediDugme_Click(object sender, EventArgs e)
        {
            OdrzavaDTO odrzavanje = new OdrzavaDTO();
            odrzavanje.DatumOd = dateTimePicker1.Value;
            odrzavanje.DatumDo = dateTimePicker2.Value;
            long maticniTehnickog = Int64.Parse(textBox1.Text);
            DTOManager.dodajOdrzavanje(odrzavanje, alarm, maticniTehnickog);


        }
    }
}
