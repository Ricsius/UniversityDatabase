namespace University
{
    partial class StudentNameModificationForm
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
            this.newStudentNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.newStudentNameSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(181, 177);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newStudentNameTextBox
            // 
            this.newStudentNameTextBox.Location = new System.Drawing.Point(12, 60);
            this.newStudentNameTextBox.MaxLength = 50;
            this.newStudentNameTextBox.Name = "newStudentNameTextBox";
            this.newStudentNameTextBox.Size = new System.Drawing.Size(189, 22);
            this.newStudentNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "New name";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(9, 111);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // newStudentNameSubmitButton
            // 
            this.newStudentNameSubmitButton.Location = new System.Drawing.Point(67, 177);
            this.newStudentNameSubmitButton.Name = "newStudentNameSubmitButton";
            this.newStudentNameSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.newStudentNameSubmitButton.TabIndex = 4;
            this.newStudentNameSubmitButton.Text = "Submit";
            this.newStudentNameSubmitButton.UseVisualStyleBackColor = true;
            this.newStudentNameSubmitButton.Click += new System.EventHandler(this.newStudentNameSubmitButton_Click);
            // 
            // StudentNameModificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 222);
            this.Controls.Add(this.newStudentNameSubmitButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newStudentNameTextBox);
            this.Controls.Add(this.backButton);
            this.Name = "StudentNameModificationForm";
            this.Text = "Student name change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox newStudentNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button newStudentNameSubmitButton;
    }
}