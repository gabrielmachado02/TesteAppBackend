using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteApp.Infraecstruture.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<ClienteDbContext>
    {



        ClienteDbContext IDesignTimeDbContextFactory<ClienteDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ClienteDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);


            return new ClienteDbContext(builder.Options);
        }

    }
}
