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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        UserBLL u1 = new UserBLL();
        UserDAL dal = new UserDAL();

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User First Name is required!");
                mymessage.Show();
                return;
            }
            if (txtLName.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User Last Name is required!");
                mymessage.Show();
                return;
            }
            if (txtEMail.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User E-Mail is required, If don't have Enter 'Example@Example.com'!");
                mymessage.Show();
                return;
            }
            if (txtUserName.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("UserName is required!");
                mymessage.Show();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Password is required!");
                mymessage.Show();
                return;
            }
            if (txtContact.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User Contact Number is required!");
                mymessage.Show();
                return;
            }
            if (txtAddress.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User Address is required!");
                mymessage.Show();
                return;
            }
            if (cmbGender.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User Gender is required!,Please select one of them!");
                mymessage.Show();
                return;
            }
            if (cmbUserType.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("UserType is required!, pLease Select a user type!");
                mymessage.Show();
                return;
            }
            u1.First_Name = txtFName.Text;
            u1.Last_Name = txtLName.Text;
            u1.EMail = txtEMail.Text;
            u1.UserName = txtUserName.Text;
            u1.Password = txtPassword.Text;
            u1.Contact = txtContact.Text;
            u1.Address = txtAddress.Text;
            u1.Gender = cmbGender.Text;
            u1.UserType = cmbUserType.Text;
            u1.Added_Date = DateTime.Now;
            UserBLL userBLL = dal.getIdFromUserName(Login.loggedInUser);  //= dal.getIdFromUserName(lblLoggedInUser.Text);
            u1.Added_By = userBLL.id;

            bool success = dal.Insert(u1);//= dal.Insert(u1);
            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Data Succussfully Inserted!");
                mymessage.Show();
            }
            else
            {
                Mymessage myMessageBox = new Mymessage("There is Error while inserting data in the DataBase");
                myMessageBox.Show();
            }
            clearUser();
        }
        public void clearUser()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEMail.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtEMail.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("UserID is required!");
                mymessage.Show();
                return;
            }
            if (txtFName.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User First Name is required!");
                mymessage.Show();
                return;
            }
            if (txtLName.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User Last Name is required!");
                mymessage.Show();
                return;
            }
            if (txtEMail.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User E-Mail is required, If don't have Enter 'Example@Example.com'!");
                mymessage.Show();
                return;
            }
            if (txtUserName.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("UserName is required!");
                mymessage.Show();
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("Password is required!");
                mymessage.Show();
                return;
            }
            if (txtContact.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User Contact Number is required!");
                mymessage.Show();
                return;
            }
            if (txtAddress.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User Address is required!");
                mymessage.Show();
                return;
            }
            if (cmbGender.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("User Gender is required!,Please select one of them!");
                mymessage.Show();
                return;
            }
            if (cmbUserType.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("UserType is required!, pLease Select a user type!");
                mymessage.Show();
                return;
            }

            u1.id = Convert.ToInt32(txtUserId.Text.ToString());
            u1.First_Name = txtFName.Text;
            u1.Last_Name = txtLName.Text;
            u1.EMail = txtEMail.Text;
            u1.UserName = txtUserName.Text;
            u1.Password = txtPassword.Text;
            u1.Contact = txtContact.Text;
            u1.Address = txtAddress.Text;
            u1.Gender = cmbGender.Text;
            u1.UserType = cmbUserType.Text;
            u1.Added_Date = DateTime.Now;
            u1.Added_By = 1;

            bool success = dal.Update(u1);//= dal.Update(u1);
            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Data Succussfully Updated!");
                mymessage.Show();
            }
            else
            {
                Mymessage myMessageBox = new Mymessage("There is Error while Updating data in the DataBase");
                myMessageBox.Show();
            }
            DataTable dt = dal.select();//dal.select();
            GDVusers.DataSource = dt;
            GDVusers.Refresh();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Length == 0)
            {
                Mymessage mymessage = new Mymessage("UserID is required!");
                mymessage.Show();
                return;
            }
            u1.id = Convert.ToInt32(txtUserId.Text);

            bool success = dal.Delete(u1);//= dal.Delete(u1);
            if (success == true)
            {
                Mymessage mymessage = new Mymessage("Data Succussfully Deleted!");
                mymessage.Show();
                clearUser();
            }
            else
            {
                Mymessage myMessageBox = new Mymessage("There is Error while Deleting data in the DataBase");
                myMessageBox.Show();
            }
            DataTable dt = dal.select();//dal.select();
            GDVusers.DataSource = dt;
            GDVusers.Refresh();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);//=dal.Search(keywords);
                GDVusers.DataSource = dt;
                GDVusers.Refresh();
            }
            else
            {
                DataTable dt = dal.select();//=dal.Select();
                GDVusers.DataSource = dt;
                GDVusers.Refresh();
            }
        }

        private void GDVusers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserId.Text = GDVusers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFName.Text = GDVusers.Rows[rowIndex].Cells[1].Value.ToString(); ;
            txtLName.Text = GDVusers.Rows[rowIndex].Cells[2].Value.ToString(); ;
            txtEMail.Text = GDVusers.Rows[rowIndex].Cells[3].Value.ToString(); ;
            txtUserName.Text = GDVusers.Rows[rowIndex].Cells[4].Value.ToString(); ;
            txtPassword.Text = GDVusers.Rows[rowIndex].Cells[5].Value.ToString(); ;
            txtContact.Text = GDVusers.Rows[rowIndex].Cells[6].Value.ToString(); ;
            txtAddress.Text = GDVusers.Rows[rowIndex].Cells[7].Value.ToString(); ;
            cmbGender.Text = GDVusers.Rows[rowIndex].Cells[8].Value.ToString(); ;
            cmbUserType.Text = GDVusers.Rows[rowIndex].Cells[9].Value.ToString(); ;
        }

        private void GDVusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
