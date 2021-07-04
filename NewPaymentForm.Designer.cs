namespace University
{
    partial class NewPaymentForm
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
            this.newPaymentSubmitButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentAmountNumricUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.studentsComboBox = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentAmountNumricUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // newPaymentSubmitButton
            // 
            this.newPaymentSubmitButton.Location = new System.Drawing.Point(68, 241);
            this.newPaymentSubmitButton.Name = "newPaymentSubmitButton";
            this.newPaymentSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.newPaymentSubmitButton.TabIndex = 0;
            this.newPaymentSubmitButton.Text = "Submit";
            this.newPaymentSubmitButton.UseVisualStyleBackColor = true;
            this.newPaymentSubmitButton.Click += new System.EventHandler(this.newPaymentSubmitButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 175);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(210, 22);
            this.dateTimePicker.TabIndex = 1;
            // 
            // paymentAmountNumricUpDown
            // 
            this.paymentAmountNumricUpDown.Location = new System.Drawing.Point(12, 111);
            this.paymentAmountNumricUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.paymentAmountNumricUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paymentAmountNumricUpDown.Name = "paymentAmountNumricUpDown";
            this.paymentAmountNumricUpDown.Size = new System.Drawing.Size(103, 22);
            this.paymentAmountNumricUpDown.TabIndex = 2;
            this.paymentAmountNumricUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "HUF";
            // 
            // studentsComboBox
            // 
            this.studentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentsComboBox.FormattingEnabled = true;
            this.studentsComboBox.Location = new System.Drawing.Point(15, 40);
            this.studentsComboBox.Name = "studentsComboBox";
            this.studentsComboBox.Size = new System.Drawing.Size(203, 24);
            this.studentsComboBox.TabIndex = 4;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 293);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student";
            // 
            // NewPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 357);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.studentsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentAmountNumricUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.newPaymentSubmitButton);
            this.Name = "NewPaymentForm";
            this.Text = "New Payment";
            ((System.ComponentModel.ISupportInitialize)(this.paymentAmountNumricUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newPaymentSubmitButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown paymentAmountNumricUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentsComboBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}