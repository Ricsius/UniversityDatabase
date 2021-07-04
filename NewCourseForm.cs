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
    public partial class NewCourseForm : Form
    {
        UniversityDatabaseModel um;
        public NewCourseForm(UniversityDatabaseModel model)
        {
            InitializeComponent();

            this.um = model;

            this.courseDayComboBox.Items.Add("Monday");
            this.courseDayComboBox.Items.Add("Tuesday");
            this.courseDayComboBox.Items.Add("Wednesday");
            this.courseDayComboBox.Items.Add("Thursday");
            this.courseDayComboBox.Items.Add("Friday");
            this.courseDayComboBox.Items.Add("Saturday");
            this.courseDayComboBox.Items.Add("Sunday");

            this.courseDayComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorString = "";

            if (this.courseNameTextBox.Text.Length > 0 &&
                this.courseRoomTextBox.Text.Length > 0 &&
                this.courseStartTimePicker.Value < this.courseEndTimePicker.Value && 
                this.courseCostNumericUpDown.Value >= 0)
            {
                string selectedDay = this.courseDayComboBox.SelectedItem.ToString();
                List<Courses> q1 = this.um.Courses.SqlQuery("SELECT * FROM Courses").ToList<Courses>();
                List<CourseTimes> q2 = this.um.CourseTimes.SqlQuery("SELECT * FROM CourseTimes").ToList<CourseTimes>();
                SqlParameter dayParam = new SqlParameter("day", selectedDay);
                SqlParameter courseIdParam = new SqlParameter("cid", q1.Count());
                SqlParameter courseTimeIdParam = new SqlParameter("ctid", q2.Count());
                SqlParameter courseNameParam = new SqlParameter("name", this.courseNameTextBox.Text);
                SqlParameter startTimeParam = new SqlParameter("start", this.courseStartTimePicker.Value);
                SqlParameter endTimeParam = new SqlParameter("end", this.courseEndTimePicker.Value);
                SqlParameter costParam = new SqlParameter("cost", this.courseCostNumericUpDown.Value);
                SqlParameter roomParam = new SqlParameter("room", this.courseRoomTextBox.Text);
                string query1 = "INSERT INTO Courses VALUES(@cid, @name, @cost, NULL, NULL)";
                string query2 = "INSERT INTO CourseTimes VALUES(@ctid, @cid, @day, @start, @end, @room, NULL)";

                this.um.Database.ExecuteSqlCommand(query1, courseIdParam, courseNameParam, costParam);
                this.um.Database.ExecuteSqlCommand(query2, courseTimeIdParam, courseIdParam, dayParam, startTimeParam, endTimeParam, roomParam);
                this.um.SaveChanges();
                this.Close();
            }

            if (this.courseNameTextBox.Text.Length == 0)
            {
                errorString += "You didn't write a course name!\n\n";
                this.errorLabel.Visible = true;
            }

            if (this.courseRoomTextBox.Text.Length == 0)
            {
                errorString += "You didn't write a room for the course!\n\n";
                this.errorLabel.Visible = true;
            }

            if (this.courseStartTimePicker.Value >= this.courseEndTimePicker.Value)
            {
                errorString += "The course start time is greater or equal to course end time!\n\n";
                this.errorLabel.Visible = true;
            }

            if (this.courseCostNumericUpDown.Value < 0)
            {
                errorString += "The course can't have a negative cost!";
                this.errorLabel.Visible = true;
            }

            this.errorLabel.Text = errorString;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
