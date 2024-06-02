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

        private int previousSelectedIndex = -1;

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
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " - " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " - " + a.Obj.Id + " - " + a.HorRezolucija + " - " + a.VerRezolucija);
                else
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " - " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " -  null" + " - " + a.HorRezolucija + " - " + a.VerRezolucija);
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
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " - " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " - " + a.Obj.Id + " - " + a.Osetljivost);
                else
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " - " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " -  null" + " - " + a.Osetljivost);
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
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " - " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " - " + a.Obj.Id + " - " + a.MinFrekvencija + " - " + a.MaxFrekvencija);
                else
                    listBox1.Items.Add(a.Id + " - " + a.Proizvodjac + " - " + a.GodinaProizvodnje + " - " + a.DatumInstalacije.ToString().Split(' ')[0] + " -  null" + " - " + a.MinFrekvencija + " - " + a.MaxFrekvencija);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite alarm cije podatke zelite da vidite!");
                return;
            }
            int idAlarma = Int32.Parse((listBox1.SelectedItem).ToString().Split(' ')[0]);
            AlarmniSistemDTO alsis = DTOManager.vratiAlarmniSistem(idAlarma);
            LicaIObjektiZaAlarmForm frm = new LicaIObjektiZaAlarmForm(alsis);
            DialogResult dlg = frm.ShowDialog();
        }

        private void dodajAlarmDugme_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems.Count == 0)
            {
                IzborZaAlarmIliOdrzavanjeForm frm = new IzborZaAlarmIliOdrzavanjeForm();
                DialogResult dlg = frm.ShowDialog();
            }
            else if (listBox1.SelectedItems.Count != 0)
            {
                int idAlarma = Convert.ToInt32((listBox1.SelectedItem).ToString().Split(' ')[0]);
                AlarmniSistemDTO alarm = DTOManager.vratiAlarmniSistem(idAlarma);
                IzborZaAlarmIliOdrzavanjeForm frm = new IzborZaAlarmIliOdrzavanjeForm(alarm);
                DialogResult dlg = frm.ShowDialog();
            }
            PopuniListuAlarmniSistem();
        }

        private void izmeniAlarmDugme_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Alarm koji zelite da izmenite");
                return;
            }
            int idAlarma = Convert.ToInt32((listBox1.SelectedItem).ToString().Split(' ')[0]);
            var alarm = DTOManager.vratiAlarmniSistemZaIzmenu(idAlarma);
            if (alarm is DetektorPokretaDTO dt)
            {
                IzmeniDetektorPokretaForm frm = new IzmeniDetektorPokretaForm(dt);
                DialogResult dlg = frm.ShowDialog();
            }
            else if (alarm is DetektorToplotnogOdrazaDTO dto)
            {
                IzmeniDetektorToploteForm frm = new IzmeniDetektorToploteForm(dto);
                DialogResult dlg = frm.ShowDialog();
            }
            else if (alarm is UltrazvucniSenzorDTO us)
            {
                IzmeniUltrazvucniSenzorForm frm = new IzmeniUltrazvucniSenzorForm(us);
                DialogResult dlg = frm.ShowDialog();
            }
            PopuniListuAlarmniSistem();
        }

        private void obrisiAlarmDugme_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite alarm koji zelite da obrisete!");
                return;
            }

            int idalarma = Convert.ToInt32((listBox1.SelectedItem).ToString().Split(' ')[0]);
            string poruka = "Da li zelite da obrisete izabrani alarm?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAlarm(idalarma);
                MessageBox.Show("Uspesno obrisan alarm!");
                this.PopuniListuAlarmniSistem();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == previousSelectedIndex)
            {
                listBox1.ClearSelected();
                previousSelectedIndex = -1;
            }
            else
            {
                previousSelectedIndex = listBox1.SelectedIndex;
            }
        }
    }
}
