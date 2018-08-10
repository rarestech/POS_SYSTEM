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
    public partial class CategoryForm : Form
    {
        CategoryBLL c = new CategoryBLL();
        CategoriesDAL dal = new CategoriesDAL();
        UserDAL userDAL = new UserDAL();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Category Title is required!");
                mymessage.Show();
                return;
            }
            if (txtDesc.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Category Description is required!");
                mymessage.Show();
                return;
            }
            c.title = txtTitle.Text;
            c.description = txtDesc.Text;
            c.added_date = DateTime.Now;

            string addedBy = Login.loggedInUser;
            UserBLL user = userDAL.getIdFromUserName(addedBy);
            c.id = user.id;

            bool isSuccess = dal.Insert(c);
            if (isSuccess == true)
            {
                Mymessage mymessage = new Mymessage("Category Successfully Inserted into DataBase");
                mymessage.Show();
                Clear();
                DataTable dt = dal.Select();
                GDVCategory.DataSource = dt;
            }
            else
            {
                Mymessage mymessage = new Mymessage("Inserting Category In DataBase Failed!");
                mymessage.Show();
            }
        }
        public void Clear()
        {
            txtCatID.Text = "";
            txtDesc.Text = "";
            txtTitle.Text = "";
            txtSearch.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DataTable dt = dal.Select();
            GDVCategory.DataSource = dt;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GDVCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCatID.Text = GDVCategory.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = GDVCategory.Rows[RowIndex].Cells[1].Value.ToString();
            txtDesc.Text = GDVCategory.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            if (txtCatID.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Category ID is required!");
                mymessage.Show();
                return;
            }
            if (txtTitle.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Category Title is required!");
                mymessage.Show();
                return;
            }
            if (txtDesc.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Category Description is required!");
                mymessage.Show();
                return;
            }

            c.id = int.Parse(txtCatID.Text);
            c.title = txtTitle.Text;
            c.description = txtDesc.Text;

            c.added_date = DateTime.Now;

            string addedBy = Login.loggedInUser;
            UserBLL user = userDAL.getIdFromUserName(addedBy);
            c.added_by = user.id;

            bool success = dal.update(c);
            if (success == true)
            {
                Mymessage my = new Mymessage("Category Updated SuccessFully!");
                my.Show();
                Clear();
                DataTable dt = dal.Select();
                GDVCategory.DataSource = dt;
            }
            else
            {
                Mymessage mymessage = new Mymessage("Failed in Updation Category");
                mymessage.Show();
            }
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCatID.Text);

            bool success = dal.Delete(c);

            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Category Successfully Deleted!");
                mymessage.Show();
                Clear();
                DataTable dt = dal.Select();
                GDVCategory.DataSource = dt;
            
            }
            else
            {
                Mymessage mymessage = new Mymessage("Category Deletion Failed!");
                mymessage.Show();
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if (keyword != null)
            {
                DataTable dt = dal.Search(keyword);
                GDVCategory.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                GDVCategory.DataSource = dt;
            }
        }
    }
}
