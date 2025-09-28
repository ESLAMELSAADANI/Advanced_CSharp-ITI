namespace ListStudents
{
    partial class frmListStudents
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
            cmbStudents = new ComboBox();
            btnShow = new Button();
            SuspendLayout();
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(327, 62);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(151, 28);
            cmbStudents.TabIndex = 0;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(359, 116);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // frmListStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(cmbStudents);
            Name = "frmListStudents";
            Text = "ListStudents";
            Load += frmListStudents_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbStudents;
        private Button btnShow;
    }
}
