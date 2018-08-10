namespace POS_System.UI
{
    partial class FrmDealCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDealCustomer));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbtype = new MetroFramework.Controls.MetroComboBox();
            this.btnDeleteCust = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateCust = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GDVCustomer = new System.Windows.Forms.DataGridView();
            this.btnAddCust = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCustID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtContact);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtEMail);
            this.panel3.Controls.Add(this.cmbtype);
            this.panel3.Controls.Add(this.btnDeleteCust);
            this.panel3.Controls.Add(this.btnUpdateCust);
            this.panel3.Controls.Add(this.GDVCustomer);
            this.panel3.Controls.Add(this.btnAddCust);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.txtCustID);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 505);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(54, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Contact :";
            // 
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContact.HintForeColor = System.Drawing.Color.Navy;
            this.txtContact.HintText = "Enter Contact Number";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtContact.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtContact.LineThickness = 3;
            this.txtContact.Location = new System.Drawing.Point(117, 207);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(177, 33);
            this.txtContact.TabIndex = 25;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(319, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "E-Mail :";
            // 
            // txtEMail
            // 
            this.txtEMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEMail.HintForeColor = System.Drawing.Color.Navy;
            this.txtEMail.HintText = "Enter E-Mail";
            this.txtEMail.isPassword = false;
            this.txtEMail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEMail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEMail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEMail.LineThickness = 3;
            this.txtEMail.Location = new System.Drawing.Point(382, 52);
            this.txtEMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(177, 33);
            this.txtEMail.TabIndex = 23;
            this.txtEMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.ItemHeight = 23;
            this.cmbtype.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmbtype.Location = new System.Drawing.Point(117, 166);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(177, 29);
            this.cmbtype.TabIndex = 22;
            this.cmbtype.UseSelectable = true;
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteCust.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCust.BorderRadius = 0;
            this.btnDeleteCust.ButtonText = "Click To Delete Customer";
            this.btnDeleteCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCust.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteCust.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteCust.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCust.Iconimage")));
            this.btnDeleteCust.Iconimage_right = null;
            this.btnDeleteCust.Iconimage_right_Selected = null;
            this.btnDeleteCust.Iconimage_Selected = null;
            this.btnDeleteCust.IconMarginLeft = 0;
            this.btnDeleteCust.IconMarginRight = 0;
            this.btnDeleteCust.IconRightVisible = true;
            this.btnDeleteCust.IconRightZoom = 0D;
            this.btnDeleteCust.IconVisible = true;
            this.btnDeleteCust.IconZoom = 90D;
            this.btnDeleteCust.IsTab = false;
            this.btnDeleteCust.Location = new System.Drawing.Point(333, 467);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Normalcolor = System.Drawing.Color.Teal;
            this.btnDeleteCust.OnHovercolor = System.Drawing.Color.Navy;
            this.btnDeleteCust.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteCust.selected = false;
            this.btnDeleteCust.Size = new System.Drawing.Size(202, 33);
            this.btnDeleteCust.TabIndex = 20;
            this.btnDeleteCust.Text = "Click To Delete Customer";
            this.btnDeleteCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCust.Textcolor = System.Drawing.Color.White;
            this.btnDeleteCust.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateCust.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCust.BorderRadius = 0;
            this.btnUpdateCust.ButtonText = "Click to Update Customer";
            this.btnUpdateCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCust.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateCust.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateCust.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCust.Iconimage")));
            this.btnUpdateCust.Iconimage_right = null;
            this.btnUpdateCust.Iconimage_right_Selected = null;
            this.btnUpdateCust.Iconimage_Selected = null;
            this.btnUpdateCust.IconMarginLeft = 0;
            this.btnUpdateCust.IconMarginRight = 0;
            this.btnUpdateCust.IconRightVisible = true;
            this.btnUpdateCust.IconRightZoom = 0D;
            this.btnUpdateCust.IconVisible = true;
            this.btnUpdateCust.IconZoom = 90D;
            this.btnUpdateCust.IsTab = false;
            this.btnUpdateCust.Location = new System.Drawing.Point(57, 467);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Normalcolor = System.Drawing.Color.Teal;
            this.btnUpdateCust.OnHovercolor = System.Drawing.Color.Navy;
            this.btnUpdateCust.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateCust.selected = false;
            this.btnUpdateCust.Size = new System.Drawing.Size(198, 33);
            this.btnUpdateCust.TabIndex = 21;
            this.btnUpdateCust.Text = "Click to Update Customer";
            this.btnUpdateCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCust.Textcolor = System.Drawing.Color.White;
            this.btnUpdateCust.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // GDVCustomer
            // 
            this.GDVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVCustomer.Location = new System.Drawing.Point(23, 297);
            this.GDVCustomer.Name = "GDVCustomer";
            this.GDVCustomer.Size = new System.Drawing.Size(560, 160);
            this.GDVCustomer.TabIndex = 19;
            this.GDVCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GDVCustomer_RowHeaderMouseClick);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCust.BackColor = System.Drawing.Color.Teal;
            this.btnAddCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCust.BorderRadius = 0;
            this.btnAddCust.ButtonText = "Click To Add Customer";
            this.btnAddCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCust.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCust.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCust.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCust.Iconimage")));
            this.btnAddCust.Iconimage_right = null;
            this.btnAddCust.Iconimage_right_Selected = null;
            this.btnAddCust.Iconimage_Selected = null;
            this.btnAddCust.IconMarginLeft = 0;
            this.btnAddCust.IconMarginRight = 0;
            this.btnAddCust.IconRightVisible = true;
            this.btnAddCust.IconRightZoom = 0D;
            this.btnAddCust.IconVisible = true;
            this.btnAddCust.IconZoom = 90D;
            this.btnAddCust.IsTab = false;
            this.btnAddCust.Location = new System.Drawing.Point(33, 256);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddCust.OnHovercolor = System.Drawing.Color.Navy;
            this.btnAddCust.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCust.selected = false;
            this.btnAddCust.Size = new System.Drawing.Size(190, 33);
            this.btnAddCust.TabIndex = 18;
            this.btnAddCust.Text = "Click To Add Customer";
            this.btnAddCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCust.Textcolor = System.Drawing.Color.White;
            this.btnAddCust.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Teal;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(382, 129);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(177, 111);
            this.txtAddress.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(311, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Address : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(277, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Search : ";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Navy;
            this.txtSearch.HintText = "Enter To Search User";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(347, 249);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 33);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(34, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(54, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer ID : ";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Navy;
            this.txtName.HintText = "Enter Customer Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(117, 108);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 33);
            this.txtName.TabIndex = 9;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCustID
            // 
            this.txtCustID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCustID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCustID.HintForeColor = System.Drawing.Color.Navy;
            this.txtCustID.HintText = "Customer ID";
            this.txtCustID.isPassword = false;
            this.txtCustID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCustID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCustID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCustID.LineThickness = 3;
            this.txtCustID.Location = new System.Drawing.Point(117, 52);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(177, 33);
            this.txtCustID.TabIndex = 11;
            this.txtCustID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 29);
            this.panel1.TabIndex = 8;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(570, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(23, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FrmDealCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 505);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDealCustomer";
            this.Text = "FrmDealCustomer";
            this.Load += new System.EventHandler(this.FrmDealCustomer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEMail;
        private MetroFramework.Controls.MetroComboBox cmbtype;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteCust;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateCust;
        private System.Windows.Forms.DataGridView GDVCustomer;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCust;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustID;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
    }
}