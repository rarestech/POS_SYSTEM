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
    public partial class FrmDealCustomer : Form
    {
        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dcDal = new DeaCustDAL();
        UserDAL udal = new UserDAL();
        public FrmDealCustomer()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            dc.type = cmbtype.Text;
            dc.name = txtName.Text;
            dc.email = txtEMail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            string loggedIn = Login.loggedInUser;
            UserBLL usr = udal.getIdFromUserName(loggedIn);
            dc.added_by = usr.id;

            bool success = dcDal.Insert(dc);
            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Data Successfully Inserted! ");
                mymessage.Show();
                Clear();
                DataTable dt = dcDal.Select();
                GDVCustomer.DataSource = dt;
            }
            else
            {
                Mymessage mymessage = new Mymessage("Erroe While Inserting Data... ");
                mymessage.Show();
            }
        }
        public void Clear()
        {
            txtCustID.Text = "";
            txtName.Text = "";
            txtContact.Text = ""; 
            txtEMail.Text = ""; 
            txtAddress.Text = "";
            txtSearch.Text = "";
           
        }

        private void FrmDealCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = dcDal.Select();
            GDVCustomer.DataSource = dt;
        }

        private void GDVCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCustID.Text = GDVCustomer.Rows[RowIndex].Cells[0].Value.ToString();
            cmbtype.Text = GDVCustomer.Rows[RowIndex].Cells[1].Value.ToString();
            txtName.Text = GDVCustomer.Rows[RowIndex].Cells[2].Value.ToString();
            txtEMail.Text = GDVCustomer.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = GDVCustomer.Rows[RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = GDVCustomer.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtCustID.Text);
            dc.type = cmbtype.Text;
            dc.name = txtName.Text;
            dc.email = txtEMail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            string loggedIn = Login.loggedInUser;
            UserBLL user = udal.getIdFromUserName(loggedIn);
            dc.added_by = user.id;

            bool success = dcDal.Update(dc);
            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Data Updated Successfully!");
                mymessage.Show();
                Clear();
                DataTable dt = dcDal.Select();
                GDVCustomer.DataSource = dt;
            }
            else
            {

                Mymessage mymessage = new Mymessage("Error While updating Data!");
                mymessage.Show();
            }
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtCustID.Text);
            bool success = dcDal.Delete(dc);
            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Data Deleted Successfully!");
                mymessage.Show();
                Clear();
                DataTable dt = dcDal.Select();
                GDVCustomer.DataSource = dt;
            }
            else
            {

                Mymessage mymessage = new Mymessage("Error While Deleting Data!");
                mymessage.Show();
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (txtSearch.Text != null)
            {
                DataTable dt = dcDal.Search(keywords);
                GDVCustomer.DataSource = dt;
            }
            else
            {
                DataTable dt = dcDal.Select();
                GDVCustomer.DataSource = dt;
            }
        }
    }
}
