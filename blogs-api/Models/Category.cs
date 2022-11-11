using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogs_api.Models
{
	public class Category
	{
		[Column("id")]
		[Key]
		public int Id { get; set; }
		[Column("name")]
		public string Name { get; set; }

		[ForeignKey("CategoryId")]
		public ICollection<PostCategory> PostCategories { get; set; }
	}
}

