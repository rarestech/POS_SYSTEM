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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        CategoriesDAL cdal = new CategoriesDAL();
        ProductDAL pdal = new ProductDAL();
public void SetAdmin()
        {
            this.Width = 594;
            this.Height = 506;
            dgvInventory.Width = 586;
            dgvInventory.Height = 386;
        }
        public void SetUser()
        {
            this.Width = 769;
            this.Height = 562;
            dgvInventory.Width = 754;
            dgvInventory.Height = 394;
            

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DataTable dt = cdal.Select();
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            DataTable pdt = pdal.Select();
            dgvInventory.DataSource = pdt;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;
            DataTable dt = pdal.DisplayProductsByCategory(category);
            dgvInventory.DataSource = dt;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            DataTable pdt = pdal.Select();
            dgvInventory.DataSource = pdt;
        }
    }
}
