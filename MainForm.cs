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
    public partial class MainForm : Form
    {
        UniversityDatabaseModel um;
        public MainForm()
        {
            InitializeComponent();
            this.um = new UniversityDatabaseModel();

            this.UpdateTeacherListBox();
            this.UpdateStudentListBox();
            this.UpdateCourseListBox();
            this.UpdatePaymentListBox();
        }

        private void UpdateTeacherListBox()
        {
            teacherListBox.Items.Clear();
            foreach (Teachers t in um.Teachers.SqlQuery("SELECT * FROM Teachers ORDER BY Name"))
            {
                teacherListBox.Items.Add(t);
            }
        }
        private void UpdateStudentListBox()
        {
            studentListBox.Items.Clear();
            foreach (Students s in um.Students.SqlQuery("SELECT * FROM Students ORDER BY Name"))
            {
                studentListBox.Items.Add(s);
            }
        }
        private void UpdateCourseListBox()
        {
            courseListBox.Items.Clear();
            foreach (Courses c in um.Courses.SqlQuery("SELECT * FROM Courses ORDER BY Name"))
            {
                courseListBox.Items.Add(c);
            }
        }
        private void UpdatePaymentListBox()
        {
            PaymentListBox.Items.Clear();
            foreach (Payments p in um.Payments.SqlQuery("SELECT * FROM Payments ORDER BY Date"))
            {
                PaymentListBox.Items.Add(p);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewTeacherForm ntf = new NewTeacherForm(this.um);
            ntf.ShowDialog();
            this.UpdateTeacherListBox();
        }

        private void newStudentButton_Click(object sender, EventArgs e)
        {
            NewStudentForm nsf = new NewStudentForm(this.um);
            nsf.ShowDialog();
            this.UpdateStudentListBox();
        }

        private void teacherListBox_DoubleClick(object sender, EventArgs e)
        {
            if(this.teacherListBox.SelectedIndex >= 0)
            {
                TeacherDetailsForm tdf = new TeacherDetailsForm(this.um, (Teachers)this.teacherListBox.SelectedItem);

                tdf.ShowDialog();
                this.UpdateTeacherListBox();
            }
        }

        private void newPaymentButton_Click(object sender, EventArgs e)
        {
            NewPaymentForm npf = new NewPaymentForm(this.um);
            npf.ShowDialog();
            this.UpdatePaymentListBox();
        }

        private void newCourseButton_Click(object sender, EventArgs e)
        {
            NewCourseForm ncf = new NewCourseForm(this.um);
            ncf.ShowDialog();
            this.UpdateCourseListBox();
        }

        private void teacherSearchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Teachers Where Name LIKE '%" + this.textBox1.Text + "%'";
            this.teacherListBox.Items.Clear();

            foreach (Teachers t in this.um.Teachers.SqlQuery(query))
            {
                teacherListBox.Items.Add(t);
            }
        }

        private void studentListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.studentListBox.SelectedIndex >= 0)
            {
                StudentDetailsForm sdf = new StudentDetailsForm(this.um, (Students)this.studentListBox.SelectedItem);
                sdf.ShowDialog();
                this.UpdateStudentListBox();
                this.UpdatePaymentListBox();
            }
        }

        private void courseListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.courseListBox.SelectedIndex >= 0)
            {
                CourseDetailsForm cdf = new CourseDetailsForm(this.um, (Courses)this.courseListBox.SelectedItem);
                cdf.ShowDialog();
                this.UpdateCourseListBox();
            }
        }
    }
}
