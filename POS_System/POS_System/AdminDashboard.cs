using MaterialSkin.Controls;
using POS_System.BLL;
using POS_System.DAL;
using POS_System.GeterSetter;
using POS_System.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class AdminDashboard : MaterialForm
    {
        List<Panel> panels = new List<Panel>();
        UserBLL u1 = new UserBLL();
        UserDAL dal = new UserDAL();

        public AdminDashboard()
        {

            InitializeComponent();
            lblDeveloperName.Text = Program.developerName;
            this.MaximizeBox = false;
            lblLoggedInUser.Text = Login.loggedInUser;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = dal.select();
            //   GDVusers.DataSource = dataTable;
            // GDVusers.Refresh();
            //lblLoggedInUser.Text = Login.loggedInUser;
           // panels.Add(Userpanel);
            //panels.Add(CategPanel);
        }

      /*  private void CanReg_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 40)
            {

                sideMenu.Visible = false;
                sideMenu.Width = 178;
                btnMenu.SetBounds(137, 6, 40, 40);
                PanelAnimator.ShowSync(sideMenu);
            }

            panels[0].BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 40)
            {

                sideMenu.Visible = false;
                sideMenu.Width = 178;
                btnMenu.SetBounds(137, 6, 40, 40);
                PanelAnimator.ShowSync(sideMenu);
            }
            else
            {
                sideMenu.Visible = false;
                btnMenu.SetBounds(2, 3, 40, 40);
                sideMenu.Width = 40;
                PanelAnimator.ShowSync(sideMenu);
            }
        }
       
        private void btnAddUser_Click(object sender, EventArgs e)
        {
           
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

        private void pnlUsers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GDVusers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
           
        }*/

       
        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            /*AdminImage.Visible = false;
            txtUserId.Visible = true;
            txtFName.Visible = true;
            txtLName.Visible = true;
            txtEMail.Visible = true;
            txtUserName.Visible = true;
            txtPassword.Visible = true;
            txtContact.Visible = true;
            txtAddress.Visible = true;
            txtUserSearch.Visible = true;

            lblUserId.Visible = true;
            lblUserFName.Visible = true;
            lblUserLName.Visible = true;
            LblUserEmail.Visible = true;
            lblUserLName.Visible = true;
            lblUserPassword.Visible = true;
            LblUserCantact.Visible = true;
            lblUserAddress.Visible = true;
            lblUserUserType.Visible = true;
            lblUserGender.Visible = true;
            lblUserUserType.Visible = true;
            lblUserSearch.Visible = true;

            btnAddUser.Visible = true;
            btnUpdateUser.Visible = true;
            btnDeleteUser.Visible = true;

            GDVusers.Visible = true;*/

            panel3.Controls.Clear();
            UserForm user = new UserForm();
            user.TopLevel = false;
            panel3.Controls.Add(user);
            user.Show();
        }

        private void BtnCateg_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.TopLevel = false;
            panel3.Controls.Add(categoryForm);
            categoryForm.Show();
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           // AdminImage.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 40)
            {

                sideMenu.Visible = false;
                sideMenu.Width = 178;
                btnMenu.SetBounds(137, 6, 40, 40);
                PanelAnimator.ShowSync(sideMenu);
            }
            else
            {
                sideMenu.Visible = false;
                btnMenu.SetBounds(2, 3, 40, 40);
                sideMenu.Width = 40;
                PanelAnimator.ShowSync(sideMenu);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormProducts formProducts = new FormProducts();
            formProducts.TopLevel = false;
            panel3.Controls.Add(formProducts);
            formProducts.Show();
        }

        private void btnDeaCust_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FrmDealCustomer frmDealCustomer = new FrmDealCustomer();
            frmDealCustomer.TopLevel = false;
            panel3.Controls.Add(frmDealCustomer);
            frmDealCustomer.Show();
        }

        private void BtnInvet_Click(object sender, EventArgs e)
        {
            frmInventory frmInventory = new frmInventory();
            frmInventory.SetAdmin();
            panel3.Controls.Clear();
            frmInventory.TopLevel = false;
            panel3.Controls.Add(frmInventory);
            frmInventory.Show();
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            frmTransactions transactions = new frmTransactions();
            transactions.SetAdmin();
            panel3.Controls.Clear();
            transactions.TopLevel = false;
            panel3.Controls.Add(transactions);
            transactions.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            //frmHistory history = new frmHistory();
            //panel3.Controls.Clear();
            //history.TopLevel = false;
            //panel3.Controls.Add(history);
            //history.Show();
        }

        /*  private void btnusers_Click(object sender, EventArgs e)
          {
              if (sideMenu.Width == 40)
              {

                  sideMenu.Visible = false;
                  sideMenu.Width = 178;
                  btnMenu.SetBounds(137, 6, 40, 40);
                  PanelAnimator.ShowSync(sideMenu);
              }

              panels[1].BringToFront();
          }

          private void BtnCateg_Click_1(object sender, EventArgs e)
          {
              if (sideMenu.Width == 40)
              {

                  sideMenu.Visible = false;
                  sideMenu.Width = 178;
                  btnMenu.SetBounds(137, 6, 40, 40);
                  PanelAnimator.ShowSync(sideMenu);
              }
              // PANElCat.BringToFront();

              //pnlAdmin.Visible = false;
              // sideMenu.Visible = true;
              panels[1].BringToFront();

          }

          private void btnMenu_Click(object sender, EventArgs e)
          {
              if (sideMenu.Width == 40)
              {

                  sideMenu.Visible = false;
                  sideMenu.Width = 178;
                  btnMenu.SetBounds(137, 6, 40, 40);
                  PanelAnimator.ShowSync(sideMenu);
              }
              else
              {
                  sideMenu.Visible = false;
                  btnMenu.SetBounds(2, 3, 40, 40);
                  sideMenu.Width = 40;
                  PanelAnimator.ShowSync(sideMenu);
              }
          }*/




    }
}
