using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;

namespace KucnaKnjiznica1
{
    public partial class Form2 : Form
    {
        public Knjiga odabranKnjiga;
        public string osobakojojsamPosudio;
        public Form2(Knjiga knjigazaPosuditi)
        {
            InitializeComponent();
            odabranKnjiga = knjigazaPosuditi; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void odustaniBtn_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            isbnTxb.Text = odabranKnjiga.ISBN;
            naslovTxb.Text = odabranKnjiga.Naslov;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.osobakojojsamPosudio = osobaTxb.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
