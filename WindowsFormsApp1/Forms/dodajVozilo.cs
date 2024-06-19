using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entiteti;

namespace WindowsFormsApp1.Forms
{
    public partial class dodajVozilo : Form
    {
        public bool Nov = true;

        public VoziloDTO voz;
        public dodajVozilo()
        {
            InitializeComponent();
            PopuniComboBoxove();
        }
        private void VoziloDialog_Load(object sender, EventArgs e)
        {
            PopuniComboBoxove();
        }

        private void PopuniComboBoxove()
        {
            try
            {
                List<int> ekipeBezVozila = DTOManager.VratiEkipeBezVozila();
                comboBoxEkipa1.Items.Clear();
                foreach (var ekipa in ekipeBezVozila)
                {
                    comboBoxEkipa1.Items.Add(ekipa);
                }

                List<int> regionalniCentri = DTOManager.VratiSveRegionalneCentre();
                comboBox2.Items.Clear();
                foreach (var centar in regionalniCentri)
                {
                    comboBox2.Items.Add(centar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom popunjavanja combo box-ova: {ex.Message}");
            }
        }



        private bool ValidacijaKontrolaVozilo()
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Registarska oznaka ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Boja ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Tip ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Model ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Proizvođač ne sme biti prazno polje.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (dateTimePicker1.Value > datumRodj.Value)
            {
                MessageBox.Show("DatumOd ne može biti posle DatumDo.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite regionalni centar.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (comboBoxEkipa1.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite ekipu.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            return true;
        }

        private void ProslediVozilo_Click(object sender, EventArgs e)
        {
            if (!ValidacijaKontrolaVozilo())
                return;

            VoziloDTO v = new VoziloDTO
            {
                RegOznaka = textBox4.Text,
                Boja = textBox5.Text,
                Tip = string.IsNullOrWhiteSpace(textBox3.Text) ? null : textBox3.Text,
                Model = string.IsNullOrWhiteSpace(textBox2.Text) ? null : textBox2.Text,
                Proizvodjac = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text,
                DatumOd = dateTimePicker1.Value,
                DatumDo = datumRodj.Value,
                RC = DTOManager.vratiRegCnt((int)comboBox2.SelectedItem),
                DuziGaEkipa = DTOManager.vratiEkipu((int)comboBoxEkipa1.SelectedItem)
            };

            DTOManager.dodajVozilo(v);

            MessageBox.Show("Uspesno dodato novo vozilo!");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajVozilo_Load(object sender, EventArgs e)
        {

        }
    }
}
