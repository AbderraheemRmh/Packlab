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
    public partial class Form1DPackingConfiguration : Form
    {
        
        public Form1DPackingConfiguration()
        {
            InitializeComponent();
        }



        //_______________________________________________________________________________________
        //first edit text
        private void txtBinSize_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBinSize.Text, "  ^ [0-9]"))
            {
                txtBinSize.Text = "";
            }
        }
        private void txtBinSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //second edit text
        private void txtIndividualNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIndividualNumber.Text, "  ^ [0-9]"))
            {
                txtIndividualNumber.Text = "";
            }
        }
        private void txtIndividualNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //____________________________________________________________________________________________

        private void Form1DPackingConfiguration_Load(object sender, EventArgs e)
        {
            lblunit1.Text = _1DPacking.Unit;
            txtBinSize.Text = _1DPacking.SizeOfTheBin.ToString();
            txtIndividualNumber.Text = _1DPacking.numberOfIndividuals.ToString();
            txtMaxGeneration.Text = _1DPacking.numberOfGenerations.ToString();
        }


        private void btnValidUnit_Click(object sender, EventArgs e)
        {
            if(comboboxUnit.SelectedItem != null)
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
                            _1DPacking.Unit = "M";
                            lblunit1.Text = "M";
                            break;
                        case 1:
                            _1DPacking.Unit = "CM";
                            lblunit1.Text = "CM";
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

        private void btnConfirmSettings_Click(object sender, EventArgs e)
        {
            DialogResult result = PLMessageBox.Show("Do you want to confirm the current settings?",
              "Confirm?",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                _1DPacking.SizeOfTheBin = Int32.Parse(txtBinSize.Text);
                _1DPacking.numberOfIndividuals = Int32.Parse(txtIndividualNumber.Text);
                _1DPacking.numberOfGenerations = Int32.Parse(txtMaxGeneration.Text);
            }
        }


    }
}
