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
    public partial class Form2 : Form
    {
        public Transakcija provedenaTranskacija = new Transakcija();
        public Form2()
        {
            InitializeComponent();
        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            platiteljCbx.DataSource = Banka.DohvatiPopisRacuna().ToList();
            primateljCbx.DataSource = Banka.DohvatiPopisRacuna().ToList();
        }

        private void provediBtn_Click(object sender, EventArgs e)
        {
            this.provedenaTranskacija.Platitelj = platiteljCbx.SelectedItem as Racun;
            this.provedenaTranskacija.Primatelj = primateljCbx.SelectedItem as Racun;
            this.provedenaTranskacija.Iznos = int.Parse(iznosTxb.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
