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

namespace PrijavaPrikazKorRacuna
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lloginBtn_Click(object sender, EventArgs e)
        {
            if(usernameTxb.Text == null || passwordTxb.Text == null)
            {
                MessageBox.Show("Usrename and password must be entered!");
            }
            else
            {
                Autentificator.LoggedUser = null;
                Autentificator.LogIn(usernameTxb.Text, passwordTxb.Text);
                if(Autentificator.LoggedUser == null)
                {
                    MessageBox.Show("Uneseni podaci nisu valjani.");
                    return;
                }
                else if(usernameTxb.Text == "peric" && passwordTxb.Text == "1111" || usernameTxb.Text == "admin" && passwordTxb.Text == "admin" 
                        || usernameTxb.Text == "guest" && passwordTxb.Text == "guest")
                {

                    Autentificator.LogIn(usernameTxb.Text, passwordTxb.Text);
                    string username = usernameTxb.Text;
                    string password = passwordTxb.Text;
                    Form2 novaForma = new Form2(username, password);
                    this.Hide();
                    novaForma.ShowDialog();
                    usernameTxb.Text = null;
                    passwordTxb.Text = null;
                    this.Show();
                }
            }
        }
    }
}
