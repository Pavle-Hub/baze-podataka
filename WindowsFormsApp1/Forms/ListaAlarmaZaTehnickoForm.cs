using NHibernate.SqlCommand;
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
    public partial class ListaAlarmaZaTehnickoForm : Form
    {
        TehnickoLiceDTO lice = new TehnickoLiceDTO();
        public ListaAlarmaZaTehnickoForm()
        {
            InitializeComponent();
        }

        public ListaAlarmaZaTehnickoForm(TehnickoLiceDTO l)
        {
            InitializeComponent();
            lice = l;
            popuniListuAlarma(); 
        }

        public void popuniListuAlarma()
        {
            lice.OdrzavaAS = DTOManager.vratiListuAlarma(lice.MaticniBroj) ;
            foreach (AlarmniSistemDTO al in lice.OdrzavaAS)
            {
                ListViewItem item = new ListViewItem(new string[] { al.Id.ToString(), al.Proizvodjac, al.GodinaProizvodnje.ToString() });
                this.listView1.Items.Add(item);
            }
        }

    }
}
