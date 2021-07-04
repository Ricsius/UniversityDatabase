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
    public partial class NewTeacherForm : Form
    {
        UniversityDatabaseModel um;

        public NewTeacherForm(UniversityDatabaseModel model)
        {
            InitializeComponent();
            this.um = model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.newTeacherNameTextBox.Text.Length > 0)
            {
                List<Teachers> q = this.um.Teachers.SqlQuery("SELECT * FROM Teachers").ToList<Teachers>();
                SqlParameter idParam = new SqlParameter("id", q.Count);
                SqlParameter nameParam = new SqlParameter("name", this.newTeacherNameTextBox.Text);
                string query = "INSERT INTO Teachers VALUES(@id, @name)";

                this.um.Database.ExecuteSqlCommand(query, idParam, nameParam);
                this.um.SaveChanges();
                this.Close();
            }
            else
            {
                this.errorLabel.Text = "You didn't write a name!";
                this.errorLabel.Visible = true;
            }
        }
    }
}
