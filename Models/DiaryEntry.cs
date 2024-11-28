using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models;

public class DiaryEntry
{
    // [Key] -> EF Core knows by default that if you have a prop named Id that it is the Key  (PK). You use the Key data annotation if the name of the Id would be different, ex: DiaryEntryId
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public string Content { get; set; } = string.Empty;

    [Required]
    public DateTime Created { get; set; } = DateTime.Now;
}