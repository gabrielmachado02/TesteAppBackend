using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteApp.Infraecstruture.Interfaces;

namespace TesteApp.Service
{
    public class BaseService<TEntity> :  IServiceBase<TEntity> where TEntity : class
    {
        private IBaseRepository<TEntity> _db;


        public BaseService(IBaseRepository<TEntity> db)
        {
            _db = db;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _db.CreateAsync(entity);
        }

        public async Task Delete(int id)
        {
            await _db.Delete(id);
        }

        public async  Task<IList<TEntity>> GetAll()

        {
            return await _db.GetAll();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await  _db.GetByIdAsync(id);
        }

        public async Task Update(TEntity entity)
        {
            await _db.Update(entity);
        }
    }
}
