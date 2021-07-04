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
    public partial class CourseNameModificationForm : Form
    {
        UniversityDatabaseModel um;
        Courses selectedCourse;
        public CourseNameModificationForm(UniversityDatabaseModel model, Courses course)
        {
            InitializeComponent();

            this.um = model;
            this.selectedCourse = course;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCourseNameSubmitButton_Click(object sender, EventArgs e)
        {
            string errorText = "";

            if (this.newCourseNameTextBox.Text.Length > 0)
            {
                this.selectedCourse.Name = newCourseNameTextBox.Text;
                this.um.SaveChanges();
                this.Close();
            }

            if (this.newCourseNameTextBox.Text.Length == 0)
            {
                this.errorLabel.Visible = true;
                errorText += "You didn't write a name!";
            }

            this.errorLabel.Text = errorText;
        }
    }
}
