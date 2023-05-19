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
    public partial class kupiKartu : Form
    {
        public Karta karte;
        public Linija prosljedenjaLinija;
        AutobusniKolodvor autobusniKolodvor;
        public kupiKartu(Linija linija)
        {
            autobusniKolodvor = new AutobusniKolodvor();
            InitializeComponent();
            prosljedenjaLinija = linija;
        }

        private void kupiKartu_Load(object sender, EventArgs e)
        {

        }
    }
}
