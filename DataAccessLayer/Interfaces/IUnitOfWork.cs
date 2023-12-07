namespace DataAccessLayer.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IOperationSystemModelRepository OperationSystemModelRepository { get; }
    IOSCategoriesRepository CategoryRepository { get; }
    Task SaveAsync();
}
