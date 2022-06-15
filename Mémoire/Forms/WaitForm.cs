﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mémoire.Forms
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public WaitForm(Form parent)
        {
            InitializeComponent();
            if(parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X / 2 + parent.Width / 2 - this.Width / 2,
                                          parent.Location.Y / 2 + parent.Height / 2 - this.Height / 2);
            }
            else
                this.StartPosition = FormStartPosition.CenterParent;
        }
        public void CloseWaitForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if(label1.Image != null)
            {
                label1.Image.Dispose();
            }
        }
    }
}
