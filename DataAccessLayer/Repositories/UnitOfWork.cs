using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public IOperationSystemModelRepository OperationSystemModelRepository => throw new NotImplementedException();

    public IOSCategoriesRepository CategoryRepository => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}
