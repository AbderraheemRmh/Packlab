namespace Mémoire
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Exit = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btn2DPacking = new FontAwesome.Sharp.IconButton();
            this.btn1DPacking = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Settings = new Mémoire.Controls.DropDownMenu(this.components);
            this.dPackingConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dPackingConfigurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(103)))));
            this.panelMenu.Controls.Add(this.Exit);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btn2DPacking);
            this.panelMenu.Controls.Add(this.btn1DPacking);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panelMenu.Size = new System.Drawing.Size(230, 511);
            this.panelMenu.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit.IconSize = 30;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(0, 450);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Exit.Size = new System.Drawing.Size(230, 46);
            this.Exit.TabIndex = 4;
            this.Exit.Tag = "Exit";
            this.Exit.Text = "   Exit";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 30;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 192);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(230, 46);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btn2DPacking
            // 
            this.btn2DPacking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn2DPacking.FlatAppearance.BorderSize = 0;
            this.btn2DPacking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2DPacking.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.btn2DPacking.ForeColor = System.Drawing.Color.White;
            this.btn2DPacking.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal;
            this.btn2DPacking.IconColor = System.Drawing.Color.White;
            this.btn2DPacking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn2DPacking.IconSize = 30;
            this.btn2DPacking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2DPacking.Location = new System.Drawing.Point(0, 146);
            this.btn2DPacking.Name = "btn2DPacking";
            this.btn2DPacking.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn2DPacking.Size = new System.Drawing.Size(230, 46);
            this.btn2DPacking.TabIndex = 2;
            this.btn2DPacking.Tag = "2D Packing";
            this.btn2DPacking.Text = "   2D Packing";
            this.btn2DPacking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn2DPacking.UseVisualStyleBackColor = true;
            this.btn2DPacking.Click += new System.EventHandler(this.btn2DPacking_Click);
            // 
            // btn1DPacking
            // 
            this.btn1DPacking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1DPacking.FlatAppearance.BorderSize = 0;
            this.btn1DPacking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1DPacking.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.btn1DPacking.ForeColor = System.Drawing.Color.White;
            this.btn1DPacking.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn1DPacking.IconColor = System.Drawing.Color.White;
            this.btn1DPacking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn1DPacking.IconSize = 30;
            this.btn1DPacking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1DPacking.Location = new System.Drawing.Point(0, 100);
            this.btn1DPacking.Name = "btn1DPacking";
            this.btn1DPacking.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn1DPacking.Size = new System.Drawing.Size(230, 46);
            this.btn1DPacking.TabIndex = 1;
            this.btn1DPacking.Tag = "1D Packing";
            this.btn1DPacking.Text = "   1D Packing";
            this.btn1DPacking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1DPacking.UseVisualStyleBackColor = true;
            this.btn1DPacking.Click += new System.EventHandler(this.btn1DPacking_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(167, 2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mémoire.Properties.Resources.AppLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.lblHome);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(754, 60);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("18 Khebrat Musamim", 25F);
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.lblHome.Location = new System.Drawing.Point(18, 6);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(83, 51);
            this.lblHome.TabIndex = 5;
            this.lblHome.Text = "HOME";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(188)))), ((int)(((byte)(36)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(619, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(104)))), ((int)(((byte)(103)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(664, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(709, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(754, 451);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Mémoire.Properties.Resources.AppLogo;
            this.pictureBox2.Location = new System.Drawing.Point(185, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Settings
            // 
            this.Settings.IsMainMenu = false;
            this.Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dPackingConfigurationToolStripMenuItem,
            this.dPackingConfigurationToolStripMenuItem1});
            this.Settings.MenuItemHeight = 25;
            this.Settings.MenuItemTextColor = System.Drawing.Color.White;
            this.Settings.Name = "Settings";
            this.Settings.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.Settings.Size = new System.Drawing.Size(211, 48);
            // 
            // dPackingConfigurationToolStripMenuItem
            // 
            this.dPackingConfigurationToolStripMenuItem.Name = "dPackingConfigurationToolStripMenuItem";
            this.dPackingConfigurationToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.dPackingConfigurationToolStripMenuItem.Text = "1D Packing Configuration";
            this.dPackingConfigurationToolStripMenuItem.Click += new System.EventHandler(this.dPackingConfigurationToolStripMenuItem_Click);
            // 
            // dPackingConfigurationToolStripMenuItem1
            // 
            this.dPackingConfigurationToolStripMenuItem1.Name = "dPackingConfigurationToolStripMenuItem1";
            this.dPackingConfigurationToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.dPackingConfigurationToolStripMenuItem1.Text = "2D Packing Configuration";
            this.dPackingConfigurationToolStripMenuItem1.Click += new System.EventHandler(this.dPackingConfigurationToolStripMenuItem1_Click);
            // 
            // FormMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn1DPacking;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Exit;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btn2DPacking;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Controls.DropDownMenu Settings;
        private System.Windows.Forms.ToolStripMenuItem dPackingConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dPackingConfigurationToolStripMenuItem1;
    }
}

