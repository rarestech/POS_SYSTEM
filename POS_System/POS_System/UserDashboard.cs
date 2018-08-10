using MaterialSkin.Controls;
using POS_System.DAL;
using POS_System.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class UserDashboard : MaterialForm
    {
        public static string TransactionType;
        
        public UserDashboard()
        {
            InitializeComponent();
            lblDeveloperName.Text = Program.developerName;
            this.MaximizeBox = false;
        }
       
        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = Login.loggedInUser;
            UserDashboard userDashboard = new UserDashboard();
            
        }

        

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Cyan;
            panel3.BackColor = Color.FromArgb(36, 54, 79);
            panel4.BackColor = Color.FromArgb(36, 54, 79);
            panel5.BackColor = Color.FromArgb(36, 54, 79);
            panel1.BackColor = Color.FromArgb(36, 54, 79);

            FrmPurchaseAndSale purchase = new FrmPurchaseAndSale();
            UserPanel.Controls.Clear();
            purchase.TopLevel = false;
            UserPanel.Controls.Add(purchase);
            purchase.Show();

            TransactionType = "Purchase";
        }

        private void BtnSale_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(36, 54, 79);
            panel3.BackColor = Color.Cyan;
            panel4.BackColor = Color.FromArgb(36, 54, 79);
            panel5.BackColor = Color.FromArgb(36, 54, 79);
            panel1.BackColor = Color.FromArgb(36, 54, 79);

            FrmPurchaseAndSale Sale = new FrmPurchaseAndSale();
            UserPanel.Controls.Clear();
            Sale.TopLevel = false;
            UserPanel.Controls.Add(Sale);
            Sale.Show();

            TransactionType = "Sales";
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(36, 54, 79);
            panel3.BackColor = Color.FromArgb(36, 54, 79);
            panel4.BackColor = Color.Cyan;
            panel5.BackColor = Color.FromArgb(36, 54, 79);

        }

        private void btnDeaCust_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(36, 54, 79);
            panel3.BackColor = Color.FromArgb(36, 54, 79);
            panel4.BackColor = Color.FromArgb(36, 54, 79);
            panel1.BackColor = Color.FromArgb(36, 54, 79);
            panel5.BackColor = Color.Cyan;

            FrmDealCustomer frmDealCustomer = new FrmDealCustomer();
            UserPanel.Controls.Clear();
            frmDealCustomer.TopLevel = false;
            UserPanel.Controls.Add(frmDealCustomer);
            
            frmDealCustomer.Show();
           
        }

        private void UserDashboard_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(36, 54, 79);
            panel3.BackColor = Color.FromArgb(36, 54, 79);
            panel4.BackColor = Color.Cyan;
            panel5.BackColor = Color.FromArgb(36, 54, 79);
            panel1.BackColor = Color.FromArgb(36, 54, 79);
            frmInventory frmInventory = new frmInventory();
            frmInventory.SetUser();
            UserPanel.Controls.Clear();
            frmInventory.TopLevel = false;
            UserPanel.Controls.Add(frmInventory);
            frmInventory.Show();

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(36, 54, 79);
            panel3.BackColor = Color.FromArgb(36, 54, 79);
            panel4.BackColor = Color.FromArgb(36, 54, 79);
            panel5.BackColor = Color.FromArgb(36, 54, 79);
            panel1.BackColor = Color.Cyan;

            frmTransactions transactions = new frmTransactions();
            transactions.SetUser();
            UserPanel.Controls.Clear();
            transactions.TopLevel = false;
            UserPanel.Controls.Add(transactions);
            transactions.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
