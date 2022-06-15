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
using Mémoire;

namespace Mémoire.Forms
{
    public partial class Form1DPacking : Form
    {
        WaitFormFunc waitForm = new WaitFormFunc();
        public int ObjectCreated = 0;
        DataTable ObjectsGroupeTable = new DataTable("ObjectsGroupeTable");

        public Form1DPacking()
        {
            InitializeComponent();

        }

        private void Form1DPacking_Load(object sender, EventArgs e)
        {
            lblBinCurrentsize.Text = _1DPacking.SizeOfTheBin.ToString();
            lblIndividualsCurrentNumber.Text = _1DPacking.numberOfIndividuals.ToString();
            lblMaxGeneration.Text = _1DPacking.numberOfGenerations.ToString();
            ObjectsGroupeTable.Columns.Add("Object Size", Type.GetType("System.Int32"));
            ObjectsGroupeTable.Columns.Add("Quantity", Type.GetType("System.Int32"));
            gridObjects.DataSource = ObjectsGroupeTable;
            lblObjectCreated.Text = ObjectCreated.ToString();
        }


        //__________________________________________________________________________________________
        //Only numbers Edit Texts

        //first
        private void txtObjectSize_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtObjectSize.Text, "  ^ [0-9]"))
            {
                txtObjectSize.Text = "";
            }
        }
        private void txtObjectSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //second
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "  ^ [0-9]"))
            {
                txtQuantity.Text = "";
            }
        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }





        //___________________________________________________________________________________________
        //Mouse Style Events
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor =Color.FromArgb(245, 136, 0);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(26, 70, 69);
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(245, 136, 0);
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.FromArgb(26, 70, 69);
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(245, 136, 0);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(26, 70, 69);
        }
        //_______________________________________________________________________________________


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int currentSize;
            int currentQuentity;
            if(txtObjectSize.Text == String.Empty || txtQuantity.Text == String.Empty || txtQuantity.Text == "0" || txtObjectSize.Text == "0")
            {
                DialogResult result = PLMessageBox.Show("Object size and Quantity must not be 0 or empty ",
                 "Warning",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
            else
            {
                currentSize = Int32.Parse(txtObjectSize.Text);
                currentQuentity = Int32.Parse(txtQuantity.Text);
                if (currentSize > _1DPacking.SizeOfTheBin)
                {
                    PLMessageBox.Show("The item's current size is bigger than the bin's size",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    ObjectCreated += currentQuentity;
                    ObjectsGroupeTable.Rows.Add(txtObjectSize.Text, txtQuantity.Text);
                    txtObjectSize.Text = String.Empty;
                    txtQuantity.Text = String.Empty;
                    lblObjectCreated.Text = ObjectCreated.ToString();
                }
            }
        }
        //_______________________________________________________________________________________

        int CellIndex;
        int oldvalue;
        private void gridObjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellIndex = e.RowIndex;
            if (CellIndex >= 0)
            {
                DataGridViewRow Row = gridObjects.Rows[CellIndex];
                txtObjectSize.Text = Row.Cells[0].Value.ToString();
                txtQuantity.Text = Row.Cells[1].Value.ToString();
            }
        }
        //_______________________________________________________________________________________

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int currentSize;
            int currentQuentity;
            if (txtObjectSize.Text == String.Empty || txtQuantity.Text == String.Empty || txtQuantity.Text == "0" || txtObjectSize.Text == "0")
            {
                DialogResult result = PLMessageBox.Show("Object size and Quantity must not be 0 or empty ",
                 "Warning",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
            else
            {
                currentSize = Int32.Parse(txtObjectSize.Text);
                currentQuentity = Int32.Parse(txtQuantity.Text);
                if (currentSize > _1DPacking.SizeOfTheBin)
                {
                    PLMessageBox.Show("The item's current size is bigger than the bin's size",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                else
                {
                    DataGridViewRow NewData = gridObjects.Rows[CellIndex];
                    ObjectCreated -= (Int32.Parse(NewData.Cells[1].Value.ToString()) - currentQuentity);
                    NewData.Cells[0].Value = currentSize;
                    NewData.Cells[1].Value = currentQuentity;
                    lblObjectCreated.Text = ObjectCreated.ToString();
                    txtObjectSize.Text = String.Empty;
                    txtQuantity.Text = String.Empty;
                }
            }
        }
        //________________________________________________________________________________________

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridObjects.RowCount == 0)
            {
                PLMessageBox.Show("The item list is empty",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = PLMessageBox.Show("Do you want to delete the selected item?",
                  "Warning",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CellIndex = gridObjects.CurrentCell.RowIndex;
                    oldvalue = Int32.Parse(gridObjects.Rows[CellIndex].Cells[1].Value.ToString());
                    gridObjects.Rows.RemoveAt(CellIndex);
                    ObjectCreated -= oldvalue;
                    lblObjectCreated.Text = ObjectCreated.ToString();
                }
            }
        }
        //________________________________________________________________________________________

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (ObjectCreated == 0)
            {
                DialogResult result = PLMessageBox.Show("You need to add at least one object",
                 "Warning",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
            else
            {
                waitForm.show();
                _1DPacking.numberOfObjects = ObjectCreated;
                _1DPacking.instense.PoulationStart();
                _1DPacking.instense.population.InitializePopulation();
                int k = 0;
                for (int i = 0; i < gridObjects.RowCount; i++)
                {
                    for (int j = 0; j < Int32.Parse(gridObjects.Rows[i].Cells[1].Value.ToString()); j++)
                    {
                        _1DPacking.instense.population.ObjectGroup.RandomObject[k].size = Int32.Parse(gridObjects.Rows[i].Cells[0].Value.ToString());
                        k++;
                    }
                }
                for (int i = 0; i < _1DPacking.numberOfIndividuals; i++)
                {
                    _1DPacking.instense.population.Individuals[i].fitness = _1DPacking.instense.population.CalculateFitness(_1DPacking.instense.population.Individuals[i].genes);
                }
                _1DPacking.instense.Start();
                _1DBinsDisplay Display = new _1DBinsDisplay();
                Display.Show();
                waitForm.Close();
            } 
        }
        //_______________________________________________________________________________________


    }
}
