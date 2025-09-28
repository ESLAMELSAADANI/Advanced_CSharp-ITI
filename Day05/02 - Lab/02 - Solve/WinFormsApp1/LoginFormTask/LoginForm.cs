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
            MessageBox.Show($"Name: {textName.Text}\nAge: {textAge.Text}\nEmail: {textEmail.Text}");
        }

    }
}
