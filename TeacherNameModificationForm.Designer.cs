namespace University
{
    partial class TeacherNameModificationForm
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
            this.newTeacherNameSubmitButton = new System.Windows.Forms.Button();
            this.newTeacherNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newTeacherNameSubmitButton
            // 
            this.newTeacherNameSubmitButton.Location = new System.Drawing.Point(45, 196);
            this.newTeacherNameSubmitButton.Name = "newTeacherNameSubmitButton";
            this.newTeacherNameSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.newTeacherNameSubmitButton.TabIndex = 0;
            this.newTeacherNameSubmitButton.Text = "Submit";
            this.newTeacherNameSubmitButton.UseVisualStyleBackColor = true;
            this.newTeacherNameSubmitButton.Click += new System.EventHandler(this.newTeacherNameSubmitButton_Click);
            // 
            // newTeacherNameTextBox
            // 
            this.newTeacherNameTextBox.Location = new System.Drawing.Point(12, 65);
            this.newTeacherNameTextBox.MaxLength = 50;
            this.newTeacherNameTextBox.Name = "newTeacherNameTextBox";
            this.newTeacherNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.newTeacherNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "New name";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(137, 196);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 132);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // TeacherNameModificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 231);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newTeacherNameTextBox);
            this.Controls.Add(this.newTeacherNameSubmitButton);
            this.Name = "TeacherNameModificationForm";
            this.Text = "Teacher name change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newTeacherNameSubmitButton;
        private System.Windows.Forms.TextBox newTeacherNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label errorLabel;
    }
}