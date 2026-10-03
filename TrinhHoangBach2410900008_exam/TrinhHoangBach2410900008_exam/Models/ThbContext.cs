using Microsoft.EntityFrameworkCore;

namespace TrinhHoangBach2410900008_exam.Models
{
    public class ThbStudentDbContext : DbContext
    {
        public ThbStudentDbContext(
            DbContextOptions<ThbStudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<ThbStudent> ThbStudents { get; set; }
    }
}