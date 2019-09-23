using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteApp.Infraecstruture.Context;
using TesteApp.Infraecstruture.Interfaces;

namespace TesteApp.Infraecstruture.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
               
        private ClienteDbContext _db;

        public BaseRepository(ClienteDbContext db)
        {
            _db = db;
        }
        public async Task CreateAsync(TEntity entity)
        {
            await _db.Set<TEntity>().AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetByIdAsync(id);
            _db.Set<TEntity>().Remove(entity);
            await _db.SaveChangesAsync();
        }

       
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _db.Set<TEntity>()
                  .FindAsync(id);
        }
     
        public async Task Update(TEntity entity)
        {
          
            _db.Set<TEntity>().Update(entity);
            await _db.SaveChangesAsync();
        }



       public async Task<IList<TEntity>> GetAll()
        {
         return  await  _db.Set<TEntity>().ToListAsync();
        }
    }
    }

