using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_HW.Models
{
	[Table("Disciplines")]
	public class Discipline
	{
		[Key, Column("discipline_id")]
		public short DisciplineId { get; set; }

		[Required, Column("discipline_name"), StringLength(150)]
		public string DisciplineName { get; set; } = string.Empty;

		[Required, Column("number_of_lessons")]
		public byte NumberOfLessons { get; set; }
	}
}
