using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace ProvedbaiSortiranjeTransakcija
{
    public partial class Form1 : Form
    {
        public Transakcija dovivenaTransakcija = new Transakcija();
        List<Transakcija> transakcijaLista = new List<Transakcija>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsvjeziListu();
        }
        private void OsvjeziListu()
        {
            transakcijaLista = Banka.DohvatiPopisTransakcija();
            popistransDgv.DataSource = null;
            popistransDgv.DataSource = transakcijaLista;
        }

        private void stornirajBtn_Click(object sender, EventArgs e)
        {
            Transakcija odabranaTransakcija = popistransDgv.CurrentRow.DataBoundItem as Transakcija;
            Banka.StornirajTransakciju(odabranaTransakcija);
            OsvjeziListu();
        }

        private void provediBtn_Click(object sender, EventArgs e)
        {
            using(Form2 novaForma = new Form2())
            {
                DialogResult rezultat = novaForma.ShowDialog();
                dovivenaTransakcija = novaForma.provedenaTranskacija;
                Banka.ProvediTransakciju(dovivenaTransakcija.Platitelj, dovivenaTransakcija.Primatelj, dovivenaTransakcija.Iznos);
                OsvjeziListu();
            }    
        }
    }
}
