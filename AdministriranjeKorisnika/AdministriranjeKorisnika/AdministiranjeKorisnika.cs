using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutentifikacijaLib;

namespace AdministriranjeKorisnika
{
    public partial class AdministiranjeKorisnika : Form
    {
        public AdministiranjeKorisnika()
        {
            InitializeComponent();
        }

        private void AdministiranjeKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usrename = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            if(usrename == "admin" && password == "admin")
            {
                AdministratorsStatsForm form = new AdministratorsStatsForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must be adminstrator to login.");
            }
        }
    }
}
