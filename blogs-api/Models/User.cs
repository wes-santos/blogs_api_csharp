using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogs_api.Models;

public class User
{
    [Column("id")]
    [Key]
    public int Id { get; set; }
    [Column("display_name")]
    public string? DisplayName { get; set; }
    [Column("email")]
    public string? Email { get; set; }
    [Column("password")]
    public string? Password { get; set; }
    [Column("image")]
    public string? Image { get; set; }
}
