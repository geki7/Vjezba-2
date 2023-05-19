using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace AutobusniKolodvorPopis
{
    public partial class PopisAutobusnihLinija : Form
    {
        public Linija OdabranaLinija { get; set; }
        public PopisAutobusnihLinija()
        {
            InitializeComponent();
        }

        private void popisLinijaDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
        private void PopisAutobusnihLinija_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {
            List<Linija> linije = AutobusniKolodvor.DohvatiLinije();
            popisLinijaDgv.DataSource = null;
            popisLinijaDgv.DataSource = linije;
        }

        private void izlazBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void odaberiBtn_Click(object sender, EventArgs e)
        {
            this.OdabranaLinija = popisLinijaDgv.CurrentRow.DataBoundItem as Linija;
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
