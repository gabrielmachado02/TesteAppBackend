using System;
using System.Collections.Generic;
using System.Text;
using TesteApp.Infraecstruture.Context;
using TesteApp.Infraecstruture.Interfaces;
using TesteApp.Model;

namespace TesteApp.Infraecstruture.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteDbContext db) : base(db)
        {
        }
    }
}
