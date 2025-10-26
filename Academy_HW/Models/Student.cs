using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_HW.Models
{
	[Table("Students")]
	public class Student
	{
		[Key]
		[Column("stud_id")]
		public int StudId { get; set; }

		[Required, Column("last_name"), StringLength(50)]
		public string LastName { get; set; } = string.Empty;

		[Required, Column("first_name"),  StringLength(50)]
		public string FirstName { get; set; } = string.Empty;

		[Column("middle_name"), StringLength(50)]
		public string? MiddleName { get; set; }

		[Column("birth_date"), Required]
		public DateOnly BirthDate { get; set; } 

		[Column("email"), StringLength(50)]
		public string? Email { get; set; }

		[Column("phone"), StringLength(16)]
		public string? Phone { get; set; }

		[Column("photo")]
		public byte[]? Photo { get; set; } 

		[Column("group")]
		public int? Group { get; set; }

		// навигация
		[ForeignKey("Group")]
		public Group? GroupNavigation { get; set; }
	}
}
