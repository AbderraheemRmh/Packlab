namespace Mémoire.Forms
{
    partial class BluePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BluePrint));
            this.Canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblWS = new System.Windows.Forms.Label();
            this.lblWastedSpace = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(66, 104);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(550, 550);
            this.Canvas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 67);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.btnMinimize.Location = new System.Drawing.Point(591, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnClose.Location = new System.Drawing.Point(637, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("18 Khebrat Musamim", 25F);
            this.lblTitle.Location = new System.Drawing.Point(14, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BluePrint";
            // 
            // lblB
            // 
            this.lblB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblB.Location = new System.Drawing.Point(565, 70);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(0, 24);
            this.lblB.TabIndex = 10;
            // 
            // lblBin
            // 
            this.lblBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBin.AutoSize = true;
            this.lblBin.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblBin.Location = new System.Drawing.Point(533, 70);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(31, 24);
            this.lblBin.TabIndex = 9;
            this.lblBin.Text = "Bin:";
            // 
            // lblWS
            // 
            this.lblWS.AutoSize = true;
            this.lblWS.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblWS.Location = new System.Drawing.Point(165, 70);
            this.lblWS.Name = "lblWS";
            this.lblWS.Size = new System.Drawing.Size(0, 24);
            this.lblWS.TabIndex = 8;
            // 
            // lblWastedSpace
            // 
            this.lblWastedSpace.AutoSize = true;
            this.lblWastedSpace.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblWastedSpace.Location = new System.Drawing.Point(68, 70);
            this.lblWastedSpace.Name = "lblWastedSpace";
            this.lblWastedSpace.Size = new System.Drawing.Size(102, 24);
            this.lblWastedSpace.TabIndex = 7;
            this.lblWastedSpace.Text = "Wasted Space: ";
            // 
            // BluePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblBin);
            this.Controls.Add(this.lblWS);
            this.Controls.Add(this.lblWastedSpace);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Canvas);
            this.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "BluePrint";
            this.Text = "BluePrint";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BluePrint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblWS;
        private System.Windows.Forms.Label lblWastedSpace;
    }
}