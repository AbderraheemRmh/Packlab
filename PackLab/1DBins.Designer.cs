namespace Mémoire
{
    partial class _1DBins
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Background = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBinNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblObjects = new System.Windows.Forms.TextBox();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.Background.Controls.Add(this.pictureBox1);
            this.Background.Location = new System.Drawing.Point(2, 5);
            this.Background.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(140, 150);
            this.Background.TabIndex = 0;
            this.Background.MouseEnter += new System.EventHandler(this.Background_MouseEnter);
            this.Background.MouseLeave += new System.EventHandler(this.Background_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mémoire.Properties.Resources.Bin;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.Background_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.Background_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("18 Khebrat Musamim", 25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(146, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bin:";
            this.label1.MouseEnter += new System.EventHandler(this.lblObjects_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.lblObjects_MouseLeave);
            // 
            // lblBinNumber
            // 
            this.lblBinNumber.AutoSize = true;
            this.lblBinNumber.Font = new System.Drawing.Font("18 Khebrat Musamim", 25F);
            this.lblBinNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.lblBinNumber.Location = new System.Drawing.Point(197, 5);
            this.lblBinNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBinNumber.Name = "lblBinNumber";
            this.lblBinNumber.Size = new System.Drawing.Size(36, 51);
            this.lblBinNumber.TabIndex = 3;
            this.lblBinNumber.Text = "0";
            this.lblBinNumber.MouseEnter += new System.EventHandler(this.lblObjects_MouseEnter);
            this.lblBinNumber.MouseLeave += new System.EventHandler(this.lblObjects_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("18 Khebrat Musamim", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(150, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Objects:";
            this.label3.MouseEnter += new System.EventHandler(this.lblObjects_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.lblObjects_MouseLeave);
            // 
            // lblObjects
            // 
            this.lblObjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObjects.BackColor = System.Drawing.Color.White;
            this.lblObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblObjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.lblObjects.Location = new System.Drawing.Point(155, 73);
            this.lblObjects.Multiline = true;
            this.lblObjects.Name = "lblObjects";
            this.lblObjects.ReadOnly = true;
            this.lblObjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblObjects.Size = new System.Drawing.Size(728, 82);
            this.lblObjects.TabIndex = 5;
            this.lblObjects.MouseEnter += new System.EventHandler(this.lblObjects_MouseEnter);
            this.lblObjects.MouseLeave += new System.EventHandler(this.lblObjects_MouseLeave);
            // 
            // _1DBins
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblObjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBinNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Background);
            this.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "_1DBins";
            this.Size = new System.Drawing.Size(900, 160);
            this.MouseEnter += new System.EventHandler(this.lblObjects_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lblObjects_MouseLeave);
            this.Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBinNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblObjects;
    }
}
