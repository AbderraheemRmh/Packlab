using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mémoire
{
    public partial class _1DBins : UserControl
    {
        public _1DBins()
        {
            InitializeComponent();
        }

        private String _BinNumber;
        private String _Object;

        [Category ("Custom")]
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

        private void lblObjects_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 136, 0);
            this.ForeColor = Color.White;
            lblObjects.BackColor = Color.FromArgb(245, 136, 0);
            lblObjects.ForeColor = Color.White;
        }

        private void lblObjects_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(5, 24, 33);
            lblObjects.BackColor = Color.White;
            lblObjects.ForeColor = Color.FromArgb(5, 24, 33);
        }

        private void Background_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(245, 136, 0);
            this.ForeColor = Color.White;
            lblObjects.BackColor = Color.FromArgb(245, 136, 0);
            lblObjects.ForeColor = Color.White;
        }

        private void Background_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.FromArgb(5, 24, 33);
            lblObjects.BackColor = Color.White;
            lblObjects.ForeColor = Color.FromArgb(5, 24, 33);
        }
    }
}
