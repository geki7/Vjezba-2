using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipkice
{
    public partial class Form1 : Form
    {
        private Button trenutni = null;
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            pocetnaTipka.BackColor = Color.FromArgb(0, 255, 0);
            pocetnaTipka.Tag = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pocetnaTipka.Click += UniverzalniKlik;
        }

        private Point NovaLokacija(Point pocetna)
        {
            Point returnMe;
            int minX = -100;
            int minY = -100;
            if(pocetna.Y < 100)
            {
                minY = 0;
            }
            if(pocetna.X < 100)
            {
                minX = 0;
            }
            returnMe = new Point(pocetna.X + rand.Next(minX, 100), pocetna.Y + rand.Next(minY, 100));
            return returnMe;
        }

        private void UniverzalniKlik(object sender, EventArgs e)
        {
            trenutni = (sender as Button);
            trenutni.BackColor = Color.FromArgb(255, 0, 0);
            if ((bool)trenutni.Tag == false)
            {
                for (int i = 0; i < rand.Next(1, 5); i++)
                {
                    Button novi = new Button();
                    novi.Text = "Stisni me";
                    novi.Tag = false;
                    novi.BackColor = Color.FromArgb(0, 255, 0);
                    novi.Click += UniverzalniKlik;
                    novi.Location = NovaLokacija(trenutni.Location);
                    this.Controls.Add(novi);
                }
            }
            trenutni.Tag = true;
        }
    }
}
