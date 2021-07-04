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

namespace University
{
    public partial class NewCourseTimeForm : Form
    {
        UniversityDatabaseModel um;
        Courses selectedCourse;
        public NewCourseTimeForm(UniversityDatabaseModel model, Courses course)
        {
            InitializeComponent();

            this.um = model;
            this.selectedCourse = course;

            this.newCourseTimeDayComboBox.Items.Add("Monday");
            this.newCourseTimeDayComboBox.Items.Add("Tuesday");
            this.newCourseTimeDayComboBox.Items.Add("Wednesday");
            this.newCourseTimeDayComboBox.Items.Add("Thursday");
            this.newCourseTimeDayComboBox.Items.Add("Friday");
            this.newCourseTimeDayComboBox.Items.Add("Saturday");
            this.newCourseTimeDayComboBox.Items.Add("Sunday");

            this.newCourseTimeDayComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCourseTimeSubmitButton_Click(object sender, EventArgs e)
        {
            string errorString = "";

            if (this.newCourseTimeRoomTextBox.Text.Length > 0 &&
                !(this.newCourseTimeBeginDateTimePicker.Value >= this.newCourseTimeEndDateTimePicker.Value))
            {
                string selectedDay = this.newCourseTimeDayComboBox.SelectedItem.ToString();
                List<CourseTimes> q = this.um.CourseTimes.SqlQuery("SELECT * FROM CourseTimes").ToList<CourseTimes>();

                SqlParameter dayParam = new SqlParameter("day", selectedDay);
                SqlParameter courseTimeIdParam = new SqlParameter("ctid", q.Count());
                SqlParameter courseIdParam = new SqlParameter("cid", this.selectedCourse.Id);
                SqlParameter startTimeParam = new SqlParameter("start", this.newCourseTimeBeginDateTimePicker.Value);
                SqlParameter endTimeParam = new SqlParameter("end", this.newCourseTimeEndDateTimePicker.Value);
                SqlParameter roomParam = new SqlParameter("room", this.newCourseTimeRoomTextBox.Text);

                string query = "INSERT INTO CourseTimes VALUES(@ctid, @cid, @day, @start, @end, @room, NULL)";

                this.um.Database.ExecuteSqlCommand(query, courseTimeIdParam, courseIdParam, dayParam, startTimeParam, endTimeParam, roomParam);
                this.um.SaveChanges();
                this.Close();
            }

            if (this.newCourseTimeRoomTextBox.Text.Length == 0)
            {
                errorString += "You didn't write a room for the course!\n\n";
                this.errorLabel.Visible = true;
            }

            if (this.newCourseTimeBeginDateTimePicker.Value >= this.newCourseTimeEndDateTimePicker.Value)
            {
                errorString += "The course start time is greater or equal to course end time!\n\n";
                this.errorLabel.Visible = true;
            }

            this.errorLabel.Text = errorString;
        }
    }
}
