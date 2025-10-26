using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_HW.Models
{
	[Table("Teachers")]
	public class Teacher
	{
		[Key, Column("teacher_id")]
		public short TeacherId { get; set; }

		[Required, Column("last_name"), StringLength(50)]
		public string LastName { get; set; } = string.Empty;

		[Required, Column("first_name"), StringLength(50)]
		public string FirstName { get; set; } = string.Empty;

		[Required, Column("middle_name"), StringLength(50)]
		public string MiddleName { get; set; } = string.Empty;

		[Column("birth_date"), Required]
		public DateOnly BirthDate { get; set; }

		[Column("email"), StringLength(50)]
		public string? Email { get; set; }

		[Column("phone"), StringLength(16)]
		public string? Phone { get; set; }

		[Column("photo")]
		public byte[]? Photo { get; set; }

		[Column("work_since"), Required]
		public DateOnly WorkSince { get; set; }

		[Column("rate"), Required]
		public decimal Rate { get; set; } 
	}
}
