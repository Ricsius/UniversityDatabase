namespace University
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UniversityDatabaseModel : DbContext
    {
        public UniversityDatabaseModel()
            : base("name=UniversityDatabaseModel")
        {
        }

        public virtual DbSet<CourseAttendees> CourseAttendees { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<CourseTimes> CourseTimes { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CourseTimes>()
                .Property(e => e.Day)
                .IsUnicode(false);

            modelBuilder.Entity<CourseTimes>()
                .Property(e => e.Room)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Teachers>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
