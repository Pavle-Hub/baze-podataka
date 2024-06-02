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
    public partial class dodajEkipuForm : Form
    {
        public dodajEkipuForm()
        {
            InitializeComponent();
            PopuniComboBoxove();
        }

        private void PopuniComboBoxove()
        {
            var dostupniClanovi = DTOManager.VratiDostupneClanove();

            comboBox1.DataSource = new BindingSource(dostupniClanovi, null);
           
            comboBox2.DataSource = new BindingSource(dostupniClanovi, null);

            comboBox3.DataSource = new BindingSource(dostupniClanovi, null);

            comboBox4.DataSource = new BindingSource(dostupniClanovi, null);
        }

        private void dodajEkipuDugme_Click(object sender, EventArgs e)
        {
            long[] maticniBrojeviClanova = new long[4];
            maticniBrojeviClanova[0] = (long)comboBox1.SelectedValue;
            maticniBrojeviClanova[1] = (long)comboBox2.SelectedValue;
            maticniBrojeviClanova[2] = (long)comboBox3.SelectedValue;
            maticniBrojeviClanova[3] = (long)comboBox4.SelectedValue;

            DTOManager.DodajNovuEkipu(maticniBrojeviClanova);

            MessageBox.Show("Dodata nova ekipa!");
            PopuniComboBoxove();
            this.Close();
        }
    }
}
