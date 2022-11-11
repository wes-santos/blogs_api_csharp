using System.ComponentModel.DataAnnotations.Schema;

namespace blogs_api.Models
{
	public class PostCategory
	{
		[Column("post_id")]
		public int PostId { get; set; }
		[Column("category_id")]
		public int CategoryId { get; set; }

		public BlogPost BlogPost { get; set; }
		public Category Category { get; set; }
	}
}

