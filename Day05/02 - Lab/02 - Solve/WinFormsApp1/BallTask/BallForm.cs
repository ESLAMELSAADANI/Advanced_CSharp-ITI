namespace BallTask
{
    public partial class frmBall : Form
    {
        public frmBall()
        {
            InitializeComponent();
        }

        int x = 0;
        int y = 80;
        int ballSize = 50;
        private void frmBall_Paint(object sender, PaintEventArgs e)
        {
            Graphics grx = e.Graphics;
            grx.FillEllipse(Brushes.Red, x, y, ballSize, ballSize);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            if (x + ballSize >= this.ClientSize.Width)
            {
                x = 0;       
                y += 50;     
            }
            if (y + ballSize >= this.ClientSize.Height)
            {
                y = 50;
                x = 0;
            }
            this.Invalidate();//Redraw the form with new x position
        }
    }
}
