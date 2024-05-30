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



        private void PopuniListuAlarmniSistem()
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
            listBox1.Items.Clear();
            listBox1.Items.Add("Loading...");

            List<DetektorToplotnogOdrazaDTO> lista = DTOManager.PopuniToplotniAlarmniSistem();

            listBox1.Items.Clear();

            foreach (DetektorToplotnogOdrazaDTO a in lista)
            {
                if (a.Obj != null)
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " - " + a.Obj.Id + " - " + a.HorRezolucija + " - " + a.VerRezolucija);
                else
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " -  null" + " - " + a.HorRezolucija + " - " + a.VerRezolucija);
            }
        }

        private void AlarmiForm_Load(object sender, EventArgs e)
        {
            PopuniListuAlarmniSistem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Loading...");

            List<DetektorPokretaDTO> lista = DTOManager.PopuniPokretniAlarmniSistem();

            listBox1.Items.Clear();

            foreach (DetektorPokretaDTO a in lista)
            {
                if (a.Obj != null)
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " - " + a.Obj.Id + " - " + a.Osetljivost);
                else
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " -  null" + " - " + a.Osetljivost);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Loading...");

            List<UltrazvucniSenzorDTO> lista = DTOManager.PopuniZvucniAlarmniSistem();

            listBox1.Items.Clear();

            foreach (UltrazvucniSenzorDTO a in lista)
            {
                if (a.Obj != null)
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " - " + a.Obj.Id + " - " + a.MinFrekvencija + " - " + a.MaxFrekvencija);
                else
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " -  null" + " - " + a.MinFrekvencija + " - " + a.MaxFrekvencija);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
