using System.ComponentModel.DataAnnotations;

namespace OSCategory.Entities;

public class BaseEntity
{
    [Required]
    public int Id { get; set; }
    [Required, MaxLength(128)]
    public string Name { get; set; } = string.Empty;
}
