namespace POS_System.UI
{
    partial class FrmPurchaseAndSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchaseAndSale));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPaidAmt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtReturnAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGrandTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtVAT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDiscount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSaveCal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSubTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.GDVCustomer = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrdctQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrdctInventory = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddPrdct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtProductRate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrdctSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrdctName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BillDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeaCustSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblStoreAddress = new System.Windows.Forms.Label();
            this.lblStorePhone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVCustomer)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 562);
            this.panel3.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.txtPaidAmt);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.txtReturnAmount);
            this.panel6.Controls.Add(this.txtGrandTotal);
            this.panel6.Controls.Add(this.txtVAT);
            this.panel6.Controls.Add(this.txtDiscount);
            this.panel6.Controls.Add(this.btnSaveCal);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.txtSubTotal);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(464, 271);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 283);
            this.panel6.TabIndex = 25;
            // 
            // txtPaidAmt
            // 
            this.txtPaidAmt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPaidAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaidAmt.HintForeColor = System.Drawing.Color.Navy;
            this.txtPaidAmt.HintText = "            PAID AMOUNT";
            this.txtPaidAmt.isPassword = false;
            this.txtPaidAmt.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPaidAmt.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPaidAmt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPaidAmt.LineThickness = 3;
            this.txtPaidAmt.Location = new System.Drawing.Point(103, 162);
            this.txtPaidAmt.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaidAmt.Name = "txtPaidAmt";
            this.txtPaidAmt.Size = new System.Drawing.Size(177, 33);
            this.txtPaidAmt.TabIndex = 47;
            this.txtPaidAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaidAmt.OnValueChanged += new System.EventHandler(this.txtPaidAmt_OnValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(26, 178);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 17);
            this.label20.TabIndex = 48;
            this.label20.Text = "Paid Amt. :";
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReturnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtReturnAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReturnAmount.HintForeColor = System.Drawing.Color.Navy;
            this.txtReturnAmount.HintText = "      Return Amount";
            this.txtReturnAmount.isPassword = false;
            this.txtReturnAmount.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtReturnAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtReturnAmount.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtReturnAmount.LineThickness = 3;
            this.txtReturnAmount.Location = new System.Drawing.Point(103, 192);
            this.txtReturnAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(177, 33);
            this.txtReturnAmount.TabIndex = 46;
            this.txtReturnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGrandTotal.HintForeColor = System.Drawing.Color.Navy;
            this.txtGrandTotal.HintText = "         Grand Total";
            this.txtGrandTotal.isPassword = false;
            this.txtGrandTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtGrandTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGrandTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtGrandTotal.LineThickness = 3;
            this.txtGrandTotal.Location = new System.Drawing.Point(103, 121);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(177, 33);
            this.txtGrandTotal.TabIndex = 46;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVAT
            // 
            this.txtVAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtVAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVAT.HintForeColor = System.Drawing.Color.Navy;
            this.txtVAT.HintText = "             VAT %";
            this.txtVAT.isPassword = false;
            this.txtVAT.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtVAT.LineIdleColor = System.Drawing.Color.Gray;
            this.txtVAT.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtVAT.LineThickness = 3;
            this.txtVAT.Location = new System.Drawing.Point(103, 85);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(177, 33);
            this.txtVAT.TabIndex = 46;
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVAT.OnValueChanged += new System.EventHandler(this.txtVAT_OnValueChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.HintForeColor = System.Drawing.Color.Navy;
            this.txtDiscount.HintText = "            Discount";
            this.txtDiscount.isPassword = false;
            this.txtDiscount.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiscount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDiscount.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiscount.LineThickness = 3;
            this.txtDiscount.Location = new System.Drawing.Point(104, 48);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(177, 33);
            this.txtDiscount.TabIndex = 46;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.OnValueChanged += new System.EventHandler(this.txtDiscount_OnValueChanged);
            // 
            // btnSaveCal
            // 
            this.btnSaveCal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveCal.BackColor = System.Drawing.Color.Teal;
            this.btnSaveCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveCal.BorderRadius = 0;
            this.btnSaveCal.ButtonText = "    Click To Save";
            this.btnSaveCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCal.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveCal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveCal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveCal.Iconimage")));
            this.btnSaveCal.Iconimage_right = null;
            this.btnSaveCal.Iconimage_right_Selected = null;
            this.btnSaveCal.Iconimage_Selected = null;
            this.btnSaveCal.IconMarginLeft = 0;
            this.btnSaveCal.IconMarginRight = 0;
            this.btnSaveCal.IconRightVisible = true;
            this.btnSaveCal.IconRightZoom = 0D;
            this.btnSaveCal.IconVisible = true;
            this.btnSaveCal.IconZoom = 90D;
            this.btnSaveCal.IsTab = false;
            this.btnSaveCal.Location = new System.Drawing.Point(104, 245);
            this.btnSaveCal.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCal.Name = "btnSaveCal";
            this.btnSaveCal.Normalcolor = System.Drawing.Color.Teal;
            this.btnSaveCal.OnHovercolor = System.Drawing.Color.Navy;
            this.btnSaveCal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveCal.selected = false;
            this.btnSaveCal.Size = new System.Drawing.Size(177, 33);
            this.btnSaveCal.TabIndex = 18;
            this.btnSaveCal.Text = "    Click To Save";
            this.btnSaveCal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCal.Textcolor = System.Drawing.Color.White;
            this.btnSaveCal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCal.Click += new System.EventHandler(this.btnSaveCal_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(13, 208);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 17);
            this.label21.TabIndex = 46;
            this.label21.Text = "Return Amt. :";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.HintForeColor = System.Drawing.Color.Navy;
            this.txtSubTotal.HintText = "         Sub Total ";
            this.txtSubTotal.isPassword = false;
            this.txtSubTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSubTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSubTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSubTotal.LineThickness = 3;
            this.txtSubTotal.Location = new System.Drawing.Point(104, 13);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(177, 33);
            this.txtSubTotal.TabIndex = 46;
            this.txtSubTotal.Text = " ";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(13, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 17);
            this.label19.TabIndex = 46;
            this.label19.Text = "Grand Total :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(36, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 46;
            this.label18.Text = "Vat (%) :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(27, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 17);
            this.label17.TabIndex = 46;
            this.label17.Text = "Discnt (%) :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(28, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 17);
            this.label16.TabIndex = 46;
            this.label16.Text = "Sub Total :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(16, -5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Calculation Details";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblStorePhone);
            this.panel5.Controls.Add(this.lblStoreAddress);
            this.panel5.Controls.Add(this.lblStoreName);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.GDVCustomer);
            this.panel5.Location = new System.Drawing.Point(12, 271);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(446, 283);
            this.panel5.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, -4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Added Products";
            // 
            // GDVCustomer
            // 
            this.GDVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVCustomer.Location = new System.Drawing.Point(3, 16);
            this.GDVCustomer.Name = "GDVCustomer";
            this.GDVCustomer.Size = new System.Drawing.Size(440, 263);
            this.GDVCustomer.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtPrdctQty);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtPrdctInventory);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.btnAddPrdct);
            this.panel4.Controls.Add(this.txtProductRate);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtPrdctSearch);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtPrdctName);
            this.panel4.Location = new System.Drawing.Point(12, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(744, 105);
            this.panel4.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(480, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 50;
            this.label14.Text = "Quantity :";
            // 
            // txtPrdctQty
            // 
            this.txtPrdctQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrdctQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrdctQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrdctQty.HintForeColor = System.Drawing.Color.Navy;
            this.txtPrdctQty.HintText = "Enter Product Quantity";
            this.txtPrdctQty.isPassword = false;
            this.txtPrdctQty.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrdctQty.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrdctQty.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrdctQty.LineThickness = 3;
            this.txtPrdctQty.Location = new System.Drawing.Point(560, 14);
            this.txtPrdctQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdctQty.Name = "txtPrdctQty";
            this.txtPrdctQty.Size = new System.Drawing.Size(160, 33);
            this.txtPrdctQty.TabIndex = 49;
            this.txtPrdctQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(242, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 48;
            this.label11.Text = "Inventory : ";
            // 
            // txtPrdctInventory
            // 
            this.txtPrdctInventory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrdctInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrdctInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrdctInventory.HintForeColor = System.Drawing.Color.Navy;
            this.txtPrdctInventory.HintText = "      Enter Inventory";
            this.txtPrdctInventory.isPassword = false;
            this.txtPrdctInventory.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrdctInventory.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrdctInventory.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrdctInventory.LineThickness = 3;
            this.txtPrdctInventory.Location = new System.Drawing.Point(317, 14);
            this.txtPrdctInventory.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdctInventory.Name = "txtPrdctInventory";
            this.txtPrdctInventory.Size = new System.Drawing.Size(144, 33);
            this.txtPrdctInventory.TabIndex = 47;
            this.txtPrdctInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(267, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Rate :";
            // 
            // btnAddPrdct
            // 
            this.btnAddPrdct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddPrdct.BackColor = System.Drawing.Color.Teal;
            this.btnAddPrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPrdct.BorderRadius = 0;
            this.btnAddPrdct.ButtonText = "    Click To Add";
            this.btnAddPrdct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPrdct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPrdct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPrdct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPrdct.Iconimage")));
            this.btnAddPrdct.Iconimage_right = null;
            this.btnAddPrdct.Iconimage_right_Selected = null;
            this.btnAddPrdct.Iconimage_Selected = null;
            this.btnAddPrdct.IconMarginLeft = 0;
            this.btnAddPrdct.IconMarginRight = 0;
            this.btnAddPrdct.IconRightVisible = true;
            this.btnAddPrdct.IconRightZoom = 0D;
            this.btnAddPrdct.IconVisible = true;
            this.btnAddPrdct.IconZoom = 90D;
            this.btnAddPrdct.IsTab = false;
            this.btnAddPrdct.Location = new System.Drawing.Point(543, 61);
            this.btnAddPrdct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPrdct.Name = "btnAddPrdct";
            this.btnAddPrdct.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddPrdct.OnHovercolor = System.Drawing.Color.Navy;
            this.btnAddPrdct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPrdct.selected = false;
            this.btnAddPrdct.Size = new System.Drawing.Size(177, 33);
            this.btnAddPrdct.TabIndex = 18;
            this.btnAddPrdct.Text = "    Click To Add";
            this.btnAddPrdct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPrdct.Textcolor = System.Drawing.Color.White;
            this.btnAddPrdct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrdct.Click += new System.EventHandler(this.btnAddPrdct_Click);
            // 
            // txtProductRate
            // 
            this.txtProductRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtProductRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductRate.HintForeColor = System.Drawing.Color.Navy;
            this.txtProductRate.HintText = "       Enter Rate";
            this.txtProductRate.isPassword = false;
            this.txtProductRate.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductRate.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductRate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductRate.LineThickness = 3;
            this.txtProductRate.Location = new System.Drawing.Point(317, 61);
            this.txtProductRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductRate.Name = "txtProductRate";
            this.txtProductRate.Size = new System.Drawing.Size(144, 33);
            this.txtProductRate.TabIndex = 45;
            this.txtProductRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, -5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Product Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Search : ";
            // 
            // txtPrdctSearch
            // 
            this.txtPrdctSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrdctSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrdctSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrdctSearch.HintForeColor = System.Drawing.Color.Navy;
            this.txtPrdctSearch.HintText = "Enter To Search User";
            this.txtPrdctSearch.isPassword = false;
            this.txtPrdctSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrdctSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrdctSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrdctSearch.LineThickness = 3;
            this.txtPrdctSearch.Location = new System.Drawing.Point(85, 14);
            this.txtPrdctSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdctSearch.Name = "txtPrdctSearch";
            this.txtPrdctSearch.Size = new System.Drawing.Size(160, 33);
            this.txtPrdctSearch.TabIndex = 43;
            this.txtPrdctSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrdctSearch.OnValueChanged += new System.EventHandler(this.txtPrdctSearch_OnValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(22, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Name :";
            // 
            // txtPrdctName
            // 
            this.txtPrdctName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrdctName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrdctName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrdctName.HintForeColor = System.Drawing.Color.Navy;
            this.txtPrdctName.HintText = "     Customer Name";
            this.txtPrdctName.isPassword = false;
            this.txtPrdctName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrdctName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrdctName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrdctName.LineThickness = 3;
            this.txtPrdctName.Location = new System.Drawing.Point(85, 61);
            this.txtPrdctName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdctName.Name = "txtPrdctName";
            this.txtPrdctName.Size = new System.Drawing.Size(160, 33);
            this.txtPrdctName.TabIndex = 41;
            this.txtPrdctName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BillDatePicker);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDeaCustSearch);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEMail);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(12, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 114);
            this.panel2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Dealer And Customer Details";
            // 
            // BillDatePicker
            // 
            this.BillDatePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.BillDatePicker.BorderRadius = 0;
            this.BillDatePicker.ForeColor = System.Drawing.Color.White;
            this.BillDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BillDatePicker.FormatCustom = null;
            this.BillDatePicker.Location = new System.Drawing.Point(543, 70);
            this.BillDatePicker.Name = "BillDatePicker";
            this.BillDatePicker.Size = new System.Drawing.Size(177, 33);
            this.BillDatePicker.TabIndex = 41;
            this.BillDatePicker.Value = new System.DateTime(2018, 7, 21, 20, 48, 23, 632);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Search : ";
            // 
            // txtDeaCustSearch
            // 
            this.txtDeaCustSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeaCustSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDeaCustSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDeaCustSearch.HintForeColor = System.Drawing.Color.Navy;
            this.txtDeaCustSearch.HintText = "Enter To Search User";
            this.txtDeaCustSearch.isPassword = false;
            this.txtDeaCustSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDeaCustSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDeaCustSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDeaCustSearch.LineThickness = 3;
            this.txtDeaCustSearch.Location = new System.Drawing.Point(99, 12);
            this.txtDeaCustSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeaCustSearch.Name = "txtDeaCustSearch";
            this.txtDeaCustSearch.Size = new System.Drawing.Size(146, 33);
            this.txtDeaCustSearch.TabIndex = 39;
            this.txtDeaCustSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeaCustSearch.OnValueChanged += new System.EventHandler(this.txtDeaCustSearch_OnValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(246, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Contact :";
            // 
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContact.HintForeColor = System.Drawing.Color.Navy;
            this.txtContact.HintText = "           Contact Number";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtContact.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtContact.LineThickness = 3;
            this.txtContact.Location = new System.Drawing.Point(317, 74);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(144, 33);
            this.txtContact.TabIndex = 37;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(254, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "E-Mail :";
            // 
            // txtEMail
            // 
            this.txtEMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEMail.HintForeColor = System.Drawing.Color.Navy;
            this.txtEMail.HintText = "      E-Mail Address";
            this.txtEMail.isPassword = false;
            this.txtEMail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEMail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEMail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEMail.LineThickness = 3;
            this.txtEMail.Location = new System.Drawing.Point(317, 14);
            this.txtEMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(144, 33);
            this.txtEMail.TabIndex = 35;
            this.txtEMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Teal;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(543, 14);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(177, 45);
            this.txtAddress.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(467, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Bill Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(471, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Address : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(36, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Navy;
            this.txtName.HintText = "       Customer Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(99, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 33);
            this.txtName.TabIndex = 30;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 29);
            this.panel1.TabIndex = 8;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(146, 85);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(0, 21);
            this.lblStoreName.TabIndex = 22;
            this.lblStoreName.Visible = false;
            // 
            // lblStoreAddress
            // 
            this.lblStoreAddress.AutoSize = true;
            this.lblStoreAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreAddress.Location = new System.Drawing.Point(141, 104);
            this.lblStoreAddress.Name = "lblStoreAddress";
            this.lblStoreAddress.Size = new System.Drawing.Size(0, 17);
            this.lblStoreAddress.TabIndex = 23;
            // 
            // lblStorePhone
            // 
            this.lblStorePhone.AutoSize = true;
            this.lblStorePhone.BackColor = System.Drawing.Color.Transparent;
            this.lblStorePhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorePhone.Location = new System.Drawing.Point(99, 121);
            this.lblStorePhone.Name = "lblStorePhone";
            this.lblStorePhone.Size = new System.Drawing.Size(0, 17);
            this.lblStorePhone.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPurchaseAndSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 562);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPurchaseAndSale";
            this.Text = "FrmPurchaseAndSale";
            this.Load += new System.EventHandler(this.FrmPurchaseAndSale_Load);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVCustomer)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtReturnAmount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGrandTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVAT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiscount;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSubTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView GDVCustomer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrdctQty;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrdctInventory;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPrdct;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrdctSearch;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrdctName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDatepicker BillDatePicker;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDeaCustSearch;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEMail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveCal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPaidAmt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreAddress;
        private System.Windows.Forms.Label lblStorePhone;
        private System.Windows.Forms.Button button1;
    }
}