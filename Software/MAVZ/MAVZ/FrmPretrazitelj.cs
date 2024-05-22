using DBLayer;
using MAVZ.repozitories;
using MAVZ.Models;
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
    public partial class FrmPretrazitelj : Form
    {
        public FrmPretrazitelj()
        {
            InitializeComponent();
        }

        private void FrmPretrazitelj_Load(object sender, EventArgs e)
        {
            ShowVozniRed();
        }

        private void ShowVozniRed()
        {
            var voznired = VozniRedReposetory.GetVozniRed();

            dvgVozniRed.DataSource = voznired;

            dvgVozniRed.Columns["id"].DisplayIndex = 0;
            dvgVozniRed.Columns["linija"].DisplayIndex = 1;
            dvgVozniRed.Columns["vrijemepol"].DisplayIndex = 2;
            dvgVozniRed.Columns["vrijemedol"].DisplayIndex = 3;


        }

        private void txtSearchB_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchB.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                string query = $"SELECT * FROM VozniRed  WHERE linija LIKE '%{searchText}%'";

                DB.OpenConnection();

                SqlDataReader reader = DB.GetDataReader(query);

                DataTable dt = new DataTable();
                dt.Load(reader);

                reader.Close();
                DB.CloseConnection();

                dvgVozniRed.DataSource = dt;
            }
            else
            {
                ShowVozniRed();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
