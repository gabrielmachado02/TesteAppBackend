using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteApp.Infraecstruture.EntityConfig;
using TesteApp.Model;

namespace TesteApp.Infraecstruture.Context
{
    public class ClienteDbContext : DbContext
    {

        public ClienteDbContext(DbContextOptions<ClienteDbContext> options)
           : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClienteConfig());
            base.OnModelCreating(builder);
        }
    }
}
