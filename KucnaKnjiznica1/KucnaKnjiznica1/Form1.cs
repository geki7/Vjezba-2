using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;

namespace KucnaKnjiznica1
{
    public partial class Knjige : Form
    {
        List<Knjiga> knjigaList = new List<Knjiga>();
        Knjiznica knjiznica = new Knjiznica();
        public Knjige()
        {
            InitializeComponent();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            osvjezi();
            osvjeziPosudbu();
        }
        private void osvjezi()
        {
            knjigaList = knjiznica.DohvatiDostupneKnjige();
            dostupneKnjigeDgv.DataSource = null;
            dostupneKnjigeDgv.DataSource = knjigaList;
        }
        private void osvjeziPosudbu()
        {
            knjigaList = knjiznica.DohvatiKnjigeNaPosudbi();
            posudbaDgv.DataSource = null;
            posudbaDgv.DataSource = knjigaList;
        }

        private void posudiKnjiguBtn_Click(object sender, EventArgs e)
        {
            Knjiga odabranaKnjiga = dostupneKnjigeDgv.CurrentRow.DataBoundItem as Knjiga;
            string osoba = "";
            using(Form2 novaForma = new Form2(odabranaKnjiga))
            {
                DialogResult rezultat = novaForma.ShowDialog();
                if(rezultat == DialogResult.OK)
                {
                    osoba = novaForma.osobakojojsamPosudio;
                }
                knjiznica.PosudiKnjigu(odabranaKnjiga, osoba);
                osvjezi();
                osvjeziPosudbu();
            }
        }

        private void vratiKnjiguBtn_Click(object sender, EventArgs e)
        {
            Knjiga odabir = dostupneKnjigeDgv.CurrentRow.DataBoundItem as Knjiga;
            knjiznica.VratiKnjigu(odabir);
            osvjezi();
            osvjeziPosudbu();
        }
    }
}
