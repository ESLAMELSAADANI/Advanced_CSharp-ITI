using System.Xml.Linq;

namespace LoginFormTask
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = textName.Text,
                Age = int.Parse(textAge.Text),
                Email = textEmail.Text
            };
            MessageBox.Show(user.ToString());
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {

        }
    }
}
