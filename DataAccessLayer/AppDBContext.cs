using Microsoft.EntityFrameworkCore;
using OSCategory.Entities;

namespace OSCategory.Data;

public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
{
    public DbSet<OSCategories> OSCategories { get; set; }
    public DbSet<OperationSystemModel> OperatingSystems { get; set; }

}
