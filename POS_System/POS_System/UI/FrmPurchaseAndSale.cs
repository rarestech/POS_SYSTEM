using POS_System.BLL;
using POS_System.DAL;
using POS_System.GeterSetter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace POS_System.UI
{
    public partial class FrmPurchaseAndSale : Form
    {
        DeaCustDAL dcdal = new DeaCustDAL();
        ProductDAL pdal = new ProductDAL();
        UserDAL udal = new UserDAL();
        TransactionDAL Tdal = new TransactionDAL();
        TransactionDetailDAL TDdal = new TransactionDetailDAL();

        DataTable transactionDT = new DataTable();
        public FrmPurchaseAndSale()
        {
            InitializeComponent();
        }

        private void txtDeaCustSearch_OnValueChanged(object sender, EventArgs e)
        {
            string keywords = txtDeaCustSearch.Text;
            if (keywords == "")
            {
                txtName.Text = "";
                txtEMail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }

            DeaCustBLL dc = dcdal.SearchDealerCustomerForTransaction(keywords);
            txtName.Text = dc.name;
            txtEMail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;
        }

        private void txtPrdctSearch_OnValueChanged(object sender, EventArgs e)
        {
            string keywords=txtPrdctSearch.Text;
            if (keywords == "")
            {
                txtPrdctName.Text = "";
                txtProductRate.Text = "";
                txtPrdctInventory.Text = "";
                txtPrdctQty.Text = "";
                return;
            }
            ProductsBLL p = pdal.GetProductsForTransaction(keywords);
            txtPrdctName.Text = p.name;
            txtPrdctInventory.Text = p.qty.ToString();
            txtProductRate.Text = p.rate.ToString();
            
        }

        private void btnAddPrdct_Click(object sender, EventArgs e)
        {
            if (txtPrdctQty.Text == "")
            {
                Mymessage mymessage = new Mymessage("Add Product Quantity First!");
                mymessage.Show();
                return;
            }
            string productName = txtPrdctName.Text;
            decimal rate = decimal.Parse(txtProductRate.Text);
            decimal Qty = decimal.Parse(txtPrdctQty.Text);
            decimal Total = rate * Qty;
            decimal subtotal = decimal.Parse(txtSubTotal.Text);
            subtotal = Total + subtotal;

            if (productName == "")
            {
                Mymessage mymessage = new Mymessage("Select a Product First!");
                mymessage.Show();
                return;
            }
            else
            {
                txtSubTotal.Text = subtotal.ToString();
                transactionDT.Rows.Add(productName, rate, Qty, Total);
                GDVCustomer.DataSource = transactionDT;
                txtPrdctSearch.Text = "";
                txtPrdctQty.Text = "";
                txtPrdctName.Text = "";
                txtPrdctInventory.Text = "";
                txtProductRate.Text = "";

            }
        }

        private void FrmPurchaseAndSale_Load(object sender, EventArgs e)
        {
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
            int d = 0;
            txtSubTotal.Text = d.ToString();
        }

        private void txtDiscount_OnValueChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "")
            {
                Mymessage mymessage = new Mymessage(" First!");
              //  mymessage.Show();
                return;
            }

            decimal sunTotal = decimal.Parse(txtSubTotal.Text);
            decimal Discount = decimal.Parse(txtDiscount.Text);

            decimal GradTotal = ((100 - Discount ) / 100) * sunTotal;
            txtGrandTotal.Text = GradTotal.ToString();
        }

        private void txtVAT_OnValueChanged(object sender, EventArgs e)
        {
            if (txtGrandTotal.Text == "")
            {
                
                    Mymessage mymessage = new Mymessage("Calculate Grand Total First!");
                    mymessage.Show();
                    return;

            }else if (txtVAT.Text == "")
            {
                return;
            }
            else
            {
                decimal PreviGT = decimal.Parse(txtGrandTotal.Text);
                decimal vat = decimal.Parse(txtVAT.Text);
                decimal grandTotal = ((100 + vat) / 100) * PreviGT;

                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtPaidAmt_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPaidAmt.Text == "")
            {
                return;
            }
            decimal GrndTotal = decimal.Parse(txtGrandTotal.Text);
            decimal PaidAmt = decimal.Parse(txtPaidAmt.Text);

            decimal returnAmt = PaidAmt - GrndTotal;
            txtReturnAmount.Text = returnAmt.ToString();
        }

        private void btnSaveCal_Click(object sender, EventArgs e)
        {
            //Get the Values from PurchaseSales Form First
            TransactionsBLL transaction = new TransactionsBLL();

            transaction.type = UserDashboard.TransactionType;

            //Get the ID of Dealer or Customer Here
            //Lets get name of the dealer or customer first
            string deaCustName = txtName.Text;
            DeaCustBLL dc = dcdal.GetDeaCustIDFromName(deaCustName);

            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txtVAT.Text);
            transaction.discount = decimal.Parse(txtDiscount.Text);

            //Get the Username of Logged in user
            string username = Login.loggedInUser;
            UserBLL u = udal.getIdFromUserName(username);

            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            //Lets Create a Boolean Variable and set its value to false
            bool success = false;

            //Actual Code to Insert Transaction And Transaction Details
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                //Create aboolean value and insert transaction 
                bool w = Tdal.Insert_Transaction(transaction, out transactionID);

                //Use for loop to insert Transaction Details
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    //Get all the details of the product
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();
                    //Get the Product name and convert it to id
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    ProductsBLL p = pdal.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()), 2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;

                    //Here Increase or Decrease Product Quantity based on Purchase or sales
                    string transactionType = UserDashboard.TransactionType;

                    //Lets check whether we are on Purchase or Sales
                    bool x = false;
                    if (transactionType == "Purchase")
                    {
                        //Increase the Product
                        x = pdal.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    else if (transactionType == "Sales")
                    {
                        //Decrease the Product Quntiyt
                        x = pdal.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }

                    //Insert Transaction Details inside the database
                    bool y = TDdal.InsertTransactionDetail(transactionDetail);
                    success = w && x && y;
                }

                if (success == true)
                {
                    //Transaction Complete
                    scope.Complete();
                    Mymessage mymessage = new Mymessage("Transaction Completed Sucessfully");
                    mymessage.Show();
                    //Celar the Data Grid View and Clear all the TExtboxes
                    GDVCustomer.DataSource = null;
                    GDVCustomer.Rows.Clear();

                    txtDeaCustSearch.Text = "";
                    txtName.Text = "";
                    txtEMail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtPrdctSearch.Text = "";
                    txtPrdctName.Text = "";
                    txtPrdctInventory.Text = "0";
                    txtProductRate.Text = "0";
                    txtPrdctQty.Text = "0";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVAT.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmt.Text = "0";
                    txtReturnAmount.Text = "0";
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    //Transaction Failed
                    MessageBox.Show("Transaction Failed");
                }


               
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*  PrinterSettings ps = new PrinterSettings();
              IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
             // PaperKind paperKind = PaperKind.Custom;
              PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.Custom); // setting paper size to A4 size

              printDocument1.DefaultPageSettings.PaperSize = sizeA4;*/
            //  printDocument1.DefaultPageSettings.PaperSize = new PaperSize("", 20,20);
            lblStoreName.Text = Program.StoreName;
            lblStorePhone.Text = Program.StorePhone;
            lblStoreAddress.Text = Program.StoreAddress;
            e.Graphics.DrawString(lblStoreName.Text,new Font("Segoe UI",12,FontStyle.Bold),Brushes.Black,new Point(80,30));
            e.Graphics.DrawString(lblStoreAddress.Text, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(80, 35));
            e.Graphics.DrawString("Phone : "+lblStorePhone.Text, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(80, 40));

        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
