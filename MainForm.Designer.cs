namespace University
{
    partial class MainForm
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
            this.newTeacherButton = new System.Windows.Forms.Button();
            this.newStudentButton = new System.Windows.Forms.Button();
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.PaymentListBox = new System.Windows.Forms.ListBox();
            this.newCourseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newPaymentButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.teacherSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTeacherButton
            // 
            this.newTeacherButton.Location = new System.Drawing.Point(12, 391);
            this.newTeacherButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newTeacherButton.Name = "newTeacherButton";
            this.newTeacherButton.Size = new System.Drawing.Size(120, 23);
            this.newTeacherButton.TabIndex = 0;
            this.newTeacherButton.Text = "New teacher";
            this.newTeacherButton.UseVisualStyleBackColor = true;
            this.newTeacherButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newStudentButton
            // 
            this.newStudentButton.Location = new System.Drawing.Point(228, 391);
            this.newStudentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(103, 23);
            this.newStudentButton.TabIndex = 1;
            this.newStudentButton.Text = "New student";
            this.newStudentButton.UseVisualStyleBackColor = true;
            this.newStudentButton.Click += new System.EventHandler(this.newStudentButton_Click);
            // 
            // teacherListBox
            // 
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.ItemHeight = 16;
            this.teacherListBox.Location = new System.Drawing.Point(269, 63);
            this.teacherListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(240, 84);
            this.teacherListBox.TabIndex = 2;
            this.teacherListBox.DoubleClick += new System.EventHandler(this.teacherListBox_DoubleClick);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 16;
            this.studentListBox.Location = new System.Drawing.Point(545, 63);
            this.studentListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(240, 84);
            this.studentListBox.TabIndex = 3;
            this.studentListBox.DoubleClick += new System.EventHandler(this.studentListBox_DoubleClick);
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 16;
            this.courseListBox.Location = new System.Drawing.Point(135, 240);
            this.courseListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(240, 84);
            this.courseListBox.TabIndex = 4;
            this.courseListBox.DoubleClick += new System.EventHandler(this.courseListBox_DoubleClick);
            // 
            // PaymentListBox
            // 
            this.PaymentListBox.FormattingEnabled = true;
            this.PaymentListBox.ItemHeight = 16;
            this.PaymentListBox.Location = new System.Drawing.Point(411, 240);
            this.PaymentListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentListBox.Name = "PaymentListBox";
            this.PaymentListBox.Size = new System.Drawing.Size(374, 84);
            this.PaymentListBox.TabIndex = 5;
            // 
            // newCourseButton
            // 
            this.newCourseButton.Location = new System.Drawing.Point(471, 391);
            this.newCourseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newCourseButton.Name = "newCourseButton";
            this.newCourseButton.Size = new System.Drawing.Size(99, 23);
            this.newCourseButton.TabIndex = 6;
            this.newCourseButton.Text = "New course";
            this.newCourseButton.UseVisualStyleBackColor = true;
            this.newCourseButton.Click += new System.EventHandler(this.newCourseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teachers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Payments";
            // 
            // newPaymentButton
            // 
            this.newPaymentButton.Location = new System.Drawing.Point(660, 391);
            this.newPaymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPaymentButton.Name = "newPaymentButton";
            this.newPaymentButton.Size = new System.Drawing.Size(125, 23);
            this.newPaymentButton.TabIndex = 11;
            this.newPaymentButton.Text = "New Payment";
            this.newPaymentButton.UseVisualStyleBackColor = true;
            this.newPaymentButton.Click += new System.EventHandler(this.newPaymentButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 13;
            // 
            // teacherSearchButton
            // 
            this.teacherSearchButton.Location = new System.Drawing.Point(36, 106);
            this.teacherSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.teacherSearchButton.Name = "teacherSearchButton";
            this.teacherSearchButton.Size = new System.Drawing.Size(114, 25);
            this.teacherSearchButton.TabIndex = 14;
            this.teacherSearchButton.Text = "Search teacher";
            this.teacherSearchButton.UseVisualStyleBackColor = true;
            this.teacherSearchButton.Click += new System.EventHandler(this.teacherSearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teacherSearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newPaymentButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newCourseButton);
            this.Controls.Add(this.PaymentListBox);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.teacherListBox);
            this.Controls.Add(this.newStudentButton);
            this.Controls.Add(this.newTeacherButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "University Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTeacherButton;
        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.ListBox PaymentListBox;
        private System.Windows.Forms.Button newCourseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newPaymentButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button teacherSearchButton;
    }
}

