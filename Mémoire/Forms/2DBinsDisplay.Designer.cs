namespace Mémoire.Forms
{
    partial class _2DBinsDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2DBinsDisplay));
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBN = new System.Windows.Forms.Label();
            this.lblBinsNeeded = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblBestFitness = new System.Windows.Forms.Label();
            this.lblGC = new System.Windows.Forms.Label();
            this.lblGenerationCount = new System.Windows.Forms.Label();
            this.lblWS = new System.Windows.Forms.Label();
            this.lblWastedSpace = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MainPanel.Location = new System.Drawing.Point(17, 126);
            this.MainPanel.MinimumSize = new System.Drawing.Size(850, 350);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(900, 427);
            this.MainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 67);
            this.panel1.TabIndex = 2;
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
            this.btnMinimize.Location = new System.Drawing.Point(797, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 7;
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
            this.btnMaximize.Location = new System.Drawing.Point(842, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 6;
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
            this.btnClose.Location = new System.Drawing.Point(887, 0);
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
            this.lblTitle.Size = new System.Drawing.Size(240, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "2D Packing Display";
            // 
            // lblBN
            // 
            this.lblBN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBN.AutoSize = true;
            this.lblBN.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblBN.Location = new System.Drawing.Point(599, 70);
            this.lblBN.Name = "lblBN";
            this.lblBN.Size = new System.Drawing.Size(0, 24);
            this.lblBN.TabIndex = 12;
            // 
            // lblBinsNeeded
            // 
            this.lblBinsNeeded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBinsNeeded.AutoSize = true;
            this.lblBinsNeeded.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblBinsNeeded.Location = new System.Drawing.Point(517, 70);
            this.lblBinsNeeded.Name = "lblBinsNeeded";
            this.lblBinsNeeded.Size = new System.Drawing.Size(84, 24);
            this.lblBinsNeeded.TabIndex = 11;
            this.lblBinsNeeded.Text = "Bins Needed:";
            // 
            // lblF
            // 
            this.lblF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblF.Location = new System.Drawing.Point(813, 70);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(0, 24);
            this.lblF.TabIndex = 10;
            // 
            // lblBestFitness
            // 
            this.lblBestFitness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBestFitness.AutoSize = true;
            this.lblBestFitness.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblBestFitness.Location = new System.Drawing.Point(759, 70);
            this.lblBestFitness.Name = "lblBestFitness";
            this.lblBestFitness.Size = new System.Drawing.Size(60, 24);
            this.lblBestFitness.TabIndex = 9;
            this.lblBestFitness.Text = "Fitness :";
            // 
            // lblGC
            // 
            this.lblGC.AutoSize = true;
            this.lblGC.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblGC.Location = new System.Drawing.Point(124, 70);
            this.lblGC.Name = "lblGC";
            this.lblGC.Size = new System.Drawing.Size(0, 24);
            this.lblGC.TabIndex = 8;
            // 
            // lblGenerationCount
            // 
            this.lblGenerationCount.AutoSize = true;
            this.lblGenerationCount.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblGenerationCount.Location = new System.Drawing.Point(20, 70);
            this.lblGenerationCount.Name = "lblGenerationCount";
            this.lblGenerationCount.Size = new System.Drawing.Size(116, 24);
            this.lblGenerationCount.TabIndex = 7;
            this.lblGenerationCount.Text = "Generation Count: ";
            // 
            // lblWS
            // 
            this.lblWS.AutoSize = true;
            this.lblWS.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblWS.Location = new System.Drawing.Point(342, 70);
            this.lblWS.Name = "lblWS";
            this.lblWS.Size = new System.Drawing.Size(0, 24);
            this.lblWS.TabIndex = 14;
            // 
            // lblWastedSpace
            // 
            this.lblWastedSpace.AutoSize = true;
            this.lblWastedSpace.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblWastedSpace.Location = new System.Drawing.Point(213, 70);
            this.lblWastedSpace.Name = "lblWastedSpace";
            this.lblWastedSpace.Size = new System.Drawing.Size(130, 24);
            this.lblWastedSpace.TabIndex = 13;
            this.lblWastedSpace.Text = "Total Space Wasted:";
            // 
            // _2DBinsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.lblWS);
            this.Controls.Add(this.lblWastedSpace);
            this.Controls.Add(this.lblBN);
            this.Controls.Add(this.lblBinsNeeded);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblBestFitness);
            this.Controls.Add(this.lblGC);
            this.Controls.Add(this.lblGenerationCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "_2DBinsDisplay";
            this.Text = "_2DBinsDisplay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this._2DBinsDisplay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBN;
        private System.Windows.Forms.Label lblBinsNeeded;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblBestFitness;
        private System.Windows.Forms.Label lblGC;
        private System.Windows.Forms.Label lblGenerationCount;
        private System.Windows.Forms.Label lblWS;
        private System.Windows.Forms.Label lblWastedSpace;
    }
}