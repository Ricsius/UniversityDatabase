using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class NewPaymentForm : Form
    {
        UniversityDatabaseModel um;
        public NewPaymentForm(UniversityDatabaseModel model)
        {
            InitializeComponent();

            this.um = model;

            foreach (Students s in um.Students)
            {
                this.studentsComboBox.Items.Add(s);
            }

            if(this.studentsComboBox.Items.Count > 0)
            {
                this.studentsComboBox.SelectedIndex = 0;
            }
        }

        private void newPaymentSubmitButton_Click(object sender, EventArgs e)
        {
            string errorString = "";

            if (this.studentsComboBox.SelectedIndex >= 0 && this.paymentAmountNumricUpDown.Value > 0)
            {
                Students selectedStudent = (Students)this.studentsComboBox.SelectedItem;
                List<Payments> q = this.um.Payments.SqlQuery("SELECT * FROM Payments").ToList<Payments>();
                SqlParameter idParam = new SqlParameter("id", q.Count);
                SqlParameter studentIdParam = new SqlParameter("sid", selectedStudent.Id);
                SqlParameter amountParam = new SqlParameter("amount", this.paymentAmountNumricUpDown.Value);
                SqlParameter dateParam = new SqlParameter("date", this.dateTimePicker.Value);
                string query = "INSERT INTO Payments VALUES(@id, @sid, @amount, @date)";

                this.um.Database.ExecuteSqlCommand(query, idParam, studentIdParam, amountParam, dateParam);
                this.um.SaveChanges();
                this.Close();
            }

            if (this.studentsComboBox.SelectedIndex < 0)
            {
                errorString += "You didn't choose a student!\n\n";
                this.errorLabel.Visible = true;
            }

            if (this.paymentAmountNumricUpDown.Value <= 0)
            {
                errorString += "You can't input a payment amount less than 1!";
                this.errorLabel.Visible = true;
            }

            this.errorLabel.Text = errorString;
        }
    }
}
