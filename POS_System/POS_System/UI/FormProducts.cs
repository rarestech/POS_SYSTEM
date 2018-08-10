using POS_System.BLL;
using POS_System.DAL;
using POS_System.GeterSetter;
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
    public partial class FormProducts : Form
    {
        ProductDAL pdal = new ProductDAL();
        UserDAL userDAL = new UserDAL();
        ProductsBLL p = new ProductsBLL();
        CategoriesDAL cdal = new CategoriesDAL();
        public FormProducts()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPrdct_Click(object sender, EventArgs e)
        {
           
            if (txtName.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product Name is required!");
                mymessage.Show();
                return;
            }
            if (txtDesc.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product Description is required!");
                mymessage.Show();
                return;
            }
            if (txtProductRate.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product Rate is required!");
                mymessage.Show();
                return;
            }
            if (cmbCategory.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product Category is required!");
                mymessage.Show();
                return;
            }
            p.name = txtName.Text;
            p.description = txtDesc.Text;
            p.category = cmbCategory.Text;
            p.rate = decimal.Parse(txtProductRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            string loggedInUser = Login.loggedInUser;
            UserBLL user = userDAL.getIdFromUserName(loggedInUser);
            p.added_by = user.id;

            bool success = pdal.Insert(p);
            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Product Successfully Added!");
                mymessage.Show();
                Clear();
                DataTable dt = pdal.Select();
                GDVProduct.DataSource = dt;
            }else
            {
                Mymessage mymessage = new Mymessage("Error While inserting Product in DataBase!");
                mymessage.Show();
            }

        }
        public void Clear()
        {
            txtPrdctID.Text = "";
            txtName.Text = "";
            txtDesc.Text = "";
            txtProductRate.Text = "";
            txtSearch.Text = "";
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            DataTable categoriesDT = cdal.Select();
            //Specify DataSource for Category ComboBox
            cmbCategory.DataSource = categoriesDT;
            //Specify Display Member and Value Member for Combobox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //Load all the Products in Data Grid View
            DataTable dt = pdal.Select();
            GDVProduct.DataSource = dt;
        }

        private void GDVProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtPrdctID.Text = GDVProduct.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = GDVProduct.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = GDVProduct.Rows[rowIndex].Cells[2].Value.ToString();
            txtDesc.Text = GDVProduct.Rows[rowIndex].Cells[3].Value.ToString();
            txtProductRate.Text = GDVProduct.Rows[rowIndex].Cells[4].Value.ToString();
        }
        
        private void btnUpdateprdct_Click(object sender, EventArgs e)
        {
            if (txtPrdctID.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product ID is required!");
                mymessage.Show();
                return;
            }
            if (txtName.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product Name is required!");
                mymessage.Show();
                return;
            }
            if (txtDesc.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product Description is required!");
                mymessage.Show();
                return;
            }
            if (txtProductRate.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product Rate is required!");
                mymessage.Show();
                return;
            }
            if (cmbCategory.Text.Length==0)
            {
                Mymessage mymessage = new Mymessage("Product Category is required!");
                mymessage.Show();
                return;
            }
            p.id = int.Parse(txtPrdctID.Text);
            p.name = txtName.Text;
            p.description = txtDesc.Text;
            p.category = cmbCategory.Text;
            p.rate = decimal.Parse(txtProductRate.Text);
            p.added_date = DateTime.Now;

            string loggedInUser = Login.loggedInUser;
            UserBLL user = userDAL.getIdFromUserName(loggedInUser);
            p.added_by = user.id;

            bool success = pdal.Update(p);
            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Sucessfully Updated!");
                mymessage.Show();
                Clear();
                DataTable dt = pdal.Select();
                GDVProduct.DataSource = dt;
            }
            else
            {
                Mymessage mymessage = new Mymessage("Product updation failed!");
                mymessage.Show();
            }
        }

        private void btnDeletePrdct_Click(object sender, EventArgs e)
        {
            if (txtPrdctID.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Product ID is required for updation!");
                mymessage.Show();
                return;
            }
            else
            {
                p.id = int.Parse(txtPrdctID.Text);
            }

            bool success = pdal.Delete(p);
            if (success == true)
            {

                Mymessage mymessage = new Mymessage("Product Successfully Deleted");
                mymessage.Show();
                Clear();
                DataTable dt = pdal.Select();
                GDVProduct.DataSource = dt;
            }
            else
            {

                Mymessage mymessage = new Mymessage("Product Deletion Failed!");
                mymessage.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            if (txt != null)
            {
                DataTable dt = pdal.Search(txt);
                GDVProduct.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                GDVProduct.DataSource = dt;
            }
        }
    }
}
