namespace Mémoire.Forms
{
    partial class Form2DPackingConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2DPackingConfiguration));
            this.txtMaxGeneration = new System.Windows.Forms.TextBox();
            this.lblMaxGeneration = new System.Windows.Forms.Label();
            this.btnConfirmSettings = new System.Windows.Forms.Button();
            this.btnValidUnit = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.comboboxUnit = new System.Windows.Forms.ComboBox();
            this.txtIndividualNumber = new System.Windows.Forms.TextBox();
            this.lblNumberOfIndividuals = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBinWidth = new System.Windows.Forms.TextBox();
            this.lblBinWidth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBinHeight = new System.Windows.Forms.TextBox();
            this.lblBinHeight = new System.Windows.Forms.Label();
            this.lblWidthUnit = new System.Windows.Forms.Label();
            this.lblUnitHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaxGeneration
            // 
            this.txtMaxGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxGeneration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.txtMaxGeneration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxGeneration.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.txtMaxGeneration.ForeColor = System.Drawing.Color.White;
            this.txtMaxGeneration.Location = new System.Drawing.Point(161, 309);
            this.txtMaxGeneration.MaxLength = 5;
            this.txtMaxGeneration.Name = "txtMaxGeneration";
            this.txtMaxGeneration.Size = new System.Drawing.Size(179, 32);
            this.txtMaxGeneration.TabIndex = 4;
            this.txtMaxGeneration.TextChanged += new System.EventHandler(this.txtBinWidth_TextChanged);
            this.txtMaxGeneration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinWidth_KeyPress);
            // 
            // lblMaxGeneration
            // 
            this.lblMaxGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxGeneration.AutoSize = true;
            this.lblMaxGeneration.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblMaxGeneration.ForeColor = System.Drawing.Color.White;
            this.lblMaxGeneration.Location = new System.Drawing.Point(15, 312);
            this.lblMaxGeneration.Name = "lblMaxGeneration";
            this.lblMaxGeneration.Size = new System.Drawing.Size(102, 24);
            this.lblMaxGeneration.TabIndex = 37;
            this.lblMaxGeneration.Text = "Max generation:";
            // 
            // btnConfirmSettings
            // 
            this.btnConfirmSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnConfirmSettings.FlatAppearance.BorderSize = 0;
            this.btnConfirmSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSettings.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSettings.Location = new System.Drawing.Point(617, 371);
            this.btnConfirmSettings.Name = "btnConfirmSettings";
            this.btnConfirmSettings.Size = new System.Drawing.Size(109, 26);
            this.btnConfirmSettings.TabIndex = 5;
            this.btnConfirmSettings.Text = "Confirm settings";
            this.btnConfirmSettings.UseVisualStyleBackColor = false;
            this.btnConfirmSettings.Click += new System.EventHandler(this.btnConfirmSettings_Click);
            this.btnConfirmSettings.MouseEnter += new System.EventHandler(this.btnConfirmSettings_MouseEnter);
            this.btnConfirmSettings.MouseLeave += new System.EventHandler(this.btnConfirmSettings_MouseLeave);
            // 
            // btnValidUnit
            // 
            this.btnValidUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnValidUnit.FlatAppearance.BorderSize = 0;
            this.btnValidUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidUnit.ForeColor = System.Drawing.Color.White;
            this.btnValidUnit.Location = new System.Drawing.Point(651, 14);
            this.btnValidUnit.Name = "btnValidUnit";
            this.btnValidUnit.Size = new System.Drawing.Size(75, 29);
            this.btnValidUnit.TabIndex = 34;
            this.btnValidUnit.Text = "Confirm";
            this.btnValidUnit.UseVisualStyleBackColor = false;
            this.btnValidUnit.Click += new System.EventHandler(this.btnValidUnit_Click);
            this.btnValidUnit.MouseEnter += new System.EventHandler(this.btnValidUnit_MouseEnter);
            this.btnValidUnit.MouseLeave += new System.EventHandler(this.btnValidUnit_MouseLeave);
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(452, 15);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(36, 24);
            this.lblUnit.TabIndex = 33;
            this.lblUnit.Text = "Unit:";
            // 
            // comboboxUnit
            // 
            this.comboboxUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxUnit.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.comboboxUnit.FormattingEnabled = true;
            this.comboboxUnit.Items.AddRange(new object[] {
            "M",
            "CM"});
            this.comboboxUnit.Location = new System.Drawing.Point(512, 12);
            this.comboboxUnit.Name = "comboboxUnit";
            this.comboboxUnit.Size = new System.Drawing.Size(121, 32);
            this.comboboxUnit.TabIndex = 32;
            // 
            // txtIndividualNumber
            // 
            this.txtIndividualNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIndividualNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.txtIndividualNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndividualNumber.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.txtIndividualNumber.ForeColor = System.Drawing.Color.White;
            this.txtIndividualNumber.Location = new System.Drawing.Point(161, 261);
            this.txtIndividualNumber.MaxLength = 5;
            this.txtIndividualNumber.Name = "txtIndividualNumber";
            this.txtIndividualNumber.Size = new System.Drawing.Size(179, 32);
            this.txtIndividualNumber.TabIndex = 3;
            this.txtIndividualNumber.TextChanged += new System.EventHandler(this.txtBinWidth_TextChanged);
            this.txtIndividualNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinWidth_KeyPress);
            // 
            // lblNumberOfIndividuals
            // 
            this.lblNumberOfIndividuals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfIndividuals.AutoSize = true;
            this.lblNumberOfIndividuals.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblNumberOfIndividuals.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfIndividuals.Location = new System.Drawing.Point(15, 264);
            this.lblNumberOfIndividuals.Name = "lblNumberOfIndividuals";
            this.lblNumberOfIndividuals.Size = new System.Drawing.Size(137, 24);
            this.lblNumberOfIndividuals.TabIndex = 30;
            this.lblNumberOfIndividuals.Text = "Number of individuals:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(19, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 1);
            this.panel3.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("18 Khebrat Musamim", 20F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 41);
            this.label6.TabIndex = 28;
            this.label6.Text = "Algorithm Informations";
            // 
            // txtBinWidth
            // 
            this.txtBinWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.txtBinWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBinWidth.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.txtBinWidth.ForeColor = System.Drawing.Color.White;
            this.txtBinWidth.Location = new System.Drawing.Point(161, 80);
            this.txtBinWidth.MaxLength = 5;
            this.txtBinWidth.Name = "txtBinWidth";
            this.txtBinWidth.Size = new System.Drawing.Size(179, 32);
            this.txtBinWidth.TabIndex = 0;
            this.txtBinWidth.TextChanged += new System.EventHandler(this.txtBinWidth_TextChanged);
            this.txtBinWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinWidth_KeyPress);
            // 
            // lblBinWidth
            // 
            this.lblBinWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBinWidth.AutoSize = true;
            this.lblBinWidth.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblBinWidth.ForeColor = System.Drawing.Color.White;
            this.lblBinWidth.Location = new System.Drawing.Point(15, 83);
            this.lblBinWidth.Name = "lblBinWidth";
            this.lblBinWidth.Size = new System.Drawing.Size(68, 24);
            this.lblBinWidth.TabIndex = 22;
            this.lblBinWidth.Text = "Bin width:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(19, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("18 Khebrat Musamim", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bin Information";
            // 
            // txtBinHeight
            // 
            this.txtBinHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.txtBinHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBinHeight.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.txtBinHeight.ForeColor = System.Drawing.Color.White;
            this.txtBinHeight.Location = new System.Drawing.Point(161, 123);
            this.txtBinHeight.MaxLength = 5;
            this.txtBinHeight.Name = "txtBinHeight";
            this.txtBinHeight.Size = new System.Drawing.Size(179, 32);
            this.txtBinHeight.TabIndex = 1;
            this.txtBinHeight.TextChanged += new System.EventHandler(this.txtBinWidth_TextChanged);
            this.txtBinHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinWidth_KeyPress);
            // 
            // lblBinHeight
            // 
            this.lblBinHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBinHeight.AutoSize = true;
            this.lblBinHeight.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblBinHeight.ForeColor = System.Drawing.Color.White;
            this.lblBinHeight.Location = new System.Drawing.Point(15, 126);
            this.lblBinHeight.Name = "lblBinHeight";
            this.lblBinHeight.Size = new System.Drawing.Size(71, 24);
            this.lblBinHeight.TabIndex = 39;
            this.lblBinHeight.Text = "Bin height:";
            // 
            // lblWidthUnit
            // 
            this.lblWidthUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidthUnit.AutoSize = true;
            this.lblWidthUnit.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblWidthUnit.ForeColor = System.Drawing.Color.White;
            this.lblWidthUnit.Location = new System.Drawing.Point(344, 85);
            this.lblWidthUnit.Name = "lblWidthUnit";
            this.lblWidthUnit.Size = new System.Drawing.Size(18, 24);
            this.lblWidthUnit.TabIndex = 41;
            this.lblWidthUnit.Text = "  ";
            // 
            // lblUnitHeight
            // 
            this.lblUnitHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitHeight.AutoSize = true;
            this.lblUnitHeight.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblUnitHeight.ForeColor = System.Drawing.Color.White;
            this.lblUnitHeight.Location = new System.Drawing.Point(343, 129);
            this.lblUnitHeight.Name = "lblUnitHeight";
            this.lblUnitHeight.Size = new System.Drawing.Size(22, 24);
            this.lblUnitHeight.TabIndex = 42;
            this.lblUnitHeight.Text = "   ";
            // 
            // Form2DPackingConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(738, 412);
            this.Controls.Add(this.lblUnitHeight);
            this.Controls.Add(this.lblWidthUnit);
            this.Controls.Add(this.txtBinHeight);
            this.Controls.Add(this.lblBinHeight);
            this.Controls.Add(this.txtMaxGeneration);
            this.Controls.Add(this.lblMaxGeneration);
            this.Controls.Add(this.btnConfirmSettings);
            this.Controls.Add(this.btnValidUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.comboboxUnit);
            this.Controls.Add(this.txtIndividualNumber);
            this.Controls.Add(this.lblNumberOfIndividuals);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBinWidth);
            this.Controls.Add(this.lblBinWidth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Form2DPackingConfiguration";
            this.Text = "2D PACKING CONFIGURATION";
            this.Load += new System.EventHandler(this.Form2DPackingConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxGeneration;
        private System.Windows.Forms.Label lblMaxGeneration;
        private System.Windows.Forms.Button btnConfirmSettings;
        private System.Windows.Forms.Button btnValidUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox comboboxUnit;
        private System.Windows.Forms.TextBox txtIndividualNumber;
        private System.Windows.Forms.Label lblNumberOfIndividuals;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBinWidth;
        private System.Windows.Forms.Label lblBinWidth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBinHeight;
        private System.Windows.Forms.Label lblBinHeight;
        private System.Windows.Forms.Label lblWidthUnit;
        private System.Windows.Forms.Label lblUnitHeight;
    }
}