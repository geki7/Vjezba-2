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
    public partial class IzmjeniUtakmicuForm : Form
    {
        private Utakmica postojecaUtakmica;

        public IzmjeniUtakmicuForm(Utakmica utakmica)
        {
            InitializeComponent();
            postojecaUtakmica = utakmica;
        }

        private void IzmjeniUtakmicuForm_Load(object sender, EventArgs e)
        {
            domacinComboBox.DataSource = Repozitorij.PopisReprezentacija.ToList();
            domacinComboBox.SelectedItem = postojecaUtakmica.Domacin;

            gostComboBox.DataSource = Repozitorij.PopisReprezentacija.ToList();
            gostComboBox.SelectedItem = postojecaUtakmica.Gost;

            zgodiciDomacinTextBox.Text = postojecaUtakmica.BrojZgoditakaDomacin.ToString();
            zgodiciGostTextBox.Text = postojecaUtakmica.BrojZgoditakaGost.ToString();

            datumTextBox.Text = postojecaUtakmica.Datum.Date.ToShortDateString();
            if(postojecaUtakmica.Status == StatusUtakmice.Zakazana)
            {
                zakazanaRadio.Checked = true; 
            }
            else
            {
                odigranaRadio.Checked = true;
            }

        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            Reprezentacija domacin = domacinComboBox.SelectedItem as Reprezentacija;
            Reprezentacija gost = gostComboBox.SelectedItem as Reprezentacija;

            int brojZgoditakaDomacina = int.Parse(zgodiciDomacinTextBox.Text);
            int brojZgoditakaGost = int.Parse(zgodiciGostTextBox.Text);

            DateTime datumUtakmice = DohvatimDatumUtakmice(datumTextBox.Text);
            StatusUtakmice status = DohvatiStatusUtakmice();

            postojecaUtakmica.Domacin = domacin;
            postojecaUtakmica.Gost = gost;
            postojecaUtakmica.BrojZgoditakaDomacin = brojZgoditakaDomacina;
            postojecaUtakmica.BrojZgoditakaGost = brojZgoditakaGost;
            postojecaUtakmica.Datum = datumUtakmice;
            postojecaUtakmica.Status = status;

            
            Close();
        }

        private StatusUtakmice DohvatiStatusUtakmice()
        {
            if (zakazanaRadio.Checked == true)
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

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
