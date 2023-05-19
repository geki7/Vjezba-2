using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib2;

namespace KucnaKnjiznica_2
{
    public partial class Posudbe : Form
    {
        public Knjiznica knjiznica = new Knjiznica();
        List<Posudba> posudbaList = new List<Posudba>();
        public Posudbe()
        {
            InitializeComponent();
        }

        private void Posudbe_Load(object sender, EventArgs e)
        {
            OsjveziListu();
        }
        private void OsjveziListu()
        {
            posudbaList = knjiznica.DohvatiSvePosudbe();
            popisDgv.DataSource = null;
            popisDgv.DataSource = posudbaList;
            for(int i = 0; i < posudbaList.Count; i++)
            {
                if(posudbaList[i].Vraceno == true)
                {
                    popisDgv.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    popisDgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        private void trenutneDostupne()
        {
            posudbaList = knjiznica.DohvatiProslePosudbe();
            popisDgv.DataSource = null;
            popisDgv.DataSource = posudbaList;
            for(int i = 0; i < posudbaList.Count; i++)
            {
                popisDgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
            vratiKnjiguBtn.Enabled = true;

        }
        private void proslePosudbe()
        {
            posudbaList = knjiznica.DohvatiTrenutnePosudbe();
            popisDgv.DataSource = null;
            popisDgv.DataSource = posudbaList;
            for(int i = 0; i < posudbaList.Count; i++)
            {
                popisDgv.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            }
            vratiKnjiguBtn.Enabled= false;
        }

        private void trenutnePosudbeRbn_CheckedChanged(object sender, EventArgs e)
        {
            trenutneDostupne();
        }

        private void proslePosudbeRbn_CheckedChanged(object sender, EventArgs e)
        {
            proslePosudbe();
        }

        private void sveRbn_CheckedChanged(object sender, EventArgs e)
        {
            OsjveziListu();
            vratiKnjiguBtn.Enabled = false;
        }

        private void vratiKnjiguBtn_Click(object sender, EventArgs e)
        {
            Posudba odabranPosudba = popisDgv.CurrentRow.DataBoundItem as Posudba;
            knjiznica.VratiKnjigu(odabranPosudba);
            OsjveziListu();
        }
    }
}
