using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelryBackendSide.DatabaseLayer.BaseRepository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<T> Add(T entity);
    }
}
