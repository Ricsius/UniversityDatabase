namespace University
{
    partial class CourseNameModificationForm
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newCourseNameTextBox = new System.Windows.Forms.TextBox();
            this.newCourseNameSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 130);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(137, 194);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "New name";
            // 
            // newCourseNameTextBox
            // 
            this.newCourseNameTextBox.Location = new System.Drawing.Point(12, 63);
            this.newCourseNameTextBox.MaxLength = 50;
            this.newCourseNameTextBox.Name = "newCourseNameTextBox";
            this.newCourseNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.newCourseNameTextBox.TabIndex = 6;
            // 
            // newCourseNameSubmitButton
            // 
            this.newCourseNameSubmitButton.Location = new System.Drawing.Point(45, 194);
            this.newCourseNameSubmitButton.Name = "newCourseNameSubmitButton";
            this.newCourseNameSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.newCourseNameSubmitButton.TabIndex = 5;
            this.newCourseNameSubmitButton.Text = "Submit";
            this.newCourseNameSubmitButton.UseVisualStyleBackColor = true;
            this.newCourseNameSubmitButton.Click += new System.EventHandler(this.newCourseNameSubmitButton_Click);
            // 
            // CourseNameModificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 231);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newCourseNameTextBox);
            this.Controls.Add(this.newCourseNameSubmitButton);
            this.Name = "CourseNameModificationForm";
            this.Text = "Course name change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newCourseNameTextBox;
        private System.Windows.Forms.Button newCourseNameSubmitButton;
    }
}