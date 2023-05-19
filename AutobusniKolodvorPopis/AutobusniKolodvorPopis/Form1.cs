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
    public partial class Form1 : Form
    {
        public Linija OdabranaLinija { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void odaberiBtn_Click(object sender, EventArgs e)
        {
            using(PopisAutobusnihLinija form = new PopisAutobusnihLinija())
            {
                var rezultat = form.ShowDialog();
                if(rezultat == DialogResult.OK)
                {
                    OdabranaLinija = form.OdabranaLinija;
                    this.polazisteTxtB.Text = OdabranaLinija.Polaziste;
                    this.odredisteTxtb.Text = OdabranaLinija.Odrediste;
                    this.udaljenostTxb.Text = OdabranaLinija.Udaljenost.ToString();
                    this.autoprijevoznikTxtB.Text = OdabranaLinija.Autoprijevoznik;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VrstaKarte vrstaKarte = this.regularnaRb.Checked ? VrstaKarte.Regularna : VrstaKarte.Studentska;
            bool povrtnaKarta = this.povratnaCb.Checked;
            bool prtljaga = this.prtljagaCb.Checked;
            Karta novaKarta = new Karta(OdabranaLinija, vrstaKarte, povrtnaKarta, prtljaga);
            this.cijenaTxb.Text = novaKarta.Cijena.ToString();
            this.brojkarteTxb.Text = novaKarta.BrojKarte.ToString();
        }
    }
}
