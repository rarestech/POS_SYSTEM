namespace POS_System.UI
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
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
            this.panel3.Controls.Add(this.btnShowAll);
            this.panel3.Controls.Add(this.cmbCategory);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dgvInventory);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(-9, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 562);
            this.panel3.TabIndex = 14;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowAll.BackColor = System.Drawing.Color.Teal;
            this.btnShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAll.BorderRadius = 0;
            this.btnShowAll.ButtonText = "    Click To Show All";
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Iconimage")));
            this.btnShowAll.Iconimage_right = null;
            this.btnShowAll.Iconimage_right_Selected = null;
            this.btnShowAll.Iconimage_Selected = null;
            this.btnShowAll.IconMarginLeft = 0;
            this.btnShowAll.IconMarginRight = 0;
            this.btnShowAll.IconRightVisible = true;
            this.btnShowAll.IconRightZoom = 0D;
            this.btnShowAll.IconVisible = true;
            this.btnShowAll.IconZoom = 90D;
            this.btnShowAll.IsTab = false;
            this.btnShowAll.Location = new System.Drawing.Point(388, 69);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Normalcolor = System.Drawing.Color.Teal;
            this.btnShowAll.OnHovercolor = System.Drawing.Color.Navy;
            this.btnShowAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowAll.selected = false;
            this.btnShowAll.Size = new System.Drawing.Size(177, 33);
            this.btnShowAll.TabIndex = 19;
            this.btnShowAll.Text = "    Click To Show All";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Textcolor = System.Drawing.Color.White;
            this.btnShowAll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Items.AddRange(new object[] {
            "Purchase",
            "Sales"});
            this.cmbCategory.Location = new System.Drawing.Point(170, 69);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(202, 29);
            this.cmbCategory.TabIndex = 11;
            this.cmbCategory.UseSelectable = true;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category Type :";
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(8, 118);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(754, 394);
            this.dgvInventory.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 29);
            this.panel1.TabIndex = 8;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 562);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowAll;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvInventory;
    }
}