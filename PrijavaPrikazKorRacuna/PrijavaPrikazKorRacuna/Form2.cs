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
    public partial class Form2 : Form
    {
        public string usernameKorisnika;
        public string passwordKorisnika;
        public Form2(string username, string password)
        {
            InitializeComponent();
            usernameKorisnika = username;
            passwordKorisnika = password;
            Autentificator.LogIn(usernameKorisnika, passwordKorisnika);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            firstNameTxb.Text = Autentificator.LoggedUser.FirstName;
            lastNameTxb.Text = Autentificator.LoggedUser.LastName;
            userNameTxb.Text = Autentificator.LoggedUser.UserName;
            passwordTxb.Text = Autentificator.LoggedUser.Password;

            adminRbn.Checked = false;
            guestRbn.Checked = false;
            employeeRbn.Checked = false;

            if(Autentificator.LoggedUser.UserName == "guest")
            {
                guestRbn.Checked = true;
            }
            else if(Autentificator.LoggedUser.UserName == "admin")
            {
                adminRbn.Checked = true;
            }
            else
            {
                employeeRbn.Checked = true;
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Autentificator.LogOut();
            Close();
        }
    }
}
