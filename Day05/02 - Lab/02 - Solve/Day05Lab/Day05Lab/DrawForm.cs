using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day05Lab
{
    public partial class frmDraw : Form
    {
        public frmDraw()
        {
            InitializeComponent();
        }

        private void frmDraw_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics grx = CreateGraphics();
            if (e.Button == MouseButtons.Left)
                grx.FillEllipse(Brushes.Red, e.X - 20, e.Y - 20, 40, 40);
            else if (e.Button == MouseButtons.Right)
            {
                SolidBrush solidBrush = new SolidBrush(BackColor);
                grx.FillEllipse(solidBrush, e.X - 20, e.Y - 20, 40, 40);
            }
        }
    }
}
