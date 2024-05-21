using MAVZ.Models;
using MAVZ.repozitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MAVZ
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }

       

      

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtKorime.Text;
            string password = txtLozinka.Text.Trim();
            Korisnik korisnik = KorisnikReposetory.GetKorisnik(username);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nista nista upisali", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (korisnik != null && korisnik.lozinka.Trim() == password)
            {
                FrmIzbornik frmIzbornik = new FrmIzbornik();
                frmIzbornik.Show();
                Show();

            }
            else
            {
                MessageBox.Show("Unijeli ste krivokorisničko ime ili lozinku", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKorime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

