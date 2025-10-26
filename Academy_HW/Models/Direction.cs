using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy_HW.Models
{
	[Table("Directions")]
	public class Direction
	{
		[Key, Column("direction_id")]
		public byte DirectionId { get; set; }

		[Column("direction_name")]
		public string? DirectionName { get; set; }

		public ICollection<Group>? Groups { get; set; }
	}
}
