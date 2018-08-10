namespace POS_System.UI
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GDVCategory = new System.Windows.Forms.DataGridView();
            this.btnAddCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCatID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVCategory)).BeginInit();
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
            this.panel3.Controls.Add(this.btnDeleteCat);
            this.panel3.Controls.Add(this.btnUpdateCat);
            this.panel3.Controls.Add(this.GDVCategory);
            this.panel3.Controls.Add(this.btnAddCat);
            this.panel3.Controls.Add(this.txtDesc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtTitle);
            this.panel3.Controls.Add(this.txtCatID);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 532);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteCat.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCat.BorderRadius = 0;
            this.btnDeleteCat.ButtonText = "Click To Delete Category";
            this.btnDeleteCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCat.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteCat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteCat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCat.Iconimage")));
            this.btnDeleteCat.Iconimage_right = null;
            this.btnDeleteCat.Iconimage_right_Selected = null;
            this.btnDeleteCat.Iconimage_Selected = null;
            this.btnDeleteCat.IconMarginLeft = 0;
            this.btnDeleteCat.IconMarginRight = 0;
            this.btnDeleteCat.IconRightVisible = true;
            this.btnDeleteCat.IconRightZoom = 0D;
            this.btnDeleteCat.IconVisible = true;
            this.btnDeleteCat.IconZoom = 90D;
            this.btnDeleteCat.IsTab = false;
            this.btnDeleteCat.Location = new System.Drawing.Point(333, 472);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Normalcolor = System.Drawing.Color.Teal;
            this.btnDeleteCat.OnHovercolor = System.Drawing.Color.Navy;
            this.btnDeleteCat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteCat.selected = false;
            this.btnDeleteCat.Size = new System.Drawing.Size(202, 33);
            this.btnDeleteCat.TabIndex = 20;
            this.btnDeleteCat.Text = "Click To Delete Category";
            this.btnDeleteCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCat.Textcolor = System.Drawing.Color.White;
            this.btnDeleteCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateCat.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCat.BorderRadius = 0;
            this.btnUpdateCat.ButtonText = "Click to Update Category";
            this.btnUpdateCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCat.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateCat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateCat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCat.Iconimage")));
            this.btnUpdateCat.Iconimage_right = null;
            this.btnUpdateCat.Iconimage_right_Selected = null;
            this.btnUpdateCat.Iconimage_Selected = null;
            this.btnUpdateCat.IconMarginLeft = 0;
            this.btnUpdateCat.IconMarginRight = 0;
            this.btnUpdateCat.IconRightVisible = true;
            this.btnUpdateCat.IconRightZoom = 0D;
            this.btnUpdateCat.IconVisible = true;
            this.btnUpdateCat.IconZoom = 90D;
            this.btnUpdateCat.IsTab = false;
            this.btnUpdateCat.Location = new System.Drawing.Point(57, 472);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Normalcolor = System.Drawing.Color.Teal;
            this.btnUpdateCat.OnHovercolor = System.Drawing.Color.Navy;
            this.btnUpdateCat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateCat.selected = false;
            this.btnUpdateCat.Size = new System.Drawing.Size(198, 33);
            this.btnUpdateCat.TabIndex = 21;
            this.btnUpdateCat.Text = "Click to Update Category";
            this.btnUpdateCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCat.Textcolor = System.Drawing.Color.White;
            this.btnUpdateCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // GDVCategory
            // 
            this.GDVCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDVCategory.Location = new System.Drawing.Point(23, 234);
            this.GDVCategory.Name = "GDVCategory";
            this.GDVCategory.Size = new System.Drawing.Size(560, 203);
            this.GDVCategory.TabIndex = 19;
            this.GDVCategory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GDVCategory_RowHeaderMouseClick);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddCat.BackColor = System.Drawing.Color.Teal;
            this.btnAddCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCat.BorderRadius = 0;
            this.btnAddCat.ButtonText = "Click To Add Category";
            this.btnAddCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCat.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCat.Iconimage")));
            this.btnAddCat.Iconimage_right = null;
            this.btnAddCat.Iconimage_right_Selected = null;
            this.btnAddCat.Iconimage_Selected = null;
            this.btnAddCat.IconMarginLeft = 0;
            this.btnAddCat.IconMarginRight = 0;
            this.btnAddCat.IconRightVisible = true;
            this.btnAddCat.IconRightZoom = 0D;
            this.btnAddCat.IconVisible = true;
            this.btnAddCat.IconZoom = 90D;
            this.btnAddCat.IsTab = false;
            this.btnAddCat.Location = new System.Drawing.Point(57, 169);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Normalcolor = System.Drawing.Color.Teal;
            this.btnAddCat.OnHovercolor = System.Drawing.Color.Navy;
            this.btnAddCat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCat.selected = false;
            this.btnAddCat.Size = new System.Drawing.Size(177, 33);
            this.btnAddCat.TabIndex = 18;
            this.btnAddCat.Text = "Click To Add Category";
            this.btnAddCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCat.Textcolor = System.Drawing.Color.White;
            this.btnAddCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
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
            this.label12.Location = new System.Drawing.Point(301, 178);
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
            this.txtSearch.Location = new System.Drawing.Point(371, 162);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 33);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(54, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category Id : ";
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitle.HintForeColor = System.Drawing.Color.Navy;
            this.txtTitle.HintText = "Enter Title";
            this.txtTitle.isPassword = false;
            this.txtTitle.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTitle.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTitle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTitle.LineThickness = 3;
            this.txtTitle.Location = new System.Drawing.Point(117, 93);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(177, 33);
            this.txtTitle.TabIndex = 9;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCatID
            // 
            this.txtCatID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCatID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCatID.HintForeColor = System.Drawing.Color.Navy;
            this.txtCatID.HintText = "Enter Category ID";
            this.txtCatID.isPassword = false;
            this.txtCatID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCatID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCatID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCatID.LineThickness = 3;
            this.txtCatID.Location = new System.Drawing.Point(117, 52);
            this.txtCatID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(177, 33);
            this.txtCatID.TabIndex = 11;
            this.txtCatID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 29);
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
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 532);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GDVCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCatID;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCat;
        private System.Windows.Forms.DataGridView GDVCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteCat;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateCat;
    }
}