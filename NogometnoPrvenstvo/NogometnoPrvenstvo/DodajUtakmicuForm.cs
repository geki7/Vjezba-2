using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrvenstvoLib;

namespace NogometnoPrvenstvo
{
    public partial class DodajUtakmicuForm : Form
    {
        public DodajUtakmicuForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DodajUtakmicuForm_Load(object sender, EventArgs e)
        {
            domacinComboBox.DataSource = Repozitorij.PopisReprezentacija.ToList();
            gostComboBox.DataSource = Repozitorij.PopisReprezentacija.ToList();

            zgodiciDomacinTextBox.Text = "0";
            zgodiciGostTextBox.Text = "0";

            datumTextBox.Text = DateTime.Now.Date.ToShortDateString();
            zakazanaRadio.Checked = true;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            Reprezentacija domacin = domacinComboBox.SelectedItem as Reprezentacija;
            Reprezentacija gost = gostComboBox.SelectedItem as Reprezentacija;

            if(domacin == gost)
            {
                MessageBox.Show("Domaćin i gost ne mogu biti ista reprezentacija");
                return;
            }

            int brojZgoditakaDomacina = int.Parse(zgodiciDomacinTextBox.Text);
            int brojZgoditakaGost = int.Parse(zgodiciGostTextBox.Text);

            if(brojZgoditakaDomacina < 0 || brojZgoditakaGost < 0)
            {
                MessageBox.Show("Rezultat ne smije biti negativan");
                return;
            }

            DateTime datumUtakmice = DohvatimDatumUtakmice(datumTextBox.Text);
            StatusUtakmice status = DohvatiStatusUtakmice();

            Utakmica novaUtakmica = new Utakmica();
            novaUtakmica.Domacin = domacin;
            novaUtakmica.Gost = gost;
            novaUtakmica.BrojZgoditakaDomacin = brojZgoditakaDomacina;
            novaUtakmica.BrojZgoditakaGost = brojZgoditakaGost;
            novaUtakmica.Datum = datumUtakmice;
            novaUtakmica.Status = status;

            Repozitorij.Prvenstvo.DodajUtakmicu(novaUtakmica);
            Close();
        }

        private StatusUtakmice DohvatiStatusUtakmice()
        {
            if(zakazanaRadio.Checked == true)
            {
                return StatusUtakmice.Zakazana;
            }
            else
            {
                return StatusUtakmice.Odigrana;
            }
        }

        private DateTime DohvatimDatumUtakmice(string datum)
        {
            string[] polje = datum.Split('.');
            int dan = int.Parse(polje[0]);
            int mjesec = int.Parse(polje[1]);
            int godina = int.Parse(polje[2]);

            return new DateTime(godina, mjesec, dan);
        }
    }
}
