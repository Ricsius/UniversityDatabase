namespace University
{
    partial class TeacherDetailsForm
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
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.closedCoursesListBox = new System.Windows.Forms.ListBox();
            this.openCoursesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherNameModificationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(306, 359);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Location = new System.Drawing.Point(9, 127);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(43, 17);
            this.teacherNameLabel.TabIndex = 1;
            this.teacherNameLabel.Text = "name";
            // 
            // closedCoursesListBox
            // 
            this.closedCoursesListBox.FormattingEnabled = true;
            this.closedCoursesListBox.ItemHeight = 16;
            this.closedCoursesListBox.Location = new System.Drawing.Point(631, 60);
            this.closedCoursesListBox.Name = "closedCoursesListBox";
            this.closedCoursesListBox.Size = new System.Drawing.Size(396, 196);
            this.closedCoursesListBox.TabIndex = 3;
            // 
            // openCoursesListBox
            // 
            this.openCoursesListBox.FormattingEnabled = true;
            this.openCoursesListBox.ItemHeight = 16;
            this.openCoursesListBox.Location = new System.Drawing.Point(147, 60);
            this.openCoursesListBox.Name = "openCoursesListBox";
            this.openCoursesListBox.Size = new System.Drawing.Size(396, 196);
            this.openCoursesListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Open course times";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Closed course times";
            // 
            // teacherNameModificationButton
            // 
            this.teacherNameModificationButton.Location = new System.Drawing.Point(12, 159);
            this.teacherNameModificationButton.Name = "teacherNameModificationButton";
            this.teacherNameModificationButton.Size = new System.Drawing.Size(110, 23);
            this.teacherNameModificationButton.TabIndex = 7;
            this.teacherNameModificationButton.Text = "Modify name";
            this.teacherNameModificationButton.UseVisualStyleBackColor = true;
            this.teacherNameModificationButton.Click += new System.EventHandler(this.teacherNameModificationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id";
            // 
            // teacherIdLabel
            // 
            this.teacherIdLabel.AutoSize = true;
            this.teacherIdLabel.Location = new System.Drawing.Point(9, 60);
            this.teacherIdLabel.Name = "teacherIdLabel";
            this.teacherIdLabel.Size = new System.Drawing.Size(19, 17);
            this.teacherIdLabel.TabIndex = 10;
            this.teacherIdLabel.Text = "id";
            // 
            // TeacherDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 396);
            this.Controls.Add(this.teacherIdLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacherNameModificationButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openCoursesListBox);
            this.Controls.Add(this.closedCoursesListBox);
            this.Controls.Add(this.teacherNameLabel);
            this.Controls.Add(this.backButton);
            this.Name = "TeacherDetailsForm";
            this.Text = "Teacher Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.ListBox closedCoursesListBox;
        private System.Windows.Forms.ListBox openCoursesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button teacherNameModificationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label teacherIdLabel;
    }
}