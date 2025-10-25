using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
	public class Student
	{
		public int ID { get; set; }

		[Required]
		public string LastName { get; set; } = string.Empty;

		[Required]
		public string FirstMidName { get; set; } = string.Empty;

		public DateTime EnrollmentDate { get; set; }

		public ICollection<Enrollment>? Enrollments { get; set; }
	}
}
