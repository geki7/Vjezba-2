using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace Autobusni_Kolodvor_2
{
    public partial class Form1 : Form
    {
        public List<Linija> linije = new List<Linija>();
        public AutobusniKolodvor autobusniKoldovor = new AutobusniKolodvor();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {
            linije = autobusniKoldovor.DohvatiLinije();
            autobuslinijaDgv.DataSource = null;
            autobuslinijaDgv.DataSource = linije; 
        }

        private void pronadiBtn_Click(object sender, EventArgs e)
        {
            List<Linija> popisLinija = new List<Linija>();
            foreach(Linija item in linije)
            {
                if(odredisteTxb.Text == item.Odrediste)
                {
                    popisLinija.Add(item);
                }
            }
            autobuslinijaDgv.DataSource = popisLinija;
        }

        private void osvjeziBtn_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void kupiKartuBtn_Click(object sender, EventArgs e)
        {
            kupiKartu novaForma = new kupiKartu(autobuslinijaDgv.CurrentRow.DataBoundItem as Linija);
            novaForma.ShowDialog();
            Osvjezi();
        }
    }
}
