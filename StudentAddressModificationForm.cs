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
    public partial class StudentAddressModificationForm : Form
    {
        UniversityDatabaseModel um;
        Students selectedStudent;
        public StudentAddressModificationForm(UniversityDatabaseModel model, Students student)
        {
            InitializeComponent();

            this.um = model;
            this.selectedStudent = student;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newStudentAddressSubmitButton_Click(object sender, EventArgs e)
        {
            string errorText = "";

            if (this.newStudentAddressTextBox.Text.Length > 0)
            {
                this.selectedStudent.Address = newStudentAddressTextBox.Text;
                this.um.SaveChanges();
                this.Close();
            }

            if (this.newStudentAddressTextBox.Text.Length == 0)
            {
                this.errorLabel.Visible = true;
                errorText += "You didn't write an address!";
            }

            this.errorLabel.Text = errorText;
        }
    }
}
