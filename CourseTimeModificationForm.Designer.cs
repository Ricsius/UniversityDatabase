namespace University
{
    partial class CourseTimeModificationForm
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
            this.newBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.newDayComboBox = new System.Windows.Forms.ComboBox();
            this.newRoomTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newBeginDateTimePicker
            // 
            this.newBeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newBeginDateTimePicker.Location = new System.Drawing.Point(12, 208);
            this.newBeginDateTimePicker.Name = "newBeginDateTimePicker";
            this.newBeginDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.newBeginDateTimePicker.TabIndex = 0;
            // 
            // newEndDateTimePicker
            // 
            this.newEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newEndDateTimePicker.Location = new System.Drawing.Point(12, 287);
            this.newEndDateTimePicker.Name = "newEndDateTimePicker";
            this.newEndDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.newEndDateTimePicker.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(15, 442);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(234, 442);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // newDayComboBox
            // 
            this.newDayComboBox.FormattingEnabled = true;
            this.newDayComboBox.Location = new System.Drawing.Point(12, 122);
            this.newDayComboBox.Name = "newDayComboBox";
            this.newDayComboBox.Size = new System.Drawing.Size(121, 24);
            this.newDayComboBox.TabIndex = 4;
            // 
            // newRoomTextBox
            // 
            this.newRoomTextBox.Location = new System.Drawing.Point(12, 52);
            this.newRoomTextBox.MaxLength = 50;
            this.newRoomTextBox.Name = "newRoomTextBox";
            this.newRoomTextBox.Size = new System.Drawing.Size(240, 22);
            this.newRoomTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Day";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(9, 256);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(33, 17);
            this.v.TabIndex = 8;
            this.v.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Begin";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(9, 334);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // CourseTimeModificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 481);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newRoomTextBox);
            this.Controls.Add(this.newDayComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newEndDateTimePicker);
            this.Controls.Add(this.newBeginDateTimePicker);
            this.Name = "CourseTimeModificationForm";
            this.Text = "Course time change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker newBeginDateTimePicker;
        private System.Windows.Forms.DateTimePicker newEndDateTimePicker;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox newDayComboBox;
        private System.Windows.Forms.TextBox newRoomTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLabel;
    }
}