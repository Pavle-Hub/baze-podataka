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
    public partial class EkipaForm : Form
    {
        public EkipaForm()
        {
            InitializeComponent();
            popuniListuEkipama();
        }

        private void popuniListuEkipama()
        {
            List<EkipaDTO> listaEkipa = DTOManager.VratiSveEkipeSaClanovima();
            listView1.Items.Clear();

            foreach (var ekipa in listaEkipa)
            {
                var clan1 = new ListViewItem.ListViewSubItem();
                var clan2 = new ListViewItem.ListViewSubItem();
                var clan3 = new ListViewItem.ListViewSubItem();
                var clan4 = new ListViewItem.ListViewSubItem();

                if (ekipa.clanoviEkipe.Count > 0)
                {
                    clan1.Text = $"{ekipa.clanoviEkipe[0].Ime} {ekipa.clanoviEkipe[0].Prezime}";
                    if (ekipa.Vodja != null && ekipa.clanoviEkipe[0].MaticniBroj == ekipa.Vodja.MaticniBroj)
                    {
                        clan1.BackColor = Color.Yellow;
                        clan1.Font = new Font(listView1.Font, FontStyle.Bold);
                    }
                }
                if (ekipa.clanoviEkipe.Count > 1)
                {
                    clan2.Text = $"{ekipa.clanoviEkipe[1].Ime} {ekipa.clanoviEkipe[1].Prezime}";
                    if (ekipa.Vodja != null && ekipa.clanoviEkipe[1].MaticniBroj == ekipa.Vodja.MaticniBroj)
                    {
                        clan2.BackColor = Color.Yellow;
                        clan2.Font = new Font(listView1.Font, FontStyle.Bold);
                    }
                }
                if (ekipa.clanoviEkipe.Count > 2)
                {
                    clan3.Text = $"{ekipa.clanoviEkipe[2].Ime} {ekipa.clanoviEkipe[2].Prezime}";
                    if (ekipa.Vodja != null && ekipa.clanoviEkipe[2].MaticniBroj == ekipa.Vodja.MaticniBroj)
                    {
                        clan3.BackColor = Color.Yellow;
                        clan3.Font = new Font(listView1.Font, FontStyle.Bold);
                    }
                }
                if (ekipa.clanoviEkipe.Count > 3)
                {
                    clan4.Text = $"{ekipa.clanoviEkipe[3].Ime} {ekipa.clanoviEkipe[3].Prezime}";
                    if (ekipa.Vodja != null && ekipa.clanoviEkipe[3].MaticniBroj == ekipa.Vodja.MaticniBroj)
                    {
                        clan4.BackColor = Color.Yellow;
                        clan4.Font = new Font(listView1.Font, FontStyle.Bold);
                    }
                }
                ListViewItem item = new ListViewItem(ekipa.RedniBroj.ToString());
                item.UseItemStyleForSubItems = false;
                item.SubItems.Add(clan1);
                item.SubItems.Add(clan2);
                item.SubItems.Add(clan3);
                item.SubItems.Add(clan4);


                listView1.Items.Add(item);
            }
        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajDugme_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                dodajEkipuForm frm = new dodajEkipuForm();
                DialogResult dlg = frm.ShowDialog();
                popuniListuEkipama();
            }
            else
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int id = Int32.Parse(selectedItem.Text);
                EkipaDTO ekipa = new EkipaDTO();
                ekipa = DTOManager.vratiEkipu(id);
                dodajVodjuForm frm = new dodajVodjuForm(ekipa);
                DialogResult dlg = frm.ShowDialog();
                popuniListuEkipama();
            }

        }

        private void obrisiDugme_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int ekipaId = int.Parse(selectedItem.Text);
                DTOManager.ObrisiEkipu(ekipaId);
                popuniListuEkipama();
                MessageBox.Show("Uspesno obrisan!");
            }
            else
            {
                MessageBox.Show("Nijedan red nije selektovan.");
            }
        }

        private void nazadDugme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
