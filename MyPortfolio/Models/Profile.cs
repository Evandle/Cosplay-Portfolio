using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models;

/// <summary>
/// The owner of the portfolio. The site only ever has one of these.
/// Used by Home.razor (name, tagline, avatar) and About.razor (banner, bio).
/// </summary>
public class Profile
{
    // Primary key. EF Core treats a property named Id as the key automatically.
    public int Id { get; set; }

    // [Required] = NOT NULL, [StringLength] = max length (varchar(100) in the diagram).
    [Required, StringLength(100)]
    public string DisplayName { get; set; } = string.Empty;

    // "string?" means the value is allowed to be empty (null).
    [StringLength(150)]
    public string? Tagline { get; set; }

    public string? Bio { get; set; }

    [Required, StringLength(255)]
    public string AvatarPath { get; set; } = string.Empty;

    [StringLength(255)]
    public string? BannerPath { get; set; }

    // Navigation properties: the "one Profile has many ..." side of the relationships.
    public List<SocialLink> SocialLinks { get; set; } = new();
    public List<Photo> Photos { get; set; } = new();
    public List<Message> Messages { get; set; } = new();
    public List<Rating> Ratings { get; set; } = new();
}
