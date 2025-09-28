namespace WinFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            //this.Text = "EslamElsaadany";//Over ride text value inForm1.cs[Design].
            //btnClose.Text = "Cloooose";
            //btnClose.Click += (sender, e) => Text = "Helooo";
            //btnClose.Click += (sender, e) => this.Close();

            ////Add button with code.
            //Button b1 = new Button() { Text = "Show" };
            //b1.Width = 100;
            //b1.Height = 50;
            //b1.Location = new Point(200, 300);
            //Controls.Add(b1);

            //btnShow.Click += (sender, e) => this.Text = txtName.Text;//Bind Function To Click Event On Button Show



        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Text = "Hello From Click!";
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtName.Text, "Name", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Text = txtName.Text;
        }
    }
}
