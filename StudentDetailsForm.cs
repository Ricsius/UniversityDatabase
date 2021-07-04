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
    public partial class StudentDetailsForm : Form
    {
        UniversityDatabaseModel um;
        Students selectedStudent;
        public StudentDetailsForm(UniversityDatabaseModel model, Students student)
        {
            InitializeComponent();

            this.um = model;
            this.selectedStudent = student;

            this.UpdateStudentDetails();
        }

        private void UpdateStudentDetails()
        {
            this.studentIdLabel.Text = this.selectedStudent.Id.ToString();
            this.studentNameLabel.Text = this.selectedStudent.Name;
            this.studentAddressLabel.Text = this.selectedStudent.Address;

            this.UpdateStudentCourseTimesListBox();
        }

        private void UpdateStudentCourseTimesListBox()
        {
            string query = "SELECT * FROM CourseTimes,Courses,CourseAttendees WHERE CourseTimes.Id = CourseAttendees.CourseTimeId AND " +
                "CourseTimes.CourseId = Courses.Id AND " +
                "Courses.EndDate IS NULL AND " +
                "CourseAttendees.StudentId = " + this.selectedStudent.Id;
            List<CourseTimes> q = um.CourseTimes.SqlQuery(query).ToList<CourseTimes>();

            foreach (CourseTimes c in q)
            {
                this.studentCourseTimesListBox.Items.Add(c);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyStudentNameButton_Click(object sender, EventArgs e)
        {
            StudentNameModificationForm snmf = new StudentNameModificationForm(this.um, this.selectedStudent);
            snmf.ShowDialog();
            this.studentNameLabel.Text = this.selectedStudent.Name;
        }

        private void modifyAddressButton_Click(object sender, EventArgs e)
        {
            StudentAddressModificationForm samf = new StudentAddressModificationForm(this.um, this.selectedStudent);
            samf.ShowDialog();
            this.studentAddressLabel.Text = this.selectedStudent.Address;
        }
    }
}
