using DataAccessLayer.Interfaces;
using OSCategory.Data;
using OSCategory.Entities;

namespace DataAccessLayer.Repositories;

public class OSCategoriesRepository(AppDBContext dBContext) :
    Repository<OSCategoriesRepository>, IOperationSystemModelRepository
{
    private readonly AppDBContext _dBContext = dBContext;

    public Task AddAsync(OperationSystemModel entity)
    {
        throw new NotImplementedException();
    }

    public void Update(OperationSystemModel entity)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<OperationSystemModel>> IRepository<OperationSystemModel>.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<OperationSystemModel> IRepository<OperationSystemModel>.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
