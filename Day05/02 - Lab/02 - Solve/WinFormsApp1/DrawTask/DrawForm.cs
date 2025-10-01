namespace DrawTask
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
            else if(e.Button == MouseButtons.Right)
            {
                SolidBrush solidBrush = new SolidBrush(BackColor);
                grx.FillEllipse(solidBrush, e.X - 20, e.Y - 20, 40, 40);
            }
                
        }
    }
}
