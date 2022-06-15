using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mémoire.Packing;
using Mémoire.Forms;

namespace Mémoire
{
    public partial class _2DBins : UserControl
    {
        WaitFormFunc waitForm = new WaitFormFunc();
        public _2DBins()
        {
            InitializeComponent();
        }
        private String _BinNumber;
        private String _Object;

        [Category("Custom")]
        public String BinNumber
        {
            get { return _BinNumber; }
            set { _BinNumber = value; lblBinNumber.Text = value; }
        }

        [Category("Custom")]
        public String Object
        {
            get { return _Object; }
            set { _Object = value; lblObjects.Text = value; }
        }



        private void btnBluePrint_Click(object sender, EventArgs e)
        {
            _2DPacking.BluePrintBin = Int32.Parse(lblBinNumber.Text)-1;
            BluePrint Display = new BluePrint();
            waitForm.show();
            Display.Show();
            waitForm.Close();
        }

        private void _2DBins_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 136, 0);
            this.ForeColor = Color.White;
            btnBluePrint.IconColor = Color.White;
            lblObjects.BackColor = Color.FromArgb(245, 136, 0);
            lblObjects.ForeColor = Color.White;
        }

        private void _2DBins_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(5, 24, 33);
            btnBluePrint.IconColor = Color.FromArgb(5, 24, 33);
            lblObjects.BackColor = Color.White;
            lblObjects.ForeColor = Color.FromArgb(5, 24, 33);
        }

        private void btnBluePrint_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(5, 24, 33);
            lblObjects.BackColor = Color.White;
            lblObjects.ForeColor = Color.FromArgb(5, 24, 33);
            btnBluePrint.BackColor = Color.FromArgb(245, 136, 0);
        }

        private void btnBluePrint_MouseLeave(object sender, EventArgs e)
        {
            btnBluePrint.BackColor = Color.Transparent;
        }
    }
}
