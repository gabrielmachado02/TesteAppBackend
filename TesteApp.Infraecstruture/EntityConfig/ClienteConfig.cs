using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteApp.Model;

namespace TesteApp.Infraecstruture.EntityConfig
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x=>x.Cpf).HasMaxLength(20);

            builder.Property(x => x.DataNascimento);

            builder.Property(x => x.Email).HasMaxLength(200);

            builder.Property(x => x.Logradouro).HasMaxLength(100);

            builder.Property(x => x.Cep).HasMaxLength(50);

            builder.Property(x => x.Cidade).HasMaxLength(100);

            builder.Property(x => x.Numero).HasMaxLength(30);

     
    }
    }

}
    
