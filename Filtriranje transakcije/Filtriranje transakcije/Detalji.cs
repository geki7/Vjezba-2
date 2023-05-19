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
    public partial class Detalji : Form
    {
        Transakcija transakcijaForme = new Transakcija();
        public Detalji(Transakcija transakcijaMetode)
        {
            InitializeComponent();
            transakcijaForme = transakcijaMetode;
        }

        private void Detalji_Load(object sender, EventArgs e)
        {
            ibanTxb.Text = transakcijaForme.Platitelj.IBAN;
            vlasnikTxb.Text = transakcijaForme.Platitelj.Vlasnik;
            stanjeTxb.Text = transakcijaForme.Platitelj.Stanje.ToString();
            ukupniPrometTxb.Text = transakcijaForme.Platitelj.IzracunajUkupanPromet().ToString();
        }

        private void zatvoriBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
