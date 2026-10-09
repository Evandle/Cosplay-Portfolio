using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models;

/// <summary>
/// One photo on the About page (also shown in the lightbox).
/// </summary>
public class Photo
{
    public int Id { get; set; }

    public int ProfileId { get; set; }

    [Required, StringLength(255)]
    public string ImagePath { get; set; } = string.Empty;

    // Describes the photo for screen readers.
    [Required, StringLength(200)]
    public string AltText { get; set; } = string.Empty;

    public int SortOrder { get; set; }

    public Profile? Profile { get; set; }
}
