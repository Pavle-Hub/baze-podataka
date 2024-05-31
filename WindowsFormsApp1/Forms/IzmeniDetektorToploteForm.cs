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
    public partial class IzmeniDetektorToploteForm : Form
    {
        DetektorToplotnogOdrazaDTO dto;
        public IzmeniDetektorToploteForm()
        {
            InitializeComponent();
        }
        public IzmeniDetektorToploteForm(DetektorToplotnogOdrazaDTO dt)
        {
            InitializeComponent();
            dto = dt;
            popuni();
        }

        private void popuni()
        {
            textBox1.Text = dto.Proizvodjac;
            textBox2.Text = dto.GodinaProizvodnje.ToString();
            textBox3.Text = dto.HorRezolucija.ToString();
            textBox4.Text = dto.VerRezolucija.ToString();
            dateTimePicker1.Value = dto.DatumInstalacije;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto.Proizvodjac = textBox1.Text;
            dto.GodinaProizvodnje = Int32.Parse(textBox2.Text);
            dto.HorRezolucija = Int32.Parse(textBox3.Text);
            dto.VerRezolucija = Int32.Parse(textBox4.Text);
            dto.DatumInstalacije = dateTimePicker1.Value;

            DTOManager.azurirajDetektorToplote(dto);

            MessageBox.Show("Uspesno azuriran detektor toplote!");
            this.Close();
        }
    }
}
