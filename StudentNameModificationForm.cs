using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class StudentNameModificationForm : Form
    {
        UniversityDatabaseModel um;
        Students selectedStudent;
        public StudentNameModificationForm(UniversityDatabaseModel model, Students student)
        {
            InitializeComponent();

            this.um = model;
            this.selectedStudent = student;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newStudentNameSubmitButton_Click(object sender, EventArgs e)
        {
            string errorText = "";

            if (this.newStudentNameTextBox.Text.Length > 0)
            {
                string query = "UPDATE Students SET Name = '" + this.newStudentNameTextBox.Text + "' WHERE Id = " + selectedStudent.Id;

                this.selectedStudent.Name = newStudentNameTextBox.Text;
                this.um.Database.ExecuteSqlCommand(query);
                this.um.SaveChanges();
                this.Close();
            }

            if (this.newStudentNameTextBox.Text.Length == 0)
            {
                this.errorLabel.Visible = true;
                errorText += "You didn't write a name!";
            }

            this.errorLabel.Text = errorText;
        }
    }
}
