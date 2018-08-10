namespace POS_System.UI
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.GDVusers = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbUserType = new MetroFramework.Controls.MetroComboBox();
            this.cmbGender = new MetroFramework.Controls.MetroComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVusers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.Teal;
            this.pnlUsers.Controls.Add(this.panel1);
            this.pnlUsers.Controls.Add(this.GDVusers);
            this.pnlUsers.Controls.Add(this.label11);
            this.pnlUsers.Controls.Add(this.label10);
            this.pnlUsers.Controls.Add(this.label9);
            this.pnlUsers.Controls.Add(this.label8);
            this.pnlUsers.Controls.Add(this.label7);
            this.pnlUsers.Controls.Add(this.label6);
            this.pnlUsers.Controls.Add(this.label5);
            this.pnlUsers.Controls.Add(this.label4);
            this.pnlUsers.Controls.Add(this.label3);
            this.pnlUsers.Controls.Add(this.label12);
            this.pnlUsers.Controls.Add(this.label2);
            this.pnlUsers.Controls.Add(this.btnDeleteUser);
            this.pnlUsers.Controls.Add(this.btnUpdateUser);
            this.pnlUsers.Controls.Add(this.btnAddUser);
            this.pnlUsers.Controls.Add(this.cmbUserType);
            this.pnlUsers.Controls.Add(this.cmbGender);
            this.pnlUsers.Controls.Add(this.txtAddress);
            this.pnlUsers.Controls.Add(this.txtContact);
            this.pnlUsers.Controls.Add(this.txtEMail);
            this.pnlUsers.Controls.Add(this.txtPassword);
            this.pnlUsers.Controls.Add(this.txtLName);
            this.pnlUsers.Controls.Add(this.txtSearch);
            this.pnlUsers.Controls.Add(this.txtUserName);
            this.pnlUsers.Controls.Add(this.txtFName);
            this.pnlUsers.Controls.Add(this.txtUserId);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsers.Location = new System.Drawing.Point(0, 0);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(596, 502);
            this.pnlUsers.TabIndex = 4;
            // 
            // GDVusers
            // 
            this.GDVusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVusers.Location = new System.Drawing.Point(17, 335);
            this.GDVusers.Name = "GDVusers";
            this.GDVusers.Size = new System.Drawing.Size(560, 121);
            this.GDVusers.TabIndex = 5;
            this.GDVusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDVusers_CellContentClick);
            this.GDVusers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GDVusers_RowHeaderMouseDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(14, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "User Tupe : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(29, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Gender :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(325, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(29, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Contact :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(315, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(7, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "UserName :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(330, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(305, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(295, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Search : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Id : ";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteUser.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteUser.BorderRadius = 0;
            this.btnDeleteUser.ButtonText = "Click To Delete User";
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Iconimage")));
            this.btnDeleteUser.Iconimage_right = null;
            this.btnDeleteUser.Iconimage_right_Selected = null;
            this.btnDeleteUser.Iconimage_Selected = null;
            this.btnDeleteUser.IconMarginLeft = 0;
            this.btnDeleteUser.IconMarginRight = 0;
            this.btnDeleteUser.IconRightVisible = true;
            this.btnDeleteUser.IconRightZoom = 0D;
            this.btnDeleteUser.IconVisible = true;
            this.btnDeleteUser.IconZoom = 90D;
            this.btnDeleteUser.IsTab = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(400, 462);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Normalcolor = System.Drawing.Color.Teal;
            this.btnDeleteUser.OnHovercolor = System.Drawing.Color.Navy;
            this.btnDeleteUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteUser.selected = false;
            this.btnDeleteUser.Size = new System.Drawing.Size(177, 33);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Click To Delete User";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Textcolor = System.Drawing.Color.White;
            this.btnDeleteUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateUser.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateUser.BorderRadius = 0;
            this.btnUpdateUser.ButtonText = "Click to Update User";
            this.btnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.Iconimage")));
            this.btnUpdateUser.Iconimage_right = null;
            this.btnUpdateUser.Iconimage_right_Selected = null;
            this.btnUpdateUser.Iconimage_Selected = null;
            this.btnUpdateUser.IconMarginLeft = 0;
            this.btnUpdateUser.IconMarginRight = 0;
            this.btnUpdateUser.IconRightVisible = true;
            this.btnUpdateUser.IconRightZoom = 0D;
            this.btnUpdateUser.IconVisible = true;
            this.btnUpdateUser.IconZoom = 90D;
            this.btnUpdateUser.IsTab = false;
            this.btnUpdateUser.Location = new System.Drawing.Point(99, 462);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Normalcolor = System.Drawing.Color.Teal;
            this.btnUpdateUser.OnHovercolor = System.Drawing.Color.Navy;
            this.btnUpdateUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateUser.selected = false;
            this.btnUpdateUser.Size = new System.Drawing.Size(177, 33);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "Click to Update User";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Textcolor = System.Drawing.Color.White;
            this.btnUpdateUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.BackColor = System.Drawing.Color.Teal;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.BorderRadius = 0;
            this.btnAddUser.ButtonText = "Click To Add User";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Iconimage")));
            this.btnAddUser.Iconimage_right = null;
            this.btnAddUser.Iconimage_right_Selected = null;
            this.btnAddUser.Iconimage_Selected = null;
            this.btnAddUser.IconMarginLeft = 0;
            this.btnAddUser.IconMarginRight = 0;
            this.btnAddUser.IconRightVisible = true;
            this.btnAddUser.IconRightZoom = 0D;
            this.btnAddUser.IconVisible = true;
            this.btnAddUser.IconZoom = 90D;
            this.btnAddUser.IsTab = false;
            this.btnAddUser.Location = new System.Drawing.Point(99, 295);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddUser.OnHovercolor = System.Drawing.Color.Navy;
            this.btnAddUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddUser.selected = false;
            this.btnAddUser.Size = new System.Drawing.Size(177, 33);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Click To Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Textcolor = System.Drawing.Color.White;
            this.btnAddUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.ItemHeight = 23;
            this.cmbUserType.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cmbUserType.Location = new System.Drawing.Point(99, 246);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(177, 29);
            this.cmbUserType.TabIndex = 2;
            this.cmbUserType.UseSelectable = true;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 23;
            this.cmbGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.cmbGender.Location = new System.Drawing.Point(99, 211);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(177, 29);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.UseSelectable = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Teal;
            this.txtAddress.Location = new System.Drawing.Point(400, 166);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(177, 109);
            this.txtAddress.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContact.HintForeColor = System.Drawing.Color.Navy;
            this.txtContact.HintText = "Enter Contact No.";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtContact.LineIdleColor = System.Drawing.Color.Gray;
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtContact.LineThickness = 3;
            this.txtContact.Location = new System.Drawing.Point(99, 167);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(177, 33);
            this.txtContact.TabIndex = 0;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEMail
            // 
            this.txtEMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEMail.HintForeColor = System.Drawing.Color.Navy;
            this.txtEMail.HintText = "Enter EMail Address";
            this.txtEMail.isPassword = false;
            this.txtEMail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEMail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEMail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEMail.LineThickness = 3;
            this.txtEMail.Location = new System.Drawing.Point(400, 85);
            this.txtEMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(177, 33);
            this.txtEMail.TabIndex = 0;
            this.txtEMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Navy;
            this.txtPassword.HintText = "Enter Password";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(400, 126);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 33);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLName
            // 
            this.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLName.HintForeColor = System.Drawing.Color.Navy;
            this.txtLName.HintText = "Enter Last Name";
            this.txtLName.isPassword = false;
            this.txtLName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLName.LineThickness = 3;
            this.txtLName.Location = new System.Drawing.Point(99, 85);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(177, 33);
            this.txtLName.TabIndex = 0;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtSearch.Location = new System.Drawing.Point(365, 295);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 33);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HintForeColor = System.Drawing.Color.Navy;
            this.txtUserName.HintText = "Enter UserName";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUserName.LineThickness = 3;
            this.txtUserName.Location = new System.Drawing.Point(99, 126);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(177, 33);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFName
            // 
            this.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFName.HintForeColor = System.Drawing.Color.Navy;
            this.txtFName.HintText = "Enter First Name";
            this.txtFName.isPassword = false;
            this.txtFName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFName.LineThickness = 3;
            this.txtFName.Location = new System.Drawing.Point(400, 44);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(177, 33);
            this.txtFName.TabIndex = 0;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserId
            // 
            this.txtUserId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserId.HintForeColor = System.Drawing.Color.Navy;
            this.txtUserId.HintText = "Enter User ID";
            this.txtUserId.isPassword = false;
            this.txtUserId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUserId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUserId.LineThickness = 3;
            this.txtUserId.Location = new System.Drawing.Point(99, 44);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(177, 33);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 29);
            this.panel1.TabIndex = 7;
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
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 502);
            this.Controls.Add(this.pnlUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVusers)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.DataGridView GDVusers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddUser;
        private MetroFramework.Controls.MetroComboBox cmbUserType;
        private MetroFramework.Controls.MetroComboBox cmbGender;
        private System.Windows.Forms.TextBox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEMail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserId;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}