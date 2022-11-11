using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogs_api.Models
{
	public class BlogPost
	{
		[Column("id")]
		[Key]
		public int Id { get; set; }
		[Column("title")]
		[Required]
		public string Title { get; set; }
		[Column("email")]
		[Required]
		public string Email { get; set; }
		[Column("content")]
		[Required]
		public string Content { get; set; }

		[Column("user_id")]
		public User? User { get; set; }

		[Column("published", TypeName = "Date")]
		public DateTime Published { get; set; }

		[Timestamp]
		[Column("updated")]
		public byte[] Updated { get; set; }

		[ForeignKey("PostId")]
		public ICollection<PostCategory> PostCategories { get; set; }
	}
}

