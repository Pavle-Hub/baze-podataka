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
    public partial class AlarmiForm : Form
    {
        public AlarmiForm()
        {
            InitializeComponent();
        }



        private void PopuniListuFizickoObezbedjenje()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Loading...");

            List<AlarmniSistemDTO> lista = DTOManager.PopuniAlarmniSistem();

            listBox1.Items.Clear();

            foreach (AlarmniSistemDTO a in lista)
            {
                if (a.Obj != null)
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " - " + a.Obj.Id);
                else
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " -  null");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AlarmiForm_Load(object sender, EventArgs e)
        {
            PopuniListuFizickoObezbedjenje();
        }
    }
}
