using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
	public class Course
	{

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int CourseID { get; set; }

		[Required]
		public string Title { get; set; } = string.Empty;

		public int Credits { get; set; }

		public ICollection<Enrollment>? Enrollments { get; set; }
	}
}
