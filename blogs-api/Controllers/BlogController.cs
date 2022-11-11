using blogs_api.Repository;
namespace blogs_api.Controllers
{
	public class BlogController
	{
		private readonly BlogContext _context;
		public BlogController(BlogContext context)
		{
			_context = context;
		}
	}
}

