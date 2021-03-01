using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace JwelryBackendSide.DatabaseLayer.BaseRepository
{
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        private readonly TContext dbContext;
        public BaseRepository(TContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> Get(int id)
        {
            return await dbContext.Set<TEntity>().FindAsync(id);
        }
    }
}
