namespace LoginFormTask
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblAge = new Label();
            lblEmail = new Label();
            textName = new TextBox();
            textAge = new TextBox();
            textEmail = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(179, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            //lblName.Click += label1_Click;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(179, 78);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age";
            //lblAge.Click += label1_Click_1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(179, 114);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // textName
            // 
            textName.Location = new Point(234, 43);
            textName.Name = "textName";
            textName.Size = new Size(125, 27);
            textName.TabIndex = 2;
            // 
            // textAge
            // 
            textAge.Location = new Point(234, 78);
            textAge.Name = "textAge";
            textAge.Size = new Size(125, 27);
            textAge.TabIndex = 2;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(234, 111);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(125, 27);
            textEmail.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(244, 167);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(textEmail);
            Controls.Add(textAge);
            Controls.Add(textName);
            Controls.Add(lblEmail);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Name = "frmLogin";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAge;
        private Label lblEmail;
        private TextBox textName;
        private TextBox textAge;
        private TextBox textEmail;
        private Button btnLogin;
    }
}
