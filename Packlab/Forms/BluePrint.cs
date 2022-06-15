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
using System.Runtime.InteropServices;

namespace Mémoire.Forms
{
    public partial class BluePrint : Form
    {
        public int BinSize;
        Panel[] panels;
        private Size formSize;
        private int borderSize = 3;
        public BluePrint()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }
        public void Addpanels()
        {
            BinSize = _2DPacking.BinHeight * _2DPacking.BinWidth;
            panels = new Panel[_2DPacking.BinHeight * _2DPacking.BinWidth];
            for (int i = 0; i < BinSize; i++)
            {
                panels[i] = new Panel();
                panels[i].Location = new System.Drawing.Point((Canvas.Width / _2DPacking.BinWidth) * (i % _2DPacking.BinWidth), (Canvas.Height / _2DPacking.BinHeight) * (i / _2DPacking.BinWidth));
                panels[i].Name = "panel" + i;
                panels[i].Size = new System.Drawing.Size(Canvas.Width / _2DPacking.BinWidth, Canvas.Height / _2DPacking.BinHeight);
                panels[i].BackColor = Color.FromArgb(26, 70, 69);
                panels[i].BorderStyle = BorderStyle.FixedSingle;
                Canvas.Controls.Add(panels[i]);
            }
            Color CurrentColor = GenerateColor();
            int holder;
            for (int i = 0; i < _2DPacking.BinWidth; i++)
            {

                for (int j = 0; j < _2DPacking.BinHeight; j++)
                {
                    holder = _2DPacking.instense.population.Bins[_2DPacking.BluePrintBin].BinMatrix[j, i];
                    if (holder != 0)
                    {
                        for (int l = 0; l < _2DPacking.BinWidth; l++)
                        {

                            for (int m = 0; m < _2DPacking.BinHeight; m++)
                            {
                                if (_2DPacking.instense.population.Bins[_2DPacking.BluePrintBin].BinMatrix[m, l] == holder && panels[m * _2DPacking.BinWidth + l].BackColor == Color.FromArgb(26, 70, 69))
                                    panels[m * _2DPacking.BinWidth + l].BackColor = CurrentColor;
                            }
                        }
                        CurrentColor = GenerateColor();
                    }
                }

            }
        }
        public Color GenerateColor()
        {
            int red, green, blue;
            Random rand = new Random();
            red = rand.Next() % 256;
            System.Threading.Thread.Sleep(10);
            green = rand.Next() % 256;
            System.Threading.Thread.Sleep(10);
            blue = rand.Next() % 256;
            while (red == 26 && green == 70 && blue == 69)
            {
                red = rand.Next() % 256;
                System.Threading.Thread.Sleep(10);
                green = rand.Next() % 256;
                System.Threading.Thread.Sleep(10);
                blue = rand.Next() % 256;
            }
            return Color.FromArgb(red, green, blue);
        }

        private void BluePrint_Load(object sender, EventArgs e)
        {
            Addpanels();
            lblWS.Text = _2DPacking.instense.population.Bins[_2DPacking.BluePrintBin].Surface.ToString();
            lblB.Text = (_2DPacking.BluePrintBin + 1).ToString();
        }
        //-------------------------------
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //----------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //_______________________________________________________________________________
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //___________________________________________________________________________________________
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //____________________________________________________________________________
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
    }
}
