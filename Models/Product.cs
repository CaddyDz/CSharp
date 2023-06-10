using System;
using System.ComponentModel.DataAnnotations;

namespace Databases.Models
{
	/// <summary>
	/// Product entity
	/// </summary>

	public class Product
	{
		[Key]
		public int id { get; set; }
		[Required]
		[MaxLength(128)]
		public string title { get; set; }
		[Required]
		[MaxLength(256)]
		public string sub_title { get; set; }
		[Required]
		public DateTime created_at { get; set; }
	}
}
