using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blogsapi.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserIdColumnNameInBlogPostsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("UserId", "BlogPosts", "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("user_id", "BlogPosts", "UserId");
        }
    }
}
