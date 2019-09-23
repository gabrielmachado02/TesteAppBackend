using System;
using TesteApp.Infraecstruture.Interfaces;
using TesteApp.Model;

namespace TesteApp.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public ClienteService(IBaseRepository<Cliente> db) : base(db)
        {
        }
    }
}
