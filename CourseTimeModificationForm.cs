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
    public partial class CourseTimeModificationForm : Form
    {
        UniversityDatabaseModel um;
        CourseTimes selectedCourseTime;
        public CourseTimeModificationForm(UniversityDatabaseModel model, CourseTimes courseTime)
        {
            InitializeComponent();

            this.um = model;
            this.selectedCourseTime = courseTime;

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            for (int i = 0; i < days.Length; i++)
            {
                this.newDayComboBox.Items.Add(days[i]);

                if(days[i] == this.selectedCourseTime.Day)
                {
                    this.newDayComboBox.SelectedIndex = i;
                }
            }

            DateTime dt = DateTime.Now;

            this.newRoomTextBox.Text = this.selectedCourseTime.Room;
            this.newBeginDateTimePicker.Value = dt.Date + this.selectedCourseTime.Begin;
            this.newEndDateTimePicker.Value = dt.Date + this.selectedCourseTime.End;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorString = "";

            if (this.newRoomTextBox.Text.Length > 0 &&
                !(this.newBeginDateTimePicker.Value >= this.newEndDateTimePicker.Value))
            {
                string selectedDay = this.newDayComboBox.SelectedItem.ToString();

                this.selectedCourseTime.Room = this.newRoomTextBox.Text;
                this.selectedCourseTime.Day = selectedDay;
                this.selectedCourseTime.Begin = this.newBeginDateTimePicker.Value.TimeOfDay;
                this.selectedCourseTime.End = this.newEndDateTimePicker.Value.TimeOfDay;

                this.um.SaveChanges();
                this.Close();
            }

            if (this.newRoomTextBox.Text.Length == 0)
            {
                errorString += "You didn't write a room for the course!\n\n";
                this.errorLabel.Visible = true;
            }

            if (this.newBeginDateTimePicker.Value >= this.newEndDateTimePicker.Value)
            {
                errorString += "The course start time is greater or equal to course end time!\n\n";
                this.errorLabel.Visible = true;
            }

            this.errorLabel.Text = errorString;
        }
    }
}
