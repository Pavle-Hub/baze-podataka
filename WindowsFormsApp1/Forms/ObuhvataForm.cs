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
    public partial class ObuhvataForm : Form
    {
        public ObuhvataForm()
        {
            InitializeComponent();
            PopuniListViewObuhvatanjima();
        }

        private void PopuniListViewObuhvatanjima()
        {
            listView1.Items.Clear();

            List<ObuhvataDTO> obuhvatanja = DTOManager.VratiSvaObuhvatanja();

            foreach (ObuhvataDTO obuhvatanje in obuhvatanja)
            {
                ListViewItem item = new ListViewItem(obuhvatanje.Id.ToString());
                item.SubItems.Add(obuhvatanje.Smena.Id.ToString());
                item.SubItems.Add(obuhvatanje.Objekat.Id.ToString());

                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObuhvataForm_Load(object sender, EventArgs e)
        {
            PopuniListViewObuhvatanjima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdSmene = int.Parse(textBox1.Text);
            int idObjekta = int.Parse(textBox2.Text);

            DTOManager.DodajObuhvatanje(IdSmene, idObjekta);
            PopuniListViewObuhvatanjima();
        }
    }
}
