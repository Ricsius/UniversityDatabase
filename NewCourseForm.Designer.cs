namespace University
{
    partial class NewCourseForm
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
            this.courseStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.courseCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.courseEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newCourseSubmitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.courseDayComboBox = new System.Windows.Forms.ComboBox();
            this.courseRoomTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseCostNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // courseStartTimePicker
            // 
            this.courseStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.courseStartTimePicker.Location = new System.Drawing.Point(11, 267);
            this.courseStartTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseStartTimePicker.Name = "courseStartTimePicker";
            this.courseStartTimePicker.ShowUpDown = true;
            this.courseStartTimePicker.Size = new System.Drawing.Size(200, 22);
            this.courseStartTimePicker.TabIndex = 1;
            // 
            // courseCostNumericUpDown
            // 
            this.courseCostNumericUpDown.Location = new System.Drawing.Point(11, 422);
            this.courseCostNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseCostNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.courseCostNumericUpDown.Name = "courseCostNumericUpDown";
            this.courseCostNumericUpDown.Size = new System.Drawing.Size(156, 22);
            this.courseCostNumericUpDown.TabIndex = 2;
            // 
            // courseEndTimePicker
            // 
            this.courseEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.courseEndTimePicker.Location = new System.Drawing.Point(11, 352);
            this.courseEndTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseEndTimePicker.Name = "courseEndTimePicker";
            this.courseEndTimePicker.ShowUpDown = true;
            this.courseEndTimePicker.Size = new System.Drawing.Size(200, 22);
            this.courseEndTimePicker.TabIndex = 3;
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(12, 43);
            this.courseNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseNameTextBox.MaxLength = 50;
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(169, 22);
            this.courseNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "End time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "HUF";
            // 
            // newCourseSubmitButton
            // 
            this.newCourseSubmitButton.Location = new System.Drawing.Point(92, 489);
            this.newCourseSubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newCourseSubmitButton.Name = "newCourseSubmitButton";
            this.newCourseSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.newCourseSubmitButton.TabIndex = 11;
            this.newCourseSubmitButton.Text = "Submit";
            this.newCourseSubmitButton.UseVisualStyleBackColor = true;
            this.newCourseSubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(8, 537);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // courseDayComboBox
            // 
            this.courseDayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseDayComboBox.FormattingEnabled = true;
            this.courseDayComboBox.Location = new System.Drawing.Point(11, 191);
            this.courseDayComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseDayComboBox.Name = "courseDayComboBox";
            this.courseDayComboBox.Size = new System.Drawing.Size(121, 24);
            this.courseDayComboBox.TabIndex = 13;
            // 
            // courseRoomTextBox
            // 
            this.courseRoomTextBox.Location = new System.Drawing.Point(13, 117);
            this.courseRoomTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseRoomTextBox.MaxLength = 50;
            this.courseRoomTextBox.Name = "courseRoomTextBox";
            this.courseRoomTextBox.Size = new System.Drawing.Size(168, 22);
            this.courseRoomTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Room";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(202, 489);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // NewCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 699);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.courseRoomTextBox);
            this.Controls.Add(this.courseDayComboBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.newCourseSubmitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseEndTimePicker);
            this.Controls.Add(this.courseCostNumericUpDown);
            this.Controls.Add(this.courseStartTimePicker);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewCourseForm";
            this.Text = "New Course";
            ((System.ComponentModel.ISupportInitialize)(this.courseCostNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker courseStartTimePicker;
        private System.Windows.Forms.NumericUpDown courseCostNumericUpDown;
        private System.Windows.Forms.DateTimePicker courseEndTimePicker;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button newCourseSubmitButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox courseDayComboBox;
        private System.Windows.Forms.TextBox courseRoomTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backButton;
    }
}