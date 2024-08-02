
using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;

namespace StudentPortal.Data
{
    public class StudentPortalDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Attendance> AttendanceRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sms.db");
        }
    }
}
