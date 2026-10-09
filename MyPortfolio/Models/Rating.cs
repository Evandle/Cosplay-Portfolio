using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models;

/// <summary>
/// A star rating left by a visitor on the "rate me" page.
/// </summary>
public class Rating
{
    public int Id { get; set; }

    public int ProfileId { get; set; }

    // Only 1 to 5 is allowed.
    [Range(1, 5)]
    public int Stars { get; set; }

    public string? Comment { get; set; }

    [StringLength(50)]
    public string? RaterName { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Profile? Profile { get; set; }
}
