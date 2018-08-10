namespace POS_System.UI
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductRate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.btnDeletePrdct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateprdct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GDVProduct = new System.Windows.Forms.DataGridView();
            this.btnAddPrdct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrdctID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtProductRate);
            this.panel3.Controls.Add(this.cmbCategory);
            this.panel3.Controls.Add(this.btnDeletePrdct);
            this.panel3.Controls.Add(this.btnUpdateprdct);
            this.panel3.Controls.Add(this.GDVProduct);
            this.panel3.Controls.Add(this.btnAddPrdct);
            this.panel3.Controls.Add(this.txtDesc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.txtPrdctID);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 534);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(335, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Rate :";
            // 
            // txtProductRate
            // 
            this.txtProductRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtProductRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductRate.HintForeColor = System.Drawing.Color.Navy;
            this.txtProductRate.HintText = "Enter Product Rate";
            this.txtProductRate.isPassword = false;
            this.txtProductRate.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProductRate.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProductRate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProductRate.LineThickness = 3;
            this.txtProductRate.Location = new System.Drawing.Point(398, 164);
            this.txtProductRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductRate.Name = "txtProductRate";
            this.txtProductRate.Size = new System.Drawing.Size(177, 33);
            this.txtProductRate.TabIndex = 23;
            this.txtProductRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(117, 168);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(177, 29);
            this.cmbCategory.TabIndex = 22;
            this.cmbCategory.UseSelectable = true;
            // 
            // btnDeletePrdct
            // 
            this.btnDeletePrdct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeletePrdct.BackColor = System.Drawing.Color.Teal;
            this.btnDeletePrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePrdct.BorderRadius = 0;
            this.btnDeletePrdct.ButtonText = "Click To Delete product";
            this.btnDeletePrdct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePrdct.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeletePrdct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeletePrdct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeletePrdct.Iconimage")));
            this.btnDeletePrdct.Iconimage_right = null;
            this.btnDeletePrdct.Iconimage_right_Selected = null;
            this.btnDeletePrdct.Iconimage_Selected = null;
            this.btnDeletePrdct.IconMarginLeft = 0;
            this.btnDeletePrdct.IconMarginRight = 0;
            this.btnDeletePrdct.IconRightVisible = true;
            this.btnDeletePrdct.IconRightZoom = 0D;
            this.btnDeletePrdct.IconVisible = true;
            this.btnDeletePrdct.IconZoom = 90D;
            this.btnDeletePrdct.IsTab = false;
            this.btnDeletePrdct.Location = new System.Drawing.Point(333, 472);
            this.btnDeletePrdct.Name = "btnDeletePrdct";
            this.btnDeletePrdct.Normalcolor = System.Drawing.Color.Teal;
            this.btnDeletePrdct.OnHovercolor = System.Drawing.Color.Navy;
            this.btnDeletePrdct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletePrdct.selected = false;
            this.btnDeletePrdct.Size = new System.Drawing.Size(202, 33);
            this.btnDeletePrdct.TabIndex = 20;
            this.btnDeletePrdct.Text = "Click To Delete product";
            this.btnDeletePrdct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePrdct.Textcolor = System.Drawing.Color.White;
            this.btnDeletePrdct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePrdct.Click += new System.EventHandler(this.btnDeletePrdct_Click);
            // 
            // btnUpdateprdct
            // 
            this.btnUpdateprdct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateprdct.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateprdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateprdct.BorderRadius = 0;
            this.btnUpdateprdct.ButtonText = "Click to Update Product";
            this.btnUpdateprdct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateprdct.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateprdct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateprdct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateprdct.Iconimage")));
            this.btnUpdateprdct.Iconimage_right = null;
            this.btnUpdateprdct.Iconimage_right_Selected = null;
            this.btnUpdateprdct.Iconimage_Selected = null;
            this.btnUpdateprdct.IconMarginLeft = 0;
            this.btnUpdateprdct.IconMarginRight = 0;
            this.btnUpdateprdct.IconRightVisible = true;
            this.btnUpdateprdct.IconRightZoom = 0D;
            this.btnUpdateprdct.IconVisible = true;
            this.btnUpdateprdct.IconZoom = 90D;
            this.btnUpdateprdct.IsTab = false;
            this.btnUpdateprdct.Location = new System.Drawing.Point(57, 472);
            this.btnUpdateprdct.Name = "btnUpdateprdct";
            this.btnUpdateprdct.Normalcolor = System.Drawing.Color.Teal;
            this.btnUpdateprdct.OnHovercolor = System.Drawing.Color.Navy;
            this.btnUpdateprdct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateprdct.selected = false;
            this.btnUpdateprdct.Size = new System.Drawing.Size(198, 33);
            this.btnUpdateprdct.TabIndex = 21;
            this.btnUpdateprdct.Text = "Click to Update Product";
            this.btnUpdateprdct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateprdct.Textcolor = System.Drawing.Color.White;
            this.btnUpdateprdct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateprdct.Click += new System.EventHandler(this.btnUpdateprdct_Click);
            // 
            // GDVProduct
            // 
            this.GDVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVProduct.Location = new System.Drawing.Point(23, 256);
            this.GDVProduct.Name = "GDVProduct";
            this.GDVProduct.Size = new System.Drawing.Size(560, 181);
            this.GDVProduct.TabIndex = 19;
            this.GDVProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GDVProduct_RowHeaderMouseClick);
            // 
            // btnAddPrdct
            // 
            this.btnAddPrdct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddPrdct.BackColor = System.Drawing.Color.Teal;
            this.btnAddPrdct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPrdct.BorderRadius = 0;
            this.btnAddPrdct.ButtonText = "Click To Add Product";
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
            this.btnAddPrdct.Location = new System.Drawing.Point(57, 217);
            this.btnAddPrdct.Name = "btnAddPrdct";
            this.btnAddPrdct.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddPrdct.OnHovercolor = System.Drawing.Color.Navy;
            this.btnAddPrdct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPrdct.selected = false;
            this.btnAddPrdct.Size = new System.Drawing.Size(177, 33);
            this.btnAddPrdct.TabIndex = 18;
            this.btnAddPrdct.Text = "Click To Add Product";
            this.btnAddPrdct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPrdct.Textcolor = System.Drawing.Color.White;
            this.btnAddPrdct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrdct.Click += new System.EventHandler(this.btnAddPrdct_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.Teal;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(398, 52);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(177, 81);
            this.txtDesc.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(301, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Description : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(301, 226);
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
            this.txtSearch.Location = new System.Drawing.Point(371, 210);
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
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(54, 109);
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
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product ID : ";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Navy;
            this.txtName.HintText = "Enter Product Name";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(117, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 33);
            this.txtName.TabIndex = 9;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrdctID
            // 
            this.txtPrdctID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrdctID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrdctID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrdctID.HintForeColor = System.Drawing.Color.Navy;
            this.txtPrdctID.HintText = "Enter Product ID";
            this.txtPrdctID.isPassword = false;
            this.txtPrdctID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrdctID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrdctID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrdctID.LineThickness = 3;
            this.txtPrdctID.Location = new System.Drawing.Point(117, 52);
            this.txtPrdctID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrdctID.Name = "txtPrdctID";
            this.txtPrdctID.Size = new System.Drawing.Size(177, 33);
            this.txtPrdctID.TabIndex = 11;
            this.txtPrdctID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 534);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletePrdct;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateprdct;
        private System.Windows.Forms.DataGridView GDVProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddPrdct;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrdctID;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtProductRate;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
    }
}