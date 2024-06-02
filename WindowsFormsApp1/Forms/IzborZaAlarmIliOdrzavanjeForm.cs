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
    public partial class IzborZaAlarmIliOdrzavanjeForm : Form
    {
        AlarmniSistemDTO alarm;
        public IzborZaAlarmIliOdrzavanjeForm()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        public IzborZaAlarmIliOdrzavanjeForm(AlarmniSistemDTO al)
        {
            InitializeComponent();
            alarm = al;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dodajAlarmniSistemForm frm = new dodajAlarmniSistemForm();
            DialogResult dlg = frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dodajOdrzavanjeAlarmaForm frm = new dodajOdrzavanjeAlarmaForm(alarm);
            DialogResult dlg = frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dodajObjekatAlarmuForm frm = new dodajObjekatAlarmuForm(alarm);
            DialogResult dlg = frm.ShowDialog();
        }
    }
}
