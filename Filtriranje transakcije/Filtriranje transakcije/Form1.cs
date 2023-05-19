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

namespace Filtriranje_transakcije
{
    public partial class Form1 : Form
    {
        public List<Racun> racuni;
        public List<Transakcija> popisTransakcija;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
            OsvjeziCombo();
            sveRbn.Checked = true;
        }
        private void Osvjezi()
        {
            popisTransakcija = Banka.DohvatiPopisTransakcija();
            racuniListaDgv.DataSource = null;
            racuniListaDgv.DataSource = popisTransakcija;
        }
        private void OsvjeziCombo()
        {
            racuni = Banka.DohvatiPopisRacuna();
            racunCbx.DataSource = null;
            racunCbx.DataSource= racuni;
        }
        private void racunCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ocistiBtn_Click(object sender, EventArgs e)
        {
            racunCbx.SelectedIndex = 0;
            uplateRbn.Checked = false;
            isplateRbn.Checked = false;
            sveRbn.Checked = true;
            Osvjezi();
        }

        private void filtrirajBtn_Click(object sender, EventArgs e)
        {
            List<Transakcija> popistransakcijeFiltrirano = new List<Transakcija>();
            Racun oznaceno = racunCbx.SelectedItem as Racun;
            foreach(Transakcija t in popisTransakcija)
            {
                if(oznaceno.IBAN == t.Platitelj.IBAN && sveRbn.Checked || oznaceno.IBAN == t.Primatelj.IBAN && sveRbn.Checked)
                {
                    popistransakcijeFiltrirano.Add(t);
                }
                else if(oznaceno.IBAN == t.Platitelj.IBAN && uplateRbn.Checked || oznaceno.IBAN == t.Primatelj.IBAN && uplateRbn.Checked)
                {
                    popistransakcijeFiltrirano = DohvatiUplate(oznaceno);
                }
                else if(oznaceno.IBAN == t.Primatelj.IBAN && isplateRbn.Checked || oznaceno.IBAN == t.Platitelj.IBAN && isplateRbn.Checked)
                {
                    popistransakcijeFiltrirano = DohvatiIsplate(oznaceno);
                }
            }
            osvjeziFiltrirano(popistransakcijeFiltrirano);
        }
        private List<Transakcija> DohvatiIsplate(Racun oznaceno)
        {
            List<Transakcija> popisIsplata = new List<Transakcija>();
            popisIsplata = oznaceno.DohvatiIsplate();
            return popisIsplata;
        }
        private List<Transakcija> DohvatiUplate(Racun oznaceno)
        {
            List <Transakcija> popisUplata = new List<Transakcija>();
            popisUplata = oznaceno.DohvatiUplate();
            return popisUplata;
        }
        private void osvjeziFiltrirano(List<Transakcija> transakcijeFiltrirano)
        {
            racuniListaDgv.DataSource = null;
            racuniListaDgv.DataSource = transakcijeFiltrirano;
        }

        private void detaljiRacunabtn_Click(object sender, EventArgs e)
        {
            Transakcija trenutniRed = new Transakcija();
            trenutniRed = racuniListaDgv.CurrentRow.DataBoundItem as Transakcija;
            Detalji forma = new Detalji(trenutniRed);
            forma.ShowDialog();
        }
    }
}
