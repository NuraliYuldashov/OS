using System.ComponentModel.DataAnnotations;

namespace OSCategory.Entities;

public class OSCategories : BaseEntity
{
    [Required]
    public List<OperationSystemModel> operationSystemModels { get; set; } = new List<OperationSystemModel>();
}
