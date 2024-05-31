using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Forms
{
    public partial class dodajAlarmniSistemForm : Form
    {
        public dodajAlarmniSistemForm()
        {
            InitializeComponent();
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox7.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                textBox3.Enabled = true;
                textBox4.Enabled = true;

                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
            }
            else
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;

                textBox5.Enabled = true;
                textBox6.Enabled = true;

                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox7.Enabled = false;
            }
            else
            {
                textBox5.Enabled = false;
                textBox6.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;

                textBox7.Enabled = true;

                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
            else
            {
                textBox7.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Izaberite kog tipa ce biti alarmni sistem!");
                return;
            }
            if (checkBox1.Checked == true)
            {
                UltrazvucniSenzorDTO uzs = new UltrazvucniSenzorDTO();
                uzs.Proizvodjac = textBox1.Text;
                uzs.GodinaProizvodnje = Int32.Parse(textBox2.Text);
                uzs.DatumInstalacije = dateTimePicker1.Value;
                uzs.MinFrekvencija = Int32.Parse(textBox3.Text);
                uzs.MaxFrekvencija = Int32.Parse(textBox4.Text);

                DTOManager.dodajUltrazvucniSenzor(uzs);
            }
            else if (checkBox2.Checked == true)
            {
                DetektorToplotnogOdrazaDTO dto = new DetektorToplotnogOdrazaDTO();
                dto.Proizvodjac = textBox1.Text;
                dto.GodinaProizvodnje = Int32.Parse(textBox2.Text);
                dto.DatumInstalacije = dateTimePicker1.Value;
                dto.HorRezolucija = Int32.Parse(textBox5.Text);
                dto.VerRezolucija = Int32.Parse(textBox6.Text);

                DTOManager.dodajToplotniOdraz(dto);
            }
            else if (checkBox3.Checked == true)
            {
                DetektorPokretaDTO dp = new DetektorPokretaDTO();
                dp.Proizvodjac = textBox1.Text;
                dp.GodinaProizvodnje = Int32.Parse(textBox2.Text);
                dp.DatumInstalacije = dateTimePicker1.Value;
                dp.Osetljivost = Int32.Parse(textBox7.Text);

                DTOManager.dodajDetektorPokreta(dp);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
