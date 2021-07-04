namespace University
{
    partial class CourseDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addStudentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.courseStatusLabel = new System.Windows.Forms.Label();
            this.selectTeacherButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.courseNameModificationButton = new System.Windows.Forms.Button();
            this.courseStudentsListBox = new System.Windows.Forms.ListBox();
            this.courseTimesListBox = new System.Windows.Forms.ListBox();
            this.newTeacherComboBox = new System.Windows.Forms.ComboBox();
            this.newStudentComboBox = new System.Windows.Forms.ComboBox();
            this.newCourseTimeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.teachersLabel = new System.Windows.Forms.Label();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.closeCourseButton = new System.Windows.Forms.Button();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.studentListExporterButton = new System.Windows.Forms.Button();
            this.changeCourseTimeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.courseStudentCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(320, 587);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(124, 23);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Visible = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Location = new System.Drawing.Point(12, 50);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(19, 17);
            this.courseIdLabel.TabIndex = 2;
            this.courseIdLabel.Text = "id";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(12, 126);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(43, 17);
            this.courseNameLabel.TabIndex = 3;
            this.courseNameLabel.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status";
            // 
            // courseStatusLabel
            // 
            this.courseStatusLabel.AutoSize = true;
            this.courseStatusLabel.Location = new System.Drawing.Point(12, 197);
            this.courseStatusLabel.Name = "courseStatusLabel";
            this.courseStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.courseStatusLabel.TabIndex = 6;
            this.courseStatusLabel.Text = "status";
            // 
            // selectTeacherButton
            // 
            this.selectTeacherButton.Location = new System.Drawing.Point(561, 386);
            this.selectTeacherButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectTeacherButton.Name = "selectTeacherButton";
            this.selectTeacherButton.Size = new System.Drawing.Size(124, 23);
            this.selectTeacherButton.TabIndex = 7;
            this.selectTeacherButton.Text = "Select teacher";
            this.selectTeacherButton.UseVisualStyleBackColor = true;
            this.selectTeacherButton.Visible = false;
            this.selectTeacherButton.Click += new System.EventHandler(this.selectTeacherButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(353, 652);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // courseNameModificationButton
            // 
            this.courseNameModificationButton.Location = new System.Drawing.Point(29, 332);
            this.courseNameModificationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseNameModificationButton.Name = "courseNameModificationButton";
            this.courseNameModificationButton.Size = new System.Drawing.Size(108, 23);
            this.courseNameModificationButton.TabIndex = 9;
            this.courseNameModificationButton.Text = "Modify name";
            this.courseNameModificationButton.UseVisualStyleBackColor = true;
            this.courseNameModificationButton.Click += new System.EventHandler(this.courseNameModificationButton_Click);
            // 
            // courseStudentsListBox
            // 
            this.courseStudentsListBox.FormattingEnabled = true;
            this.courseStudentsListBox.ItemHeight = 16;
            this.courseStudentsListBox.Location = new System.Drawing.Point(320, 295);
            this.courseStudentsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseStudentsListBox.Name = "courseStudentsListBox";
            this.courseStudentsListBox.Size = new System.Drawing.Size(151, 164);
            this.courseStudentsListBox.TabIndex = 10;
            this.courseStudentsListBox.Visible = false;
            // 
            // courseTimesListBox
            // 
            this.courseTimesListBox.FormattingEnabled = true;
            this.courseTimesListBox.ItemHeight = 16;
            this.courseTimesListBox.Location = new System.Drawing.Point(181, 79);
            this.courseTimesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseTimesListBox.Name = "courseTimesListBox";
            this.courseTimesListBox.Size = new System.Drawing.Size(473, 164);
            this.courseTimesListBox.TabIndex = 12;
            this.courseTimesListBox.Click += new System.EventHandler(this.courseTimesListBox_Click);
            // 
            // newTeacherComboBox
            // 
            this.newTeacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newTeacherComboBox.FormattingEnabled = true;
            this.newTeacherComboBox.Location = new System.Drawing.Point(505, 330);
            this.newTeacherComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newTeacherComboBox.Name = "newTeacherComboBox";
            this.newTeacherComboBox.Size = new System.Drawing.Size(235, 24);
            this.newTeacherComboBox.TabIndex = 13;
            this.newTeacherComboBox.Visible = false;
            // 
            // newStudentComboBox
            // 
            this.newStudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newStudentComboBox.FormattingEnabled = true;
            this.newStudentComboBox.Location = new System.Drawing.Point(239, 533);
            this.newStudentComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newStudentComboBox.Name = "newStudentComboBox";
            this.newStudentComboBox.Size = new System.Drawing.Size(339, 24);
            this.newStudentComboBox.TabIndex = 14;
            this.newStudentComboBox.Visible = false;
            // 
            // newCourseTimeButton
            // 
            this.newCourseTimeButton.Location = new System.Drawing.Point(152, 332);
            this.newCourseTimeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newCourseTimeButton.Name = "newCourseTimeButton";
            this.newCourseTimeButton.Size = new System.Drawing.Size(132, 23);
            this.newCourseTimeButton.TabIndex = 15;
            this.newCourseTimeButton.Text = "New course time";
            this.newCourseTimeButton.UseVisualStyleBackColor = true;
            this.newCourseTimeButton.Click += new System.EventHandler(this.newCourseTimeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Course times";
            // 
            // teachersLabel
            // 
            this.teachersLabel.AutoSize = true;
            this.teachersLabel.Location = new System.Drawing.Point(501, 267);
            this.teachersLabel.Name = "teachersLabel";
            this.teachersLabel.Size = new System.Drawing.Size(68, 17);
            this.teachersLabel.TabIndex = 17;
            this.teachersLabel.Text = "Teachers";
            this.teachersLabel.Visible = false;
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Location = new System.Drawing.Point(317, 267);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(64, 17);
            this.studentsLabel.TabIndex = 18;
            this.studentsLabel.Text = "Students";
            this.studentsLabel.Visible = false;
            // 
            // closeCourseButton
            // 
            this.closeCourseButton.Location = new System.Drawing.Point(48, 437);
            this.closeCourseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeCourseButton.Name = "closeCourseButton";
            this.closeCourseButton.Size = new System.Drawing.Size(131, 23);
            this.closeCourseButton.TabIndex = 19;
            this.closeCourseButton.Text = "Close course";
            this.closeCourseButton.UseVisualStyleBackColor = true;
            this.closeCourseButton.Click += new System.EventHandler(this.closeCourseButton_Click);
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Location = new System.Drawing.Point(12, 245);
            this.teacherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(61, 17);
            this.teacherLabel.TabIndex = 20;
            this.teacherLabel.Text = "Teacher";
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Location = new System.Drawing.Point(12, 278);
            this.teacherNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(56, 17);
            this.teacherNameLabel.TabIndex = 21;
            this.teacherNameLabel.Text = "teacher";
            // 
            // studentListExporterButton
            // 
            this.studentListExporterButton.Enabled = false;
            this.studentListExporterButton.Location = new System.Drawing.Point(543, 467);
            this.studentListExporterButton.Name = "studentListExporterButton";
            this.studentListExporterButton.Size = new System.Drawing.Size(197, 23);
            this.studentListExporterButton.TabIndex = 22;
            this.studentListExporterButton.Text = "Export student list";
            this.studentListExporterButton.UseVisualStyleBackColor = true;
            this.studentListExporterButton.Click += new System.EventHandler(this.studentListExporterButton_Click);
            // 
            // changeCourseTimeButton
            // 
            this.changeCourseTimeButton.Enabled = false;
            this.changeCourseTimeButton.Location = new System.Drawing.Point(543, 25);
            this.changeCourseTimeButton.Name = "changeCourseTimeButton";
            this.changeCourseTimeButton.Size = new System.Drawing.Size(179, 23);
            this.changeCourseTimeButton.TabIndex = 23;
            this.changeCourseTimeButton.Text = "Change course time";
            this.changeCourseTimeButton.UseVisualStyleBackColor = true;
            this.changeCourseTimeButton.Click += new System.EventHandler(this.changeCourseTimeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Course student count";
            // 
            // courseStudentCountLabel
            // 
            this.courseStudentCountLabel.AutoSize = true;
            this.courseStudentCountLabel.Location = new System.Drawing.Point(672, 135);
            this.courseStudentCountLabel.Name = "courseStudentCountLabel";
            this.courseStudentCountLabel.Size = new System.Drawing.Size(14, 17);
            this.courseStudentCountLabel.TabIndex = 25;
            this.courseStudentCountLabel.Text = "x";
            // 
            // CourseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 700);
            this.Controls.Add(this.courseStudentCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeCourseTimeButton);
            this.Controls.Add(this.studentListExporterButton);
            this.Controls.Add(this.teacherNameLabel);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.closeCourseButton);
            this.Controls.Add(this.studentsLabel);
            this.Controls.Add(this.teachersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newCourseTimeButton);
            this.Controls.Add(this.newStudentComboBox);
            this.Controls.Add(this.newTeacherComboBox);
            this.Controls.Add(this.courseTimesListBox);
            this.Controls.Add(this.courseStudentsListBox);
            this.Controls.Add(this.courseNameModificationButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.selectTeacherButton);
            this.Controls.Add(this.courseStatusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.courseIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStudentButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseDetailsForm";
            this.Text = "Course Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label courseStatusLabel;
        private System.Windows.Forms.Button selectTeacherButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button courseNameModificationButton;
        private System.Windows.Forms.ListBox courseStudentsListBox;
        private System.Windows.Forms.ListBox courseTimesListBox;
        private System.Windows.Forms.ComboBox newTeacherComboBox;
        private System.Windows.Forms.ComboBox newStudentComboBox;
        private System.Windows.Forms.Button newCourseTimeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label teachersLabel;
        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.Button closeCourseButton;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Button studentListExporterButton;
        private System.Windows.Forms.Button changeCourseTimeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label courseStudentCountLabel;
    }
}