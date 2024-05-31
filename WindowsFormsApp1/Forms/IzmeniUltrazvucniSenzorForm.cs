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
    public partial class IzmeniUltrazvucniSenzorForm : Form
    {
        UltrazvucniSenzorDTO ultra;
        public IzmeniUltrazvucniSenzorForm()
        {
            InitializeComponent();
        }
        public IzmeniUltrazvucniSenzorForm(UltrazvucniSenzorDTO uls)
        {
            InitializeComponent();
            ultra = uls;
            popuni();
        }

        private void popuni()
        {
            textBox1.Text = ultra.Proizvodjac;
            textBox2.Text = ultra.GodinaProizvodnje.ToString();
            textBox3.Text = ultra.MinFrekvencija.ToString();
            textBox4.Text = ultra.MaxFrekvencija.ToString();
            dateTimePicker1.Value = ultra.DatumInstalacije;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ultra.Proizvodjac = textBox1.Text;
            ultra.GodinaProizvodnje = Int32.Parse(textBox2.Text);
            ultra.MinFrekvencija = Int32.Parse(textBox3.Text);
            ultra.MaxFrekvencija = Int32.Parse(textBox4.Text);
            ultra.DatumInstalacije = dateTimePicker1.Value;

            DTOManager.azurirajUltrazvuk(ultra);

            MessageBox.Show("Uspesno azuriran ultrazvucni senzor!");
            this.Close();
        }
    }
}
