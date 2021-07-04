namespace University
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Text;

    public partial class CourseTimes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int CourseId { get; set; }

        [Required]
        [StringLength(10)]
        public string Day { get; set; }

        public TimeSpan Begin { get; set; }

        public TimeSpan End { get; set; }

        [Required]
        [StringLength(50)]
        public string Room { get; set; }

        public int? TeacherId { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            UniversityDatabaseModel um = new UniversityDatabaseModel();
            string query = "SELECT * FROM Courses WHERE Id = " + this.CourseId.ToString();

            foreach (Courses c in um.Courses.SqlQuery(query))
            {
                sb.Append(c.ToString());
            }

            sb.Append(" ");
            sb.Append(this.Day);
            sb.Append(" ");
            sb.Append(this.Room);
            sb.Append(" ");
            sb.Append(this.Begin.ToString());
            sb.Append("-");
            sb.Append(this.End.ToString());

            return sb.ToString();
        }
    }
}
