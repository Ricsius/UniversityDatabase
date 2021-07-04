namespace University
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Text;

    public partial class Payments
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            UniversityDatabaseModel um = new UniversityDatabaseModel();
            string query = "SELECT * FROM Students WHERE Id = " + this.StudentId.ToString();

            sb.Append(this.Date.Year);
            sb.Append(".");

            if (this.Date.Month < 10)
            {
                sb.Append("0");
            }

            sb.Append(this.Date.Month);
            sb.Append(".");

            if (this.Date.Day < 10)
            {
                sb.Append("0");
            }

            sb.Append(this.Date.Day);
            sb.Append(" ");

            foreach (Students s in um.Students.SqlQuery(query))
            {
                sb.Append(s.Name);
            }
            sb.Append(" ");
            sb.Append(this.Amount.ToString());
            sb.Append(" HUF");

            return sb.ToString();
        }
    }
}
