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
    public partial class TablicaRezultata : Form
    {
        private Prvenstvo prvenstvo = Repozitorij.Prvenstvo;

        public TablicaRezultata()
        {
            InitializeComponent();
        }

        private void TablicaRezultata_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }

        private void OsvjeziPopis()
        {
            List<Utakmica> popisUtakmica = prvenstvo.DohvatiUtakmice();
            utakmiceGridView.DataSource = null;
            utakmiceGridView.DataSource = popisUtakmica;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            Utakmica selektiranaUtakmica = DohvatiSelektiranuUtakmicu();
            prvenstvo.ObrisiUtakmicu(selektiranaUtakmica);

            OsvjeziPopis();
        }

        private Utakmica DohvatiSelektiranuUtakmicu()
        {
            Utakmica utakmica = null;
            if(utakmiceGridView.CurrentRow != null)
            {
                utakmica = utakmiceGridView.CurrentRow.DataBoundItem as Utakmica;
            }
            return utakmica;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DodajUtakmicuForm form = new DodajUtakmicuForm();
            form.ShowDialog();
            OsvjeziPopis();
        }

        private void izmjeniButton_Click(object sender, EventArgs e)
        {
            Utakmica selektiranaUtakmica = DohvatiSelektiranuUtakmicu();
            IzmjeniUtakmicuForm form = new IzmjeniUtakmicuForm(selektiranaUtakmica);
            form.ShowDialog();
            OsvjeziPopis();

        }
    }
}
