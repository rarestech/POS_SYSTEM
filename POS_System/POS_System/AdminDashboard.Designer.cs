namespace POS_System
{
    partial class AdminDashboard
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.lblDeveloperName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.btnDeaCust = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnTransaction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnInvet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCateg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnusers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.btnHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FooterPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.Navy;
            this.FooterPanel.Controls.Add(this.lblDeveloperName);
            this.FooterPanel.Controls.Add(this.label1);
            this.PanelAnimator.SetDecoration(this.FooterPanel, BunifuAnimatorNS.DecorationType.None);
            this.FooterPanel.Location = new System.Drawing.Point(0, 565);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(813, 30);
            this.FooterPanel.TabIndex = 0;
            // 
            // lblDeveloperName
            // 
            this.lblDeveloperName.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.lblDeveloperName, BunifuAnimatorNS.DecorationType.None);
            this.lblDeveloperName.ForeColor = System.Drawing.Color.White;
            this.lblDeveloperName.Location = new System.Drawing.Point(347, 7);
            this.lblDeveloperName.Name = "lblDeveloperName";
            this.lblDeveloperName.Size = new System.Drawing.Size(98, 13);
            this.lblDeveloperName.TabIndex = 1;
            this.lblDeveloperName.Text = "Muhammad Nawaz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Developed By : ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 0.3F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // metroButton1
            // 
            this.PanelAnimator.SetDecoration(this.metroButton1, BunifuAnimatorNS.DecorationType.None);
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(719, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 19);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.sideMenu);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 506);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(177, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 506);
            this.panel3.TabIndex = 8;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sideMenu.Controls.Add(this.btnHistory);
            this.sideMenu.Controls.Add(this.btnDeaCust);
            this.sideMenu.Controls.Add(this.BtnTransaction);
            this.sideMenu.Controls.Add(this.BtnInvet);
            this.sideMenu.Controls.Add(this.BtnProducts);
            this.sideMenu.Controls.Add(this.BtnCateg);
            this.sideMenu.Controls.Add(this.btnusers);
            this.sideMenu.Controls.Add(this.bunifuImageButton2);
            this.sideMenu.Controls.Add(this.btnMenu);
            this.PanelAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(178, 506);
            this.sideMenu.TabIndex = 7;
            // 
            // btnDeaCust
            // 
            this.btnDeaCust.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnDeaCust.BackColor = System.Drawing.Color.Navy;
            this.btnDeaCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeaCust.BorderRadius = 0;
            this.btnDeaCust.ButtonText = "DEALER AND CUSTOMER";
            this.btnDeaCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnDeaCust, BunifuAnimatorNS.DecorationType.None);
            this.btnDeaCust.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeaCust.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeaCust.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeaCust.Iconimage")));
            this.btnDeaCust.Iconimage_right = null;
            this.btnDeaCust.Iconimage_right_Selected = null;
            this.btnDeaCust.Iconimage_Selected = null;
            this.btnDeaCust.IconMarginLeft = 0;
            this.btnDeaCust.IconMarginRight = 0;
            this.btnDeaCust.IconRightVisible = true;
            this.btnDeaCust.IconRightZoom = 0D;
            this.btnDeaCust.IconVisible = true;
            this.btnDeaCust.IconZoom = 90D;
            this.btnDeaCust.IsTab = true;
            this.btnDeaCust.Location = new System.Drawing.Point(2, 247);
            this.btnDeaCust.Name = "btnDeaCust";
            this.btnDeaCust.Normalcolor = System.Drawing.Color.Navy;
            this.btnDeaCust.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnDeaCust.OnHoverTextColor = System.Drawing.Color.Navy;
            this.btnDeaCust.selected = false;
            this.btnDeaCust.Size = new System.Drawing.Size(175, 36);
            this.btnDeaCust.TabIndex = 11;
            this.btnDeaCust.Text = "DEALER AND CUSTOMER";
            this.btnDeaCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeaCust.Textcolor = System.Drawing.Color.White;
            this.btnDeaCust.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeaCust.Click += new System.EventHandler(this.btnDeaCust_Click);
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BtnTransaction.BackColor = System.Drawing.Color.Navy;
            this.BtnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTransaction.BorderRadius = 0;
            this.BtnTransaction.ButtonText = "   TRANSACTIONS";
            this.BtnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnTransaction, BunifuAnimatorNS.DecorationType.None);
            this.BtnTransaction.DisabledColor = System.Drawing.Color.Gray;
            this.BtnTransaction.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnTransaction.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnTransaction.Iconimage")));
            this.BtnTransaction.Iconimage_right = null;
            this.BtnTransaction.Iconimage_right_Selected = null;
            this.BtnTransaction.Iconimage_Selected = null;
            this.BtnTransaction.IconMarginLeft = 0;
            this.BtnTransaction.IconMarginRight = 0;
            this.BtnTransaction.IconRightVisible = true;
            this.BtnTransaction.IconRightZoom = 0D;
            this.BtnTransaction.IconVisible = true;
            this.BtnTransaction.IconZoom = 90D;
            this.BtnTransaction.IsTab = true;
            this.BtnTransaction.Location = new System.Drawing.Point(3, 359);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.Normalcolor = System.Drawing.Color.Navy;
            this.BtnTransaction.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BtnTransaction.OnHoverTextColor = System.Drawing.Color.Navy;
            this.BtnTransaction.selected = false;
            this.BtnTransaction.Size = new System.Drawing.Size(175, 36);
            this.BtnTransaction.TabIndex = 6;
            this.BtnTransaction.Text = "   TRANSACTIONS";
            this.BtnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransaction.Textcolor = System.Drawing.Color.White;
            this.BtnTransaction.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // BtnInvet
            // 
            this.BtnInvet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BtnInvet.BackColor = System.Drawing.Color.Navy;
            this.BtnInvet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInvet.BorderRadius = 0;
            this.BtnInvet.ButtonText = "      INVENTORY";
            this.BtnInvet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnInvet, BunifuAnimatorNS.DecorationType.None);
            this.BtnInvet.DisabledColor = System.Drawing.Color.Gray;
            this.BtnInvet.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnInvet.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnInvet.Iconimage")));
            this.BtnInvet.Iconimage_right = null;
            this.BtnInvet.Iconimage_right_Selected = null;
            this.BtnInvet.Iconimage_Selected = null;
            this.BtnInvet.IconMarginLeft = 0;
            this.BtnInvet.IconMarginRight = 0;
            this.BtnInvet.IconRightVisible = true;
            this.BtnInvet.IconRightZoom = 0D;
            this.BtnInvet.IconVisible = true;
            this.BtnInvet.IconZoom = 90D;
            this.BtnInvet.IsTab = true;
            this.BtnInvet.Location = new System.Drawing.Point(3, 300);
            this.BtnInvet.Name = "BtnInvet";
            this.BtnInvet.Normalcolor = System.Drawing.Color.Navy;
            this.BtnInvet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BtnInvet.OnHoverTextColor = System.Drawing.Color.Navy;
            this.BtnInvet.selected = false;
            this.BtnInvet.Size = new System.Drawing.Size(175, 36);
            this.BtnInvet.TabIndex = 7;
            this.BtnInvet.Text = "      INVENTORY";
            this.BtnInvet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInvet.Textcolor = System.Drawing.Color.White;
            this.BtnInvet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvet.Click += new System.EventHandler(this.BtnInvet_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BtnProducts.BackColor = System.Drawing.Color.Navy;
            this.BtnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProducts.BorderRadius = 0;
            this.BtnProducts.ButtonText = "      PRODUCTS";
            this.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnProducts, BunifuAnimatorNS.DecorationType.None);
            this.BtnProducts.DisabledColor = System.Drawing.Color.Gray;
            this.BtnProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnProducts.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnProducts.Iconimage")));
            this.BtnProducts.Iconimage_right = null;
            this.BtnProducts.Iconimage_right_Selected = null;
            this.BtnProducts.Iconimage_Selected = null;
            this.BtnProducts.IconMarginLeft = 0;
            this.BtnProducts.IconMarginRight = 0;
            this.BtnProducts.IconRightVisible = true;
            this.BtnProducts.IconRightZoom = 0D;
            this.BtnProducts.IconVisible = true;
            this.BtnProducts.IconZoom = 90D;
            this.BtnProducts.IsTab = true;
            this.BtnProducts.Location = new System.Drawing.Point(2, 192);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Normalcolor = System.Drawing.Color.Navy;
            this.BtnProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BtnProducts.OnHoverTextColor = System.Drawing.Color.Navy;
            this.BtnProducts.selected = false;
            this.BtnProducts.Size = new System.Drawing.Size(175, 36);
            this.BtnProducts.TabIndex = 8;
            this.BtnProducts.Text = "      PRODUCTS";
            this.BtnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.Textcolor = System.Drawing.Color.White;
            this.BtnProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnCateg
            // 
            this.BtnCateg.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BtnCateg.BackColor = System.Drawing.Color.Navy;
            this.BtnCateg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCateg.BorderRadius = 0;
            this.BtnCateg.ButtonText = "     CATEGORY";
            this.BtnCateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnCateg, BunifuAnimatorNS.DecorationType.None);
            this.BtnCateg.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCateg.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCateg.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCateg.Iconimage")));
            this.BtnCateg.Iconimage_right = null;
            this.BtnCateg.Iconimage_right_Selected = null;
            this.BtnCateg.Iconimage_Selected = null;
            this.BtnCateg.IconMarginLeft = 0;
            this.BtnCateg.IconMarginRight = 0;
            this.BtnCateg.IconRightVisible = true;
            this.BtnCateg.IconRightZoom = 0D;
            this.BtnCateg.IconVisible = true;
            this.BtnCateg.IconZoom = 90D;
            this.BtnCateg.IsTab = true;
            this.BtnCateg.Location = new System.Drawing.Point(2, 139);
            this.BtnCateg.Name = "BtnCateg";
            this.BtnCateg.Normalcolor = System.Drawing.Color.Navy;
            this.BtnCateg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.BtnCateg.OnHoverTextColor = System.Drawing.Color.Navy;
            this.BtnCateg.selected = false;
            this.BtnCateg.Size = new System.Drawing.Size(175, 36);
            this.BtnCateg.TabIndex = 9;
            this.BtnCateg.Text = "     CATEGORY";
            this.BtnCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCateg.Textcolor = System.Drawing.Color.White;
            this.BtnCateg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCateg.Click += new System.EventHandler(this.BtnCateg_Click);
            // 
            // btnusers
            // 
            this.btnusers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnusers.BackColor = System.Drawing.Color.Navy;
            this.btnusers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusers.BorderRadius = 0;
            this.btnusers.ButtonText = "        USERS";
            this.btnusers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnusers, BunifuAnimatorNS.DecorationType.None);
            this.btnusers.DisabledColor = System.Drawing.Color.Gray;
            this.btnusers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnusers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnusers.Iconimage")));
            this.btnusers.Iconimage_right = null;
            this.btnusers.Iconimage_right_Selected = null;
            this.btnusers.Iconimage_Selected = null;
            this.btnusers.IconMarginLeft = 0;
            this.btnusers.IconMarginRight = 0;
            this.btnusers.IconRightVisible = true;
            this.btnusers.IconRightZoom = 0D;
            this.btnusers.IconVisible = true;
            this.btnusers.IconZoom = 90D;
            this.btnusers.IsTab = true;
            this.btnusers.Location = new System.Drawing.Point(2, 84);
            this.btnusers.Name = "btnusers";
            this.btnusers.Normalcolor = System.Drawing.Color.Navy;
            this.btnusers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnusers.OnHoverTextColor = System.Drawing.Color.Navy;
            this.btnusers.selected = false;
            this.btnusers.Size = new System.Drawing.Size(175, 36);
            this.btnusers.TabIndex = 10;
            this.btnusers.Text = "        USERS";
            this.btnusers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusers.Textcolor = System.Drawing.Color.White;
            this.btnusers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(44, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(137, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(211, 118);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(525, 338);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(479, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Logged In User :";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.lblLoggedInUser, BunifuAnimatorNS.DecorationType.None);
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInUser.Location = new System.Drawing.Point(586, 34);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(0, 17);
            this.lblLoggedInUser.TabIndex = 6;
            // 
            // btnHistory
            // 
            this.btnHistory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnHistory.BackColor = System.Drawing.Color.Navy;
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.BorderRadius = 0;
            this.btnHistory.ButtonText = "     LogIn History";
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnHistory, BunifuAnimatorNS.DecorationType.None);
            this.btnHistory.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHistory.Iconimage")));
            this.btnHistory.Iconimage_right = null;
            this.btnHistory.Iconimage_right_Selected = null;
            this.btnHistory.Iconimage_Selected = null;
            this.btnHistory.IconMarginLeft = 0;
            this.btnHistory.IconMarginRight = 0;
            this.btnHistory.IconRightVisible = true;
            this.btnHistory.IconRightZoom = 0D;
            this.btnHistory.IconVisible = true;
            this.btnHistory.IconZoom = 90D;
            this.btnHistory.IsTab = true;
            this.btnHistory.Location = new System.Drawing.Point(2, 421);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Normalcolor = System.Drawing.Color.Navy;
            this.btnHistory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.btnHistory.OnHoverTextColor = System.Drawing.Color.Navy;
            this.btnHistory.selected = false;
            this.btnHistory.Size = new System.Drawing.Size(175, 36);
            this.btnHistory.TabIndex = 12;
            this.btnHistory.Text = "     LogIn History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Textcolor = System.Drawing.Color.White;
            this.btnHistory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 596);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FooterPanel);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label lblDeveloperName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton BtnTransaction;
        private Bunifu.Framework.UI.BunifuFlatButton BtnInvet;
        private Bunifu.Framework.UI.BunifuFlatButton BtnProducts;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCateg;
        private Bunifu.Framework.UI.BunifuFlatButton btnusers;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeaCust;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistory;
    }
}

