using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ProjetoSantana.Models;

namespace ProjetoSantana.Infraestrutura.MapFluentAPI
{
    public class EnderecoIPMap : EntityTypeConfiguration<EnderecoIP>
    {
        public EnderecoIPMap()
        {
            ToTable("EnderecoIP");

            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Ip).HasMaxLength(20);
            Property(x => x.Setor).HasMaxLength(20);
            Property(x => x.Empresa).HasMaxLength(20);
            Property(x => x.Usuario).HasMaxLength(20);
            Property(x => x.Observacao);
        }
    }
}