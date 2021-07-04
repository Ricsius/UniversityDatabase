namespace University
{
    partial class StudentAddressModificationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.newStudentAddressSubmitButton = new System.Windows.Forms.Button();
            this.newStudentAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 105);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "New address";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(233, 177);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newStudentAddressSubmitButton
            // 
            this.newStudentAddressSubmitButton.Location = new System.Drawing.Point(96, 174);
            this.newStudentAddressSubmitButton.Name = "newStudentAddressSubmitButton";
            this.newStudentAddressSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.newStudentAddressSubmitButton.TabIndex = 3;
            this.newStudentAddressSubmitButton.Text = "Submit";
            this.newStudentAddressSubmitButton.UseVisualStyleBackColor = true;
            this.newStudentAddressSubmitButton.Click += new System.EventHandler(this.newStudentAddressSubmitButton_Click);
            // 
            // newStudentAddressTextBox
            // 
            this.newStudentAddressTextBox.Location = new System.Drawing.Point(15, 51);
            this.newStudentAddressTextBox.MaxLength = 100;
            this.newStudentAddressTextBox.Name = "newStudentAddressTextBox";
            this.newStudentAddressTextBox.Size = new System.Drawing.Size(268, 22);
            this.newStudentAddressTextBox.TabIndex = 4;
            // 
            // StudentAddressModificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 226);
            this.Controls.Add(this.newStudentAddressTextBox);
            this.Controls.Add(this.newStudentAddressSubmitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Name = "StudentAddressModificationForm";
            this.Text = "Student address change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newStudentAddressSubmitButton;
        private System.Windows.Forms.TextBox newStudentAddressTextBox;
    }
}