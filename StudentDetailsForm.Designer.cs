namespace University
{
    partial class StudentDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentAddressLabel = new System.Windows.Forms.Label();
            this.studentCourseTimesListBox = new System.Windows.Forms.ListBox();
            this.modifyStudentNameButton = new System.Windows.Forms.Button();
            this.modifyAddressButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(343, 374);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(37, 128);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(43, 17);
            this.studentNameLabel.TabIndex = 2;
            this.studentNameLabel.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // studentAddressLabel
            // 
            this.studentAddressLabel.AutoSize = true;
            this.studentAddressLabel.Location = new System.Drawing.Point(37, 204);
            this.studentAddressLabel.Name = "studentAddressLabel";
            this.studentAddressLabel.Size = new System.Drawing.Size(59, 17);
            this.studentAddressLabel.TabIndex = 4;
            this.studentAddressLabel.Text = "address";
            // 
            // studentCourseTimesListBox
            // 
            this.studentCourseTimesListBox.FormattingEnabled = true;
            this.studentCourseTimesListBox.ItemHeight = 16;
            this.studentCourseTimesListBox.Location = new System.Drawing.Point(200, 25);
            this.studentCourseTimesListBox.Name = "studentCourseTimesListBox";
            this.studentCourseTimesListBox.Size = new System.Drawing.Size(509, 228);
            this.studentCourseTimesListBox.TabIndex = 5;
            // 
            // modifyStudentNameButton
            // 
            this.modifyStudentNameButton.Location = new System.Drawing.Point(12, 283);
            this.modifyStudentNameButton.Name = "modifyStudentNameButton";
            this.modifyStudentNameButton.Size = new System.Drawing.Size(117, 23);
            this.modifyStudentNameButton.TabIndex = 6;
            this.modifyStudentNameButton.Text = "Modify name";
            this.modifyStudentNameButton.UseVisualStyleBackColor = true;
            this.modifyStudentNameButton.Click += new System.EventHandler(this.modifyStudentNameButton_Click);
            // 
            // modifyAddressButton
            // 
            this.modifyAddressButton.Location = new System.Drawing.Point(163, 283);
            this.modifyAddressButton.Name = "modifyAddressButton";
            this.modifyAddressButton.Size = new System.Drawing.Size(117, 23);
            this.modifyAddressButton.TabIndex = 7;
            this.modifyAddressButton.Text = "Modify address";
            this.modifyAddressButton.UseVisualStyleBackColor = true;
            this.modifyAddressButton.Click += new System.EventHandler(this.modifyAddressButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(37, 60);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(19, 17);
            this.studentIdLabel.TabIndex = 9;
            this.studentIdLabel.Text = "id";
            // 
            // StudentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 414);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifyAddressButton);
            this.Controls.Add(this.modifyStudentNameButton);
            this.Controls.Add(this.studentCourseTimesListBox);
            this.Controls.Add(this.studentAddressLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "StudentDetailsForm";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label studentAddressLabel;
        private System.Windows.Forms.ListBox studentCourseTimesListBox;
        private System.Windows.Forms.Button modifyStudentNameButton;
        private System.Windows.Forms.Button modifyAddressButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentIdLabel;
    }
}