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
    public partial class IzmeniSmenuForm : Form
    {
        SmenaDTO smenaDTO;
        public IzmeniSmenuForm()
        {
            InitializeComponent();
        }
        public IzmeniSmenuForm(SmenaDTO s)
        {
            InitializeComponent();
            smenaDTO = s;
        }

        private void proslediSmenu_Click(object sender, EventArgs e)
        {
            //if (!ValidacijaKontrolaSmena())
                //return;
            int redniBrojEkipe;
            smenaDTO.VremePocetka = dateTimePicker1.Value;
            smenaDTO.VremeKraja = dateTimePicker2.Value;           
            if (textBox1.Text != "")
                redniBrojEkipe = int.Parse(textBox1.Text);
            else
                redniBrojEkipe = -1;

            DTOManager.azurirajSmenu(smenaDTO, redniBrojEkipe);

            MessageBox.Show("Uspesno azurirana semena!");
            this.Close();
        }
    }
}
