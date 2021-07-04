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
    public partial class NewStudentForm : Form
    {
        UniversityDatabaseModel um;
        public NewStudentForm(UniversityDatabaseModel model)
        {
            InitializeComponent();
            this.um = model;
        }

        private void newStudentSubmitButton_Click(object sender, EventArgs e)
        {
            string errorString = "";

            if (this.newStudentNameTextBox.Text.Length > 0 && this.newStudentAddressTextBox.Text.Length > 0)
            {
                List<Students> q = this.um.Students.SqlQuery("SELECT * FROM Students").ToList<Students>();
                SqlParameter idParam = new SqlParameter("id", q.Count);
                SqlParameter nameParam = new SqlParameter("name", this.newStudentNameTextBox.Text);
                SqlParameter addressParam = new SqlParameter("address", this.newStudentAddressTextBox.Text);
                string query = "INSERT INTO Students VALUES(@id, @name, @address)";

                this.um.Database.ExecuteSqlCommand(query, idParam, nameParam, addressParam);
                this.um.SaveChanges();
                this.Close();
            }

            if(this.newStudentNameTextBox.Text.Length == 0)
            {
                errorString += "You didn't write a name!\n\n";
                this.errorLabel.Visible = true;
            }

            if (this.newStudentAddressTextBox.Text.Length == 0)
            {
                errorString += "You didn't write an address!";
                this.errorLabel.Visible = true;
            }

            this.errorLabel.Text = errorString;
        }
    }
}
