using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApp.Infraecstruture.Interfaces
{
  public  interface IServiceBase <TEntity> where TEntity : class
    {
        Task <IList<TEntity>> GetAll();

        Task<TEntity> GetByIdAsync(int id);

        Task CreateAsync(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(int id);

    }
}
