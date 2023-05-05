using System.Text.Json.Serialization;

namespace Shared;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string? Type { get; set; }

   // public ICollection<Post>? Posts { get; set; }
}