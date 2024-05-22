using DBLayer;
using MAVZ.Models;
using MAVZ.repozitories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAVZ
{
    public partial class FrmIzmjena : Form
    {
        private VozniRed voznired;
        public FrmIzmjena()
        {
            InitializeComponent();
        }

        private void FrmIzmjena_Load(object sender, EventArgs e)
        {
            var voznired = VozniRedReposetory.GetVozniRed();
            cbOdabir.DisplayMember = "linija";
            cbOdabir.DataSource = voznired;
        }

        private void cbOdabir_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trenutnaLinija = cbOdabir.SelectedItem as VozniRed;
            numId.Text = trenutnaLinija.id.ToString();
            txtLinija.Text = trenutnaLinija.linija;
            txtVrijemePol.Text = trenutnaLinija.vrijemepol;
            txtVrijemeDol.Text = trenutnaLinija.vrijemedol;


        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            var selectedVozniRed = cbOdabir.SelectedItem as VozniRed;

            
            selectedVozniRed.linija = txtLinija.Text;
            selectedVozniRed.vrijemepol = txtVrijemePol.Text;
            selectedVozniRed.vrijemedol = txtVrijemeDol.Text;

            int selectedIndex = cbOdabir.SelectedIndex;

            UpdateVozniRedInDatabase(selectedVozniRed);

            FrmIzmjena_Load(sender, e);

            if (selectedIndex >= 0 && selectedIndex < cbOdabir.Items.Count)
            {
                cbOdabir.SelectedIndex = selectedIndex;
            }
        }
        private void UpdateVozniRedInDatabase(VozniRed voznired)
        {
            DB.OpenConnection();
            string query = $"UPDATE VozniRed SET linija = '{voznired.linija}', vrijemepol = '{voznired.vrijemepol}',vrijemedol =' {voznired.vrijemedol}' WHERE id_voznired = {voznired.id}";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        private void DeleteVozniRedInDatabase(VozniRed voznired)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM VozniRed WHERE id_voznired = {voznired.id}";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            VozniRed newVozniRed = new VozniRed();

            newVozniRed.linija = "New VozniRed";
            newVozniRed.vrijemepol = "0:0";
            newVozniRed.vrijemedol = "0:0";
            
            AddVozniRedInDatabase(newVozniRed);

            FrmIzmjena_Load(sender, e);

            cbOdabir.SelectedIndex = cbOdabir.Items.Count - 1;

        }

        private void AddVozniRedInDatabase(VozniRed voznired)
        {
            DB.OpenConnection();
            int lastInsertedid = GetLastInsertedid();

            int newid = lastInsertedid + 1;
            voznired.id = newid;


            string query = $"INSERT INTO VozniRed (id_voznired ,linija,vrijemepol,vrijemedol) " +
                           $"VALUES ({voznired.id}, '{voznired.linija}', '{voznired.vrijemepol}', '{voznired.vrijemedol}')";
            DB.ExecuteCommand(query);
            DB.CloseConnection();
        }

        private int GetLastInsertedid()
        {
            int lastInsertedid = 0;

            string query = "SELECT MAX(id_voznired) AS Lastid FROM VozniRed";
            SqlDataReader reader = DB.GetDataReader(query);

            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("Lastid")))
                {
                    lastInsertedid = reader.GetInt32(reader.GetOrdinal("Lastid"));
                }
            }

            reader.Close();

            return lastInsertedid;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            var selectedVozniRed = cbOdabir.SelectedItem as VozniRed;

            DeleteVozniRedInDatabase(selectedVozniRed);
            FrmIzmjena_Load(sender, e);
        }
    }
}
