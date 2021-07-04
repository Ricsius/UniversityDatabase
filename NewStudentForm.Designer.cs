namespace University
{
    partial class NewStudentForm
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
            this.newStudentNameTextBox = new System.Windows.Forms.TextBox();
            this.newStudentSubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newStudentAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(16, 236);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // newStudentNameTextBox
            // 
            this.newStudentNameTextBox.Location = new System.Drawing.Point(20, 54);
            this.newStudentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newStudentNameTextBox.MaxLength = 50;
            this.newStudentNameTextBox.Name = "newStudentNameTextBox";
            this.newStudentNameTextBox.Size = new System.Drawing.Size(231, 22);
            this.newStudentNameTextBox.TabIndex = 5;
            // 
            // newStudentSubmitButton
            // 
            this.newStudentSubmitButton.Location = new System.Drawing.Point(88, 172);
            this.newStudentSubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newStudentSubmitButton.Name = "newStudentSubmitButton";
            this.newStudentSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.newStudentSubmitButton.TabIndex = 4;
            this.newStudentSubmitButton.Text = "Submit";
            this.newStudentSubmitButton.UseVisualStyleBackColor = true;
            this.newStudentSubmitButton.Click += new System.EventHandler(this.newStudentSubmitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address";
            // 
            // newStudentAddressTextBox
            // 
            this.newStudentAddressTextBox.Location = new System.Drawing.Point(21, 118);
            this.newStudentAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newStudentAddressTextBox.MaxLength = 50;
            this.newStudentAddressTextBox.Name = "newStudentAddressTextBox";
            this.newStudentAddressTextBox.Size = new System.Drawing.Size(231, 22);
            this.newStudentAddressTextBox.TabIndex = 8;
            // 
            // NewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newStudentAddressTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newStudentNameTextBox);
            this.Controls.Add(this.newStudentSubmitButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewStudentForm";
            this.Text = "New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newStudentNameTextBox;
        private System.Windows.Forms.Button newStudentSubmitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newStudentAddressTextBox;
    }
}