using System.ComponentModel.DataAnnotations;

namespace OSCategory.Entities;

public class OperationSystemModel : BaseEntity
{
    [Required]
    public double Price { get; set; }
    [Required]
    public double RequiredSpace { get; set; }
    [Required]
    public int OSCategoryId { get; set; }
    public OSCategories? OSCategorys { get; set; }
}
