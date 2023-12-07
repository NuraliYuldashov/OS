using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using OSCategory.Data;
using OSCategory.Entities;
using System;

namespace DataAccessLayer.Repositories;

public class Repository<TEntity> :
    IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly AppDBContext _dBContext;

    public Repository(AppDBContext dBContext)
    {
        _dBContext = dBContext;
    }
    public async Task AddAsync(TEntity entity)
    => await _dBContext.Set<TEntity>().AddAsync(entity);

    public async void Delete(int id)
    {
        var entity = await _dBContext.Set<TEntity>().FirstOrDefaultAsync(i =>
                                        i.Id == id);
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
