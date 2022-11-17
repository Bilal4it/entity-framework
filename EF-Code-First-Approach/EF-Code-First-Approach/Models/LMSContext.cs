using Microsoft.EntityFrameworkCore;

namespace EF_Code_First_Approach.Models
{
    public class LMSContext : DbContext
    {
        public LMSContext()
        { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Catagories { get; set; }

        public DbSet<Exam> Exams{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=LMS;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
