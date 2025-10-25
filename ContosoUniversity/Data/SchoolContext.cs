using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
	public class SchoolContext:DbContext
	{
		public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
		{
		}

		public DbSet<Course> Courses => Set<Course>();
		public DbSet<Enrollment> Enrollments => Set<Enrollment>();
		public DbSet<Student> Students => Set<Student>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Course>().ToTable("Course");
			modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
			modelBuilder.Entity<Student>().ToTable("Student");
		}
	}
}
