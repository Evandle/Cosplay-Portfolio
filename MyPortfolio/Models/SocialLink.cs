using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models;

/// <summary>
/// One social media button (Facebook, X, GitHub).
/// Used by SocialLinks.razor and LinkButton.razor.
/// </summary>
public class SocialLink
{
    public int Id { get; set; }

    // Foreign key: which Profile this link belongs to.
    public int ProfileId { get; set; }

    [Required, StringLength(50)]
    public string Label { get; set; } = string.Empty;

    [Required, StringLength(255)]
    public string Url { get; set; } = string.Empty;

    [StringLength(255)]
    public string? IconPath { get; set; }

    // Lower numbers are shown first.
    public int SortOrder { get; set; }

    // Navigation property: the Profile this link belongs to.
    public Profile? Profile { get; set; }
}
