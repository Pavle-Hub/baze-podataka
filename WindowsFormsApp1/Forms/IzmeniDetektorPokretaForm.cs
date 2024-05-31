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
    public partial class IzmeniDetektorPokretaForm : Form
    {
        DetektorPokretaDTO detpo;
        public IzmeniDetektorPokretaForm()
        {
            InitializeComponent();
        }

        public IzmeniDetektorPokretaForm(DetektorPokretaDTO dp)
        {
            InitializeComponent();
            detpo = dp;
            popuni();
        }

        private void popuni()
        {
            textBox1.Text = detpo.Proizvodjac;
            textBox2.Text = detpo.GodinaProizvodnje.ToString();
            textBox3.Text = detpo.Osetljivost.ToString();
            dateTimePicker1.Value = detpo.DatumInstalacije;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detpo.Proizvodjac = textBox1.Text;
            detpo.GodinaProizvodnje = Int32.Parse(textBox2.Text);
            detpo.Osetljivost = Int32.Parse(textBox3.Text);
            detpo.DatumInstalacije = dateTimePicker1.Value;

            DTOManager.azurirajDetektorPokreta(detpo);

            MessageBox.Show("Uspesno azuriran detektor pokreta!");
            this.Close();
        }
    }
}
