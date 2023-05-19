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
    public partial class AdministratorsStatsForm : Form
    {

        public AdministratorsStatsForm()
        {
            InitializeComponent();
        }

        private void AdministratorsStatsForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        private void Osvjezi()
        {
            List<User> korisnici = UsersRepository.GetUsers();
            korisniciDgv.DataSource = null;
            korisniciDgv.DataSource = korisnici;
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            User korisnik = korisniciDgv.CurrentRow.DataBoundItem as User;
            korisnik.Status = UserStatus.Activated;
            Osvjezi();
        }

        private void deactivateButton_Click(object sender, EventArgs e)
        {
            User korisnik = korisniciDgv.CurrentRow.DataBoundItem as User;
            korisnik.Status = UserStatus.Deactivated;
            Osvjezi();
        }
    }
}
