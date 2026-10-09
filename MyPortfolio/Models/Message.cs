using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models;

/// <summary>
/// A message left by a visitor on the "tell me anything" page.
/// </summary>
public class Message
{
    public int Id { get; set; }

    public int ProfileId { get; set; }

    // Empty (null) means the visitor stayed anonymous.
    [StringLength(50)]
    public string? SenderName { get; set; }

    [Required]
    public string Content { get; set; } = string.Empty;

    // Filled in automatically when the message object is created.
    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    // A bool is false by default, so new messages start as unread.
    public bool IsRead { get; set; }

    public Profile? Profile { get; set; }
}
