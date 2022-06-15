namespace Mémoire.Forms
{
    partial class Form1DPackingConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1DPackingConfiguration));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndividualNumber = new System.Windows.Forms.TextBox();
            this.lblNumberOfIndividuals = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboboxUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnValidUnit = new System.Windows.Forms.Button();
            this.lblunit1 = new System.Windows.Forms.Label();
            this.btnConfirmSettings = new System.Windows.Forms.Button();
            this.txtMaxGeneration = new System.Windows.Forms.TextBox();
            this.lblMaxGeneration = new System.Windows.Forms.Label();
            this.txtBinSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("18 Khebrat Musamim", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bin Information";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(19, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bin size:";
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
            this.txtIndividualNumber.Location = new System.Drawing.Point(161, 236);
            this.txtIndividualNumber.MaxLength = 5;
            this.txtIndividualNumber.Name = "txtIndividualNumber";
            this.txtIndividualNumber.Size = new System.Drawing.Size(179, 32);
            this.txtIndividualNumber.TabIndex = 11;
            this.txtIndividualNumber.TextChanged += new System.EventHandler(this.txtIndividualNumber_TextChanged);
            this.txtIndividualNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIndividualNumber_KeyPress);
            // 
            // lblNumberOfIndividuals
            // 
            this.lblNumberOfIndividuals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfIndividuals.AutoSize = true;
            this.lblNumberOfIndividuals.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblNumberOfIndividuals.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfIndividuals.Location = new System.Drawing.Point(15, 239);
            this.lblNumberOfIndividuals.Name = "lblNumberOfIndividuals";
            this.lblNumberOfIndividuals.Size = new System.Drawing.Size(137, 24);
            this.lblNumberOfIndividuals.TabIndex = 10;
            this.lblNumberOfIndividuals.Text = "Number of individuals:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(19, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 1);
            this.panel3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("18 Khebrat Musamim", 20F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "Algorithm Informations";
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
            this.comboboxUnit.TabIndex = 12;
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
            this.lblUnit.TabIndex = 13;
            this.lblUnit.Text = "Unit:";
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
            this.btnValidUnit.TabIndex = 15;
            this.btnValidUnit.Text = "Confirm";
            this.btnValidUnit.UseVisualStyleBackColor = false;
            this.btnValidUnit.Click += new System.EventHandler(this.btnValidUnit_Click);
            this.btnValidUnit.MouseEnter += new System.EventHandler(this.btnValidUnit_MouseEnter);
            this.btnValidUnit.MouseLeave += new System.EventHandler(this.btnValidUnit_MouseLeave);
            // 
            // lblunit1
            // 
            this.lblunit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblunit1.AutoSize = true;
            this.lblunit1.Font = new System.Drawing.Font("18 Khebrat Musamim", 15F);
            this.lblunit1.ForeColor = System.Drawing.Color.White;
            this.lblunit1.Location = new System.Drawing.Point(346, 99);
            this.lblunit1.Name = "lblunit1";
            this.lblunit1.Size = new System.Drawing.Size(17, 30);
            this.lblunit1.TabIndex = 16;
            this.lblunit1.Text = " ";
            // 
            // btnConfirmSettings
            // 
            this.btnConfirmSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnConfirmSettings.FlatAppearance.BorderSize = 0;
            this.btnConfirmSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSettings.ForeColor = System.Drawing.Color.White;
            this.btnConfirmSettings.Location = new System.Drawing.Point(617, 374);
            this.btnConfirmSettings.Name = "btnConfirmSettings";
            this.btnConfirmSettings.Size = new System.Drawing.Size(109, 26);
            this.btnConfirmSettings.TabIndex = 17;
            this.btnConfirmSettings.Text = "Confirm settings";
            this.btnConfirmSettings.UseVisualStyleBackColor = false;
            this.btnConfirmSettings.Click += new System.EventHandler(this.btnConfirmSettings_Click);
            this.btnConfirmSettings.MouseEnter += new System.EventHandler(this.btnConfirmSettings_MouseEnter);
            this.btnConfirmSettings.MouseLeave += new System.EventHandler(this.btnConfirmSettings_MouseLeave);
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
            this.txtMaxGeneration.Location = new System.Drawing.Point(161, 284);
            this.txtMaxGeneration.MaxLength = 5;
            this.txtMaxGeneration.Name = "txtMaxGeneration";
            this.txtMaxGeneration.Size = new System.Drawing.Size(179, 32);
            this.txtMaxGeneration.TabIndex = 19;
            // 
            // lblMaxGeneration
            // 
            this.lblMaxGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxGeneration.AutoSize = true;
            this.lblMaxGeneration.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.lblMaxGeneration.ForeColor = System.Drawing.Color.White;
            this.lblMaxGeneration.Location = new System.Drawing.Point(15, 287);
            this.lblMaxGeneration.Name = "lblMaxGeneration";
            this.lblMaxGeneration.Size = new System.Drawing.Size(102, 24);
            this.lblMaxGeneration.TabIndex = 18;
            this.lblMaxGeneration.Text = "Max generation:";
            // 
            // txtBinSize
            // 
            this.txtBinSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.txtBinSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBinSize.Font = new System.Drawing.Font("18 Khebrat Musamim", 12F);
            this.txtBinSize.ForeColor = System.Drawing.Color.White;
            this.txtBinSize.Location = new System.Drawing.Point(161, 94);
            this.txtBinSize.MaxLength = 5;
            this.txtBinSize.Name = "txtBinSize";
            this.txtBinSize.Size = new System.Drawing.Size(179, 32);
            this.txtBinSize.TabIndex = 3;
            this.txtBinSize.TextChanged += new System.EventHandler(this.txtBinSize_TextChanged);
            this.txtBinSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinSize_KeyPress);
            // 
            // Form1DPackingConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(738, 412);
            this.Controls.Add(this.txtMaxGeneration);
            this.Controls.Add(this.lblMaxGeneration);
            this.Controls.Add(this.btnConfirmSettings);
            this.Controls.Add(this.lblunit1);
            this.Controls.Add(this.btnValidUnit);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.comboboxUnit);
            this.Controls.Add(this.txtIndividualNumber);
            this.Controls.Add(this.lblNumberOfIndividuals);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBinSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("18 Khebrat Musamim", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Form1DPackingConfiguration";
            this.Text = "1D PACKING CONFIGURATION";
            this.Load += new System.EventHandler(this.Form1DPackingConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndividualNumber;
        private System.Windows.Forms.Label lblNumberOfIndividuals;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboboxUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnValidUnit;
        private System.Windows.Forms.Label lblunit1;
        private System.Windows.Forms.Button btnConfirmSettings;
        private System.Windows.Forms.TextBox txtMaxGeneration;
        private System.Windows.Forms.Label lblMaxGeneration;
        private System.Windows.Forms.TextBox txtBinSize;
    }
}