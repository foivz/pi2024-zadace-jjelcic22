using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAVZ
{
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }



        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            FrmIzmjena frmIzmjena = new FrmIzmjena();
            frmIzmjena.Show();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmPretrazitelj frmPretrazitelj = new FrmPretrazitelj();
            frmPretrazitelj.Show();
        }

        private void FrmIzbornik_Load(object sender, EventArgs e)
        {
           
        }
    }
}
