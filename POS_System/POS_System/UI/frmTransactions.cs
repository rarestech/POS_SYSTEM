using POS_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.UI
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }
        TransactionDAL tdal = new TransactionDAL();
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransaction.DataSource = dt;
        }
        public void SetAdmin()
        {
            this.Width = 594;
            this.Height = 506;
            dgvTransaction.Width = 586;
            dgvTransaction.Height = 386;
        }
        public void SetUser()
        {
            this.Width = 769;
            this.Height = 562;
            dgvTransaction.Width = 754;
            dgvTransaction.Height = 394;


        }
        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbTransactionType.Text;
            DataTable dt = tdal.DisplayTransactionByType(type);
            dgvTransaction.DataSource = dt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
