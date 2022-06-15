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
    public partial class Form2DPacking : Form
    {
        public int ObjectCreated = 0;
        DataTable ObjectsGroupeTable = new DataTable("ObjectsGroupeTable");
        WaitFormFunc waitForm = new WaitFormFunc();

        public Form2DPacking()
        {
            InitializeComponent();
            
        }
        //_________________________________________________________________________
        //form load

        private void Form2DPacking_Load(object sender, EventArgs e)
        {
            lblBinCurrentWidth.Text = _2DPacking.BinWidth.ToString();
            lblBinHeight.Text = _2DPacking.BinHeight.ToString();
            lblIndividualsCurrentNumber.Text = _2DPacking.numberOfIndividuals.ToString();
            lblMaxGeneration.Text = _2DPacking.numberOfGenerations.ToString();
            ObjectsGroupeTable.Columns.Add("Object width", Type.GetType("System.Int32"));
            ObjectsGroupeTable.Columns.Add("Object height", Type.GetType("System.Int32"));
            ObjectsGroupeTable.Columns.Add("Quentity", Type.GetType("System.Int32"));
            gridObjects.DataSource = ObjectsGroupeTable;
            lblObjectCreated.Text = ObjectCreated.ToString();
        }
        //_______________________________________________________________________________
        //confirmer

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
                waitForm.show(this);
                _2DPacking.numberOfObjects = ObjectCreated;
                _2DPacking.instense.PopulationStart();
                _2DPacking.instense.population.ObjectsIntialisation();
                _2DPacking.instense.population.BinAndIndividualsInitialisation();
                int k = 0;
                for (int i = 0; i < gridObjects.RowCount; i++)
                {
                    for (int j = 0; j < Int32.Parse(gridObjects.Rows[i].Cells[2].Value.ToString()); j++)
                    {
                        _2DPacking.instense.population.objects.CurrentObject[k].Width= Int32.Parse(gridObjects.Rows[i].Cells[0].Value.ToString());
                        _2DPacking.instense.population.objects.CurrentObject[k].Height = Int32.Parse(gridObjects.Rows[i].Cells[1].Value.ToString());
                        _2DPacking.instense.population.objects.CurrentObject[k].Surface = _2DPacking.instense.population.objects.CurrentObject[k].Height* _2DPacking.instense.population.objects.CurrentObject[k].Width;
                        k++;
                    }
                }
                _2DPacking.instense.population.objects.NumberOfBinsNeeded();
                _2DPacking.instense.population.RunIndividuals();
                _2DPacking.instense.population.GetTheFittest();
                _2DPacking.instense.Start();
                _2DBinsDisplay Display = new _2DBinsDisplay();
                Display.Show();
                waitForm.Close();
            }
        }
        //_________________________________________________________________________________
        //add

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int currentWidth;
            int currentHeight;
            int currentQuentity;
            if (txtObjectWidth.Text == String.Empty || txtObjectHeight.Text == String.Empty || txtQuantity.Text == String.Empty || txtQuantity.Text == "0" || txtObjectWidth.Text == "0" || txtObjectHeight.Text == "0")
            {
                DialogResult result = PLMessageBox.Show("Object width and height and Quantity must not be 0 or empty ",
                 "Warning",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
            else
            {
                currentWidth = Int32.Parse(txtObjectWidth.Text);
                currentHeight = Int32.Parse(txtObjectHeight.Text);
                currentQuentity = Int32.Parse(txtQuantity.Text);
                if (currentWidth > _2DPacking.BinWidth || currentHeight > _2DPacking.BinHeight)
                {
                    PLMessageBox.Show("The item's current width or height is bigger than the bin's width or height",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                else
                {
                    ObjectCreated += currentQuentity;
                    ObjectsGroupeTable.Rows.Add(txtObjectWidth.Text, txtObjectHeight.Text, txtQuantity.Text);
                    txtObjectWidth.Text = String.Empty; 
                    txtObjectHeight.Text = String.Empty;
                    txtQuantity.Text = String.Empty;
                    lblObjectCreated.Text = ObjectCreated.ToString();
                }
            }
        }
        //____________________________________________________________________________________________
        //edit

        int CellIndex;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int currentWidth;
            int currentHeight;
            int currentQuentity;
            if (txtObjectWidth.Text == String.Empty || txtObjectHeight.Text == String.Empty || txtQuantity.Text == String.Empty || txtQuantity.Text == "0" || txtObjectWidth.Text == "0" || txtObjectHeight.Text == "0")
            {
                DialogResult result = PLMessageBox.Show("Object width and height and Quantity must not be 0 or empty ",
                 "Warning",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
            }
            else
            {
                currentWidth = Int32.Parse(txtObjectWidth.Text);
                currentHeight = Int32.Parse(txtObjectHeight.Text);
                currentQuentity = Int32.Parse(txtQuantity.Text);
                if (currentWidth > _2DPacking.BinWidth || currentHeight > _2DPacking.BinHeight)
                {
                    PLMessageBox.Show("The item's current width or height is bigger than the bin's width or height",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                else
                {
                        DataGridViewRow NewData = gridObjects.Rows[CellIndex];
                        ObjectCreated -= (Int32.Parse(NewData.Cells[2].Value.ToString()) - currentQuentity);
                        NewData.Cells[0].Value = currentWidth;
                        NewData.Cells[1].Value = currentHeight;
                        NewData.Cells[2].Value = currentQuentity;
                        lblObjectCreated.Text = ObjectCreated.ToString();
                        txtObjectWidth.Text = String.Empty;
                        txtObjectHeight.Text = String.Empty;
                        txtQuantity.Text = String.Empty;
                }
            }
        }
        //_____________________________________________________________________________________
        //delete
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
                    int oldvalue;
                    CellIndex = gridObjects.CurrentCell.RowIndex;
                    oldvalue = Int32.Parse(gridObjects.Rows[CellIndex].Cells[2].Value.ToString());
                    gridObjects.Rows.RemoveAt(CellIndex);
                    ObjectCreated -= oldvalue;
                    lblObjectCreated.Text = ObjectCreated.ToString();
                }
            }
        }
        //_______________________________________________________________________________________
        //gridObject
        private void gridObjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellIndex = e.RowIndex;
            if (CellIndex >= 0)
            {
                DataGridViewRow Row = gridObjects.Rows[CellIndex];
                txtObjectWidth.Text = Row.Cells[0].Value.ToString();
                txtObjectHeight.Text = Row.Cells[1].Value.ToString();
                txtQuantity.Text = Row.Cells[2].Value.ToString();
            }
        }
        //_________________________________________________________________________
        //only numbers

            //first
        private void txtObjectWidth_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtObjectWidth.Text, "  ^ [0-9]"))
            {
                txtObjectWidth.Text = "";
            }
        }

        
        private void txtObjectWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //second
        private void txtObjectHeight_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtObjectWidth.Text, "  ^ [0-9]"))
            {
                txtObjectWidth.Text = "";
            }
        }

        private void txtObjectHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //third
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtObjectWidth.Text, "  ^ [0-9]"))
            {
                txtObjectWidth.Text = "";
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
