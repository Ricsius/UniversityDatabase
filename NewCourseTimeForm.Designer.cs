namespace University
{
    partial class NewCourseTimeForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.newCourseTimeBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newCourseTimeEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newCourseTimeRoomTextBox = new System.Windows.Forms.TextBox();
            this.newCourseTimeDayComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newCourseTimeSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(108, 380);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newCourseTimeBeginDateTimePicker
            // 
            this.newCourseTimeBeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newCourseTimeBeginDateTimePicker.Location = new System.Drawing.Point(12, 175);
            this.newCourseTimeBeginDateTimePicker.Name = "newCourseTimeBeginDateTimePicker";
            this.newCourseTimeBeginDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.newCourseTimeBeginDateTimePicker.TabIndex = 1;
            // 
            // newCourseTimeEndDateTimePicker
            // 
            this.newCourseTimeEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newCourseTimeEndDateTimePicker.Location = new System.Drawing.Point(12, 248);
            this.newCourseTimeEndDateTimePicker.Name = "newCourseTimeEndDateTimePicker";
            this.newCourseTimeEndDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.newCourseTimeEndDateTimePicker.TabIndex = 2;
            // 
            // newCourseTimeRoomTextBox
            // 
            this.newCourseTimeRoomTextBox.Location = new System.Drawing.Point(12, 45);
            this.newCourseTimeRoomTextBox.MaxLength = 50;
            this.newCourseTimeRoomTextBox.Name = "newCourseTimeRoomTextBox";
            this.newCourseTimeRoomTextBox.Size = new System.Drawing.Size(232, 22);
            this.newCourseTimeRoomTextBox.TabIndex = 3;
            // 
            // newCourseTimeDayComboBox
            // 
            this.newCourseTimeDayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newCourseTimeDayComboBox.FormattingEnabled = true;
            this.newCourseTimeDayComboBox.Location = new System.Drawing.Point(12, 108);
            this.newCourseTimeDayComboBox.Name = "newCourseTimeDayComboBox";
            this.newCourseTimeDayComboBox.Size = new System.Drawing.Size(121, 24);
            this.newCourseTimeDayComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Day";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(9, 305);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Begin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Room";
            // 
            // newCourseTimeSubmitButton
            // 
            this.newCourseTimeSubmitButton.Location = new System.Drawing.Point(5, 380);
            this.newCourseTimeSubmitButton.Name = "newCourseTimeSubmitButton";
            this.newCourseTimeSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.newCourseTimeSubmitButton.TabIndex = 10;
            this.newCourseTimeSubmitButton.Text = "Submit";
            this.newCourseTimeSubmitButton.UseVisualStyleBackColor = true;
            this.newCourseTimeSubmitButton.Click += new System.EventHandler(this.newCourseTimeSubmitButton_Click);
            // 
            // NewCourseTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.newCourseTimeSubmitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newCourseTimeDayComboBox);
            this.Controls.Add(this.newCourseTimeRoomTextBox);
            this.Controls.Add(this.newCourseTimeEndDateTimePicker);
            this.Controls.Add(this.newCourseTimeBeginDateTimePicker);
            this.Controls.Add(this.backButton);
            this.Name = "NewCourseTimeForm";
            this.Text = "New course time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DateTimePicker newCourseTimeBeginDateTimePicker;
        private System.Windows.Forms.DateTimePicker newCourseTimeEndDateTimePicker;
        private System.Windows.Forms.TextBox newCourseTimeRoomTextBox;
        private System.Windows.Forms.ComboBox newCourseTimeDayComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newCourseTimeSubmitButton;
    }
}