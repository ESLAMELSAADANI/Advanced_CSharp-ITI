using BallTask;
using DrawTask;
using ListStudents;
using LoginFormTask;

namespace ShowAllTasks
{
    public partial class frmAllTasks : Form
    {
        public frmAllTasks()
        {
            InitializeComponent();
        }

        private void btnLoginTask_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
        private void btnListStudents_Click(object sender, EventArgs e)
        {
            frmListStudents frmListStudents = new frmListStudents();
            frmListStudents.Show();
        }
        private void btnDrawTask_Click(object sender, EventArgs e)
        {
            frmDraw frmDraw = new frmDraw();
            frmDraw.Show();
        }
        private void btnBallTask_Click(object sender, EventArgs e)
        {
            frmBall frmBall = new frmBall();
            frmBall.Show();
        }
    }
}
