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
    public partial class TeacherDetailsForm : Form
    {
        UniversityDatabaseModel um;
        Teachers selectedTeacher;
        public TeacherDetailsForm(UniversityDatabaseModel model, Teachers teacher)
        {
            InitializeComponent();

            this.um = model;
            this.selectedTeacher = teacher;

            this.UpdateTeacherDetails();
        }

        private void UpdateTeacherDetails()
        {
            this.teacherNameLabel.Text = this.selectedTeacher.Name;
            this.teacherIdLabel.Text = this.selectedTeacher.Id.ToString();

            this.UpdateOpenCoursesListBox();
            this.UpdateClosedCoursesListBox();
        }

        private void UpdateOpenCoursesListBox()
        {
            this.openCoursesListBox.Items.Clear();

            string query = "SELECT * FROM CourseTimes,Courses WHERE Courses.EndDate IS NULL AND " +
                "Courses.Id = CourseTimes.CourseId AND " +
                "CourseTimes.TeacherId = " + this.selectedTeacher.Id;

            List<CourseTimes> q = um.CourseTimes.SqlQuery(query).ToList<CourseTimes>();

            foreach (CourseTimes c in q)
            {
                this.openCoursesListBox.Items.Add(c);
            }
        }

        private void UpdateClosedCoursesListBox()
        {
            this.closedCoursesListBox.Items.Clear();

            string query = "SELECT * FROM CourseTimes,Courses WHERE Courses.EndDate IS NOT NULL AND " +
                "Courses.Id = CourseTimes.CourseId AND " +
                "CourseTimes.TeacherId = " + this.selectedTeacher.Id;

            List<CourseTimes> q = um.CourseTimes.SqlQuery(query).ToList<CourseTimes>();

            foreach (CourseTimes c in q)
            {
                this.closedCoursesListBox.Items.Add(c);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teacherNameModificationButton_Click(object sender, EventArgs e)
        {
            TeacherNameModificationForm tnmf = new TeacherNameModificationForm(this.um, this.selectedTeacher);

            tnmf.ShowDialog();

            this.teacherNameLabel.Text = this.selectedTeacher.Name;
        }
    }
}
