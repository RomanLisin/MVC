using System.Data.Common;
using Academy_HW.Models;
using Microsoft.EntityFrameworkCore;

namespace Academy_HW.Data
{
	public class AcademyContext:DbContext
	{
		public AcademyContext(DbContextOptions<AcademyContext> options) : base(options) 
		{ 
		}

		public DbSet<Student> Students => Set<Student>();
		public DbSet<Teacher> Teachers => Set<Teacher>();
		public DbSet<Discipline> Disciplines => Set<Discipline>();
		public DbSet<Direction> Directionns => Set<Direction>();
		public DbSet<Group> Groups => Set<Group>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// таблицы уже созданы через [Table], но можно явно указать
			modelBuilder.Entity<Student>().ToTable("Students");
			modelBuilder.Entity<Teacher>().ToTable("Teachers");
			modelBuilder.Entity<Discipline>().ToTable("Disciplines");
			modelBuilder.Entity<Direction>().ToTable("Directions");
			modelBuilder.Entity<Group>().ToTable("Groups");

			// настройка отношений
			modelBuilder.Entity<Group>()
				.HasOne(g => g.DirectionNavigation)
				.WithMany(d => d.Groups)
				.HasForeignKey(g => g.Direction);

			modelBuilder.Entity<Student>()
				.HasOne(s => s.GroupNavigation)
				.WithMany(g => g.Students)
				.HasForeignKey(s => s.Group);
		}
	}
}
