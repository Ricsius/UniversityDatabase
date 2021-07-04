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
    public partial class TeacherNameModificationForm : Form
    {
        UniversityDatabaseModel um;
        Teachers selectedTeacher;
        public TeacherNameModificationForm(UniversityDatabaseModel model, Teachers teacher)
        {
            InitializeComponent();

            this.um = model;
            this.selectedTeacher = teacher;
        }

        private void newTeacherNameSubmitButton_Click(object sender, EventArgs e)
        {
            string errorText = "";

            if(this.newTeacherNameTextBox.Text.Length > 0)
            {
                this.selectedTeacher.Name = newTeacherNameTextBox.Text;
                this.um.SaveChanges();
                this.Close();
            }

            if(this.newTeacherNameTextBox.Text.Length == 0)
            {
                this.errorLabel.Visible = true;
                errorText += "You didn't write a name!";
            }

            this.errorLabel.Text = errorText;
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
