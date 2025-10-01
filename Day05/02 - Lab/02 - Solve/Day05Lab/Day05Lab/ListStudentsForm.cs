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
    public partial class frmListStudents : Form
    {
        public frmListStudents()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>()
        {
            new Student(){Id = 1,Name = "Eslam",Age = 23},
            new Student(){Id = 2,Name = "Osama",Age = 24},
            new Student(){Id = 3,Name = "Ahmed",Age = 25},
            new Student(){Id = 4,Name = "Mohamed",Age = 28},
            new Student(){Id = 5,Name = "Abdallah",Age = 25},
        };

        private void frmListStudents_Load(object sender, EventArgs e)
        {
            cmbStudents.DataSource = students;
            cmbStudents.DisplayMember = "Name";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbStudents.SelectedItem.ToString());
        }

    }
}
