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
        }
        private void VoziloDialog_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            IList<RegionalniCentarDTO> regs = DTOManager.PopuniRegionalneCentre();
            IList<EkipaDTO> ekipe = DTOManager.PopuniEkipe();

            comboBox1.DataSource = regs;
            comboBox1.DisplayMember = "Adresa";  // Prikaži adresu u ComboBox-u
            comboBox1.ValueMember = "Id";        // Koristi Id kao vrednost

            comboBox2.DataSource = ekipe;
            comboBox2.DisplayMember = "RedniBroj"; // Prikaži redni broj ekipe u ComboBox-u
            comboBox2.ValueMember = "RedniBroj";   // Koristi RedniBroj kao vrednost

            if (!Nov)
            {
                textBox1.Enabled = false;
                textBox1.Text = voz.RegOznaka;
                textBox2.Text = voz.Proizvodjac;
                textBox3.Text = voz.Model;
                textBox4.Text = voz.Boja;
                textBox5.Text = voz.Tip;
                dateTimePicker1.Value = voz.DatumOd;
                datumRodj.Value = voz.DatumDo;

                // Postavljanje selektovanog Regionalnog Centra
                for (int i = 0; i < regs.Count; i++)
                {
                    if (regs[i].Id == voz.RC.Id)
                    {
                        comboBox1.SelectedIndex = i;
                        break;
                    }
                }

                // Postavljanje selektovane Ekipe
                for (int i = 0; i < ekipe.Count; i++)
                {
                    if (ekipe[i].RedniBroj == voz.DuziGaEkipa.RedniBroj)
                    {
                        comboBox2.SelectedIndex = i;
                        break;
                    }
                }
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
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite regionalni centar.",
                                "Obaveštenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return false;
            }

            if (comboBox2.SelectedIndex == -1)
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
                RC = (RegionalniCentarDTO)comboBox1.SelectedItem,
                DuziGaEkipa = (EkipaDTO)comboBox2.SelectedItem
            };

            DTOManager.dodajVozilo(v);

            MessageBox.Show("Uspesno dodato novo vozilo!");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
