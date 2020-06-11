using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLTH : Form
    {
        public frmLTH()
        {
            InitializeComponent();
        }

        private void frmLTH_Load(object sender, EventArgs e)
        {
           
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataLTH.CT_LICHTHUCHANH' table. You can move, or remove it, as needed.
            this.CT_LICHTHUCHANHTableAdapter.Fill(this.DataLTH.CT_LICHTHUCHANH, ccbtk.Text);

            this.reportViewer1.RefreshReport();
        }

        private void ccbtk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
