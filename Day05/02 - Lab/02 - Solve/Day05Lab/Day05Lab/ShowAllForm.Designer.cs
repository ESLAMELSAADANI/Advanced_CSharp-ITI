namespace Day05Lab
{
    partial class frmAllTasks
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
            btnLoginTask = new Button();
            btnListStudents = new Button();
            btnDrawTask = new Button();
            btnBallTask = new Button();
            SuspendLayout();
            // 
            // btnLoginTask
            // 
            btnLoginTask.Location = new Point(98, 194);
            btnLoginTask.Name = "btnLoginTask";
            btnLoginTask.Size = new Size(145, 29);
            btnLoginTask.TabIndex = 0;
            btnLoginTask.Text = "LoginTask";
            btnLoginTask.UseVisualStyleBackColor = true;
            btnLoginTask.Click += btnLoginTask_Click;
            // 
            // btnListStudents
            // 
            btnListStudents.Location = new Point(249, 194);
            btnListStudents.Name = "btnListStudents";
            btnListStudents.Size = new Size(145, 29);
            btnListStudents.TabIndex = 0;
            btnListStudents.Text = "ListStudentsTask";
            btnListStudents.UseVisualStyleBackColor = true;
            btnListStudents.Click += btnListStudents_Click;
            // 
            // btnDrawTask
            // 
            btnDrawTask.Location = new Point(400, 194);
            btnDrawTask.Name = "btnDrawTask";
            btnDrawTask.Size = new Size(145, 29);
            btnDrawTask.TabIndex = 0;
            btnDrawTask.Text = "Draw Task";
            btnDrawTask.UseVisualStyleBackColor = true;
            btnDrawTask.Click += btnDrawTask_Click;
            // 
            // btnBallTask
            // 
            btnBallTask.Location = new Point(551, 194);
            btnBallTask.Name = "btnBallTask";
            btnBallTask.Size = new Size(145, 29);
            btnBallTask.TabIndex = 0;
            btnBallTask.Text = "Ball Task";
            btnBallTask.UseVisualStyleBackColor = true;
            btnBallTask.Click += btnBallTask_Click;
            // 
            // frmAllTasks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBallTask);
            Controls.Add(btnDrawTask);
            Controls.Add(btnListStudents);
            Controls.Add(btnLoginTask);
            Name = "frmAllTasks";
            Text = "Show All Tasks";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoginTask;
        private Button btnListStudents;
        private Button btnDrawTask;
        private Button btnBallTask;
    }
}
