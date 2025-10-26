using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_HW.Models
{
	[Table("Groups")]
	public class Group
	{
		[Key, Column("group_id")]
		public int GroupId { get; set; }

		[Required, Column("group_name"), StringLength(10)]
		public string GroupName { get; set; } = string.Empty;

		[Column("direction")]
		public byte Direction { get; set; }

		// навигация
		[ForeignKey("Direction")]
		public Direction? DirectionNavigation { get; set; }

		public ICollection<Student>? Students { get; set; }
	}
}
