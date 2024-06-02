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
    public partial class dodajObjekatAlarmuForm : Form
    {
        AlarmniSistemDTO alarm;
        public dodajObjekatAlarmuForm()
        {
            InitializeComponent();
        }
        public dodajObjekatAlarmuForm(AlarmniSistemDTO al)
        {
            InitializeComponent();
            alarm = al;
        }

        private void button1_Click(object sender, EventArgs e)
        {

                int idObjekta = Int32.Parse(textBox1.Text);
                if(DTOManager.dodajObjekatAlarmu(idObjekta, alarm))
                MessageBox.Show("Uspesno je dodat novi objekat odredjenom alarmu!");
                this.Close();
        }
    }
}
