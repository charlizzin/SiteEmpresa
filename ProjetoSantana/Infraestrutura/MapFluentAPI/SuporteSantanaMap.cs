using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using ProjetoSantana.Models;

namespace ProjetoSantana.Infraestrutura.MapFluentAPI
{
    public class SuporteSantanaMap : EntityTypeConfiguration<SuporteSantana>
    {
        public SuporteSantanaMap()
        {
            ToTable("SuporteSantana");

            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.DataInicio);

            Property(x => x.DescProblema);

            Property(x => x.Empresa).HasMaxLength(20);

            //Property(x => x.SetorSolicitante).HasMaxLength(20);

            Property(x => x.Solicitante).HasMaxLength(20);

            Property(x => x.Atendente).HasMaxLength(20);

            //Property(x => x.Responsavel);

            //Property(x => x.Prazo);

            Property(x => x.Solucao);

            Property(x => x.Status).HasMaxLength(20);
        }
    }
}