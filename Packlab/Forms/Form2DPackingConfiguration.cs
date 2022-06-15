using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mémoire.Packing;

namespace Mémoire.Forms
{
    public partial class Form2DPackingConfiguration : Form
    {
        public Form2DPackingConfiguration()
        {
            InitializeComponent();
           
        }

        private void txtBinWidth_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(this.Text, "  ^ [0-9]"))
            {
                this.Text = "";
            }
        }

        private void txtBinWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form2DPackingConfiguration_Load(object sender, EventArgs e)
        {
            lblWidthUnit.Text = _2DPacking.Unit;
            lblUnitHeight.Text = _2DPacking.Unit;
            txtBinWidth.Text = _2DPacking.BinWidth.ToString();
            txtBinHeight.Text = _2DPacking.BinHeight.ToString();
            txtIndividualNumber.Text = _2DPacking.numberOfIndividuals.ToString();
            txtMaxGeneration.Text = _2DPacking.numberOfGenerations.ToString();
        }

        private void btnValidUnit_MouseEnter(object sender, EventArgs e)
        {
            btnValidUnit.BackColor = Color.FromArgb(245, 136, 0);
        }

        private void btnValidUnit_MouseLeave(object sender, EventArgs e)
        {
            btnValidUnit.BackColor = Color.FromArgb(26, 70, 69);
        }

        private void btnConfirmSettings_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmSettings.BackColor = Color.FromArgb(245, 136, 0);
        }

        private void btnConfirmSettings_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmSettings.BackColor = Color.FromArgb(26, 70, 69);
        }

        private void btnValidUnit_Click(object sender, EventArgs e)
        {
            if (comboboxUnit.SelectedItem != null)
            {
                DialogResult result = PLMessageBox.Show("Do you want to change the current unit?",
             "Confirm?",
             MessageBoxButtons.OKCancel,
             MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    switch (comboboxUnit.SelectedIndex)
                    {
                        case 0:
                            _2DPacking.Unit = "M";
                            lblWidthUnit.Text = "M";
                            lblUnitHeight.Text = "M";
                            break;
                        case 1:
                            _2DPacking.Unit = "CM";
                            lblWidthUnit.Text = "CM";
                            lblUnitHeight.Text = "CM";
                            break;
                    }
                }
            }
            else
            {
                PLMessageBox.Show("Please select a Unit",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }

        private void btnConfirmSettings_Click(object sender, EventArgs e)
        {
            DialogResult result = PLMessageBox.Show("Do you want to confirm the current settings?",
              "Confirm?",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                _2DPacking.BinWidth = Int32.Parse(txtBinWidth.Text);
                _2DPacking.BinHeight = Int32.Parse(txtBinHeight.Text);
                _2DPacking.numberOfIndividuals = Int32.Parse(txtIndividualNumber.Text);
                _2DPacking.numberOfGenerations = Int32.Parse(txtMaxGeneration.Text);
            }
        }
    }
}
