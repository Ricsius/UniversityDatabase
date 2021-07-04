using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace University
{
    public partial class CourseDetailsForm : Form
    {
        UniversityDatabaseModel um;
        Courses selectedCourse;
        CourseTimes selectedCourseTime;
        int courseStudentCount;
        int maxStuddentCountForCourseTime;
        int courseLaunchThreshold;
        int selectedCourseTimeStudentCount;
        bool isClosedCourse;
        public CourseDetailsForm(UniversityDatabaseModel model, Courses course)
        {
            InitializeComponent();

            this.um = model;
            this.selectedCourse = course;
            this.maxStuddentCountForCourseTime = 8;
            this.courseLaunchThreshold = 4;

            this.teacherLabel.Text = "";
            this.teacherNameLabel.Text = "";

            UpdateCourseDetails();
        }

        private void UpdateCourseDetails()
        {
            this.isClosedCourse = false;
            this.courseIdLabel.Text = this.selectedCourse.Id.ToString();
            this.courseNameLabel.Text = this.selectedCourse.Name;

            this.UpdateCourseStudentCountLabel();


            this.UpdateCourseStatusLabel();

            if(this.isClosedCourse)
            {
                this.teachersLabel.Visible = false;
                this.newCourseTimeButton.Visible = false;
                this.courseNameModificationButton.Visible = false;
                this.addStudentButton.Visible = false;
                this.selectTeacherButton.Visible = false;
                this.newStudentComboBox.Visible = false;
                this.newTeacherComboBox.Visible = false;
                this.closeCourseButton.Visible = false;
                this.changeCourseTimeButton.Visible = false;
            }

            UpdateCourseTimesListBox();
        }

        private void UpdateCourseStatusLabel()
        {
            if (this.selectedCourse.EndDate != null)
            {
                this.isClosedCourse = true;
                this.courseStatusLabel.Text = "Closed";
            }
            else if (this.courseStudentCount >= this.courseLaunchThreshold)
            {
                this.courseStatusLabel.Text = "Launched";
            }
            else
            {
                this.courseStatusLabel.Text = "Open";
            }
        }
        private void UpdateCourseTimesListBox()
        {
            this.courseTimesListBox.Items.Clear();

            string query = "SELECT * FROM CourseTimes WHERE CourseId = " + this.selectedCourse.Id.ToString();

            foreach (CourseTimes c in this.um.CourseTimes.SqlQuery(query))
            {
                this.courseTimesListBox.Items.Add(c);
            }
        }

        private void UpdateStudentsListBox()
        {
            this.courseStudentsListBox.Items.Clear();

            string query = "SELECT * FROM Students,CourseAttendees WHERE CourseAttendees.StudentId = Students.Id AND " +
                "CourseAttendees.CourseTimeId = " + this.selectedCourseTime.Id.ToString() 
                + " ORDER BY Students.Name";

            foreach (Students s in this.um.Students.SqlQuery(query))
            {
                this.courseStudentsListBox.Items.Add(s);
            }

            if(this.courseStudentsListBox.Items.Count > 0)
            {
                this.studentListExporterButton.Enabled = true;
            }
            else
            {
                this.studentListExporterButton.Enabled = false;
            }
        }

        private void UpdateNewStudentComboBox()
        {
            this.newStudentComboBox.Items.Clear();

            string query1 = "(SELECT * FROM Students)";

            string query2 = "(SELECT Students.Id, Students.Name, Students.Address  FROM Students,CourseAttendees WHERE CourseAttendees.StudentId = Students.Id AND " +
                "CourseAttendees.CourseTimeId = " + this.selectedCourseTime.Id.ToString() + ")";

            string query3 = query1 + " EXCEPT " + query2 + " ORDER BY Name";

            string query4 = "SELECT * FROM CourseTimes,CourseAttendees WHERE CourseTimes.Id = " + this.selectedCourseTime.Id + " AND "
                + "CourseTimes.Id = CourseAttendees.CourseTimeId";

            this.selectedCourseTimeStudentCount = this.um.CourseAttendees.SqlQuery(query4).ToList().Count;

            if(this.selectedCourseTimeStudentCount + 1 <= this.maxStuddentCountForCourseTime)
            {
                this.newStudentComboBox.Enabled = true;
                this.addStudentButton.Enabled = true;

                foreach (Students s in this.um.Students.SqlQuery(query3))
                {
                    this.newStudentComboBox.Items.Add(s);
                }

                if (this.newStudentComboBox.Items.Count > 0)
                {
                    this.newStudentComboBox.SelectedIndex = 0;
                    this.newStudentComboBox.Enabled = true;
                    this.addStudentButton.Enabled = true;
                }
                else
                {
                    this.newStudentComboBox.Enabled = false;
                    this.addStudentButton.Enabled = false;
                }
            }
            else
            {
                this.newStudentComboBox.Enabled = false;
                this.addStudentButton.Enabled = false;
            }
        }

        private void UpdateNewTeacherComboBox()
        {
            string query;

            if (this.selectedCourseTime.TeacherId == null)
            {
                query = "SELECT * FROM Teachers ORDER BY Name";
            }
            else
            {
                query = "SELECT * FROM Teachers WHERE Id <> " + this.selectedCourseTime.TeacherId.ToString() + " ORDER BY Name";
            }

            this.newTeacherComboBox.Items.Clear();

            foreach (Teachers t in this.um.Teachers.SqlQuery(query))
            {
                this.newTeacherComboBox.Items.Add(t);
            }

            if(this.newTeacherComboBox.Items.Count > 0)
            {
                this.newTeacherComboBox.SelectedIndex = 0;
            }
        }

        private void ExportStudentListToXML(string path)
        {
            if (path != "")
            {
                path += "\\students.xml";

                string query = "SELECT * FROM Students,CourseAttendees WHERE CourseAttendees.StudentId = Students.Id AND " +
                "CourseAttendees.CourseTimeId = " + this.selectedCourseTime.Id.ToString()
                + " ORDER BY Students.Name";



                using (XmlWriter writer = XmlWriter.Create(path))
                {
                    writer.WriteStartElement("Course_info");
                    writer.WriteElementString("Course_id", this.selectedCourse.Id.ToString());
                    writer.WriteElementString("Course_name", this.selectedCourse.Name);
                    writer.WriteElementString("Room", this.selectedCourseTime.Room);
                    writer.WriteElementString("Begin", this.selectedCourseTime.Begin.ToString());
                    writer.WriteElementString("End", this.selectedCourseTime.End.ToString());

                    writer.WriteStartElement("Student_list");

                    foreach (Students s in this.um.Students.SqlQuery(query))
                    {
                        writer.WriteStartElement("Student");
                        writer.WriteElementString("Id", s.Id.ToString());
                        writer.WriteElementString("Name", s.Name);
                        writer.WriteElementString("Address", s.Address);
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }

        private void UpdateCourseStudentCountLabel()
        {
            string query = "SELECT DISTINCT Students.Id, Students.Name, Students.Address FROM Students,Courses,CourseTimes,CourseAttendees WHERE Courses.Id = " + this.selectedCourse.Id.ToString() + " AND " +
                "CourseTimes.CourseId = Courses.Id" + " AND "
                + "CourseTimes.Id = CourseAttendees.CourseTimeId AND " +
                "Students.Id = CourseAttendees.StudentId";

            this.courseStudentCount = this.um.Students.SqlQuery(query).ToList().Count;
            this.courseStudentCountLabel.Text = this.courseStudentCount.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void courseNameModificationButton_Click(object sender, EventArgs e)
        {
            CourseNameModificationForm cnmf = new CourseNameModificationForm(this.um, this.selectedCourse);
            cnmf.ShowDialog();
            this.courseNameLabel.Text = this.selectedCourse.Name;
        }

        private void newCourseTimeButton_Click(object sender, EventArgs e)
        {
            NewCourseTimeForm nctf = new NewCourseTimeForm(this.um, this.selectedCourse);
            nctf.ShowDialog();
            this.UpdateCourseTimesListBox();
        }

        private void closeCourseButton_Click(object sender, EventArgs e)
        {
            string date = (DateTime.Today.ToString());

            this.selectedCourse.EndDate = DateTime.Now;
            this.um.SaveChanges();

            this.UpdateCourseDetails();
        }

        private void courseTimesListBox_Click(object sender, EventArgs e)
        {
            if (this.courseTimesListBox.SelectedIndex >= 0)
            {
                this.selectedCourseTime = (CourseTimes)courseTimesListBox.SelectedItem;
                this.UpdateStudentsListBox();
                this.studentsLabel.Visible = true;
                this.courseStudentsListBox.Visible = true;
                this.changeCourseTimeButton.Enabled = true;

                if (!this.isClosedCourse)
                {
                    this.UpdateNewStudentComboBox();

                    this.newStudentComboBox.Visible = true;
                    this.addStudentButton.Visible = true;

                    this.teachersLabel.Visible = true;
                    this.newTeacherComboBox.Visible = true;
                    this.selectTeacherButton.Visible = true;

                    this.UpdateNewTeacherComboBox();
                }

                if (this.selectedCourseTime.TeacherId == null)
                {
                    this.teacherLabel.Text = "This course time dosen't have a teacher!";
                    this.teacherNameLabel.Text = "";
                }
                else
                {
                    string query = "SELECT * FROM Teachers WHERE Id = " + this.selectedCourseTime.TeacherId.ToString();
                    this.teacherLabel.Text = "Teacher";

                    foreach (Teachers t in this.um.Teachers.SqlQuery(query))
                    {
                        this.teacherNameLabel.Text = t.Name;
                    }
                }
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (this.newStudentComboBox.SelectedIndex >= 0)
            {
                Students selectedStudent = (Students)this.newStudentComboBox.SelectedItem;
                List<CourseAttendees> q = this.um.CourseAttendees.SqlQuery("SELECT * FROM CourseAttendees").ToList<CourseAttendees>();
                SqlParameter idParam = new SqlParameter("id", q.Count);
                SqlParameter courseTimeIdParam = new SqlParameter("courseTimeId", this.selectedCourseTime.Id);
                SqlParameter studentIdParam = new SqlParameter("studentId", selectedStudent.Id);
                string query = "INSERT INTO CourseAttendees VALUES(@id, @courseTimeId, @studentId)";

                if(this.selectedCourse.BeginDate == null && this.courseStudentCount + 1 >= this.courseLaunchThreshold)
                {
                    this.selectedCourse.BeginDate = DateTime.Now;
                }

                this.um.Database.ExecuteSqlCommand(query, idParam, courseTimeIdParam, studentIdParam);
                this.um.SaveChanges();

                this.UpdateNewStudentComboBox();
                this.UpdateCourseStudentCountLabel();
                this.UpdateStudentsListBox();
                this.UpdateCourseStatusLabel();
            }
        }

        private void selectTeacherButton_Click(object sender, EventArgs e)
        {
            if (this.newTeacherComboBox.SelectedIndex >= 0)
            {
                Teachers selectedTeacher = (Teachers)this.newTeacherComboBox.SelectedItem;

                this.selectedCourseTime.TeacherId = selectedTeacher.Id;
                this.um.SaveChanges();

                this.UpdateNewTeacherComboBox();
                this.teacherLabel.Text = "Teacher";
                this.teacherNameLabel.Text = selectedTeacher.Name;
            }
        }

        private void changeCourseTimeButton_Click(object sender, EventArgs e)
        {
            CourseTimeModificationForm ctmf = new CourseTimeModificationForm(this.um, this.selectedCourseTime);
            ctmf.ShowDialog();
            this.UpdateCourseTimesListBox();
        }

        private void studentListExporterButton_Click(object sender, EventArgs e)
        {
            string path = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            path += fbd.SelectedPath;

            this.ExportStudentListToXML(path);
        }
    }
}
