using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ProjetoSantana.Migrations;
using ProjetoSantana.Models;

namespace ProjetoSantana.Infraestrutura
{
    public class DbContexto : DbContext
    {
        public DbContexto() : base("strConn")
        {

        }
        public DbSet<SuporteAts> SuporteAts { get; set; }
        public DbSet<SuporteSantana> SuporteSantanas { get; set; }
        public DbSet<EnderecoIP> EnderecoIPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Configurations.Add(new SuporteAtsMap());
            //modelBuilder.Configurations.Add(new SuporteSantanaMap());
            //modelBuilder.Configurations.Add(new EnderecoIPMap());

            base.OnModelCreating(modelBuilder);
        }

        public class ContextoInicializar : IDatabaseInitializer<DbContexto>
        {
            //Método responsavel por inicializar o banco de dados, recebe como parametro um objeto contexto.
            public void InitializeDatabase(DbContexto context)
            {
                //Verifica se o banco de dados já existe
                if (context.Database.Exists())
                {
                    //Verifica se o banco de dados é compativel com o modelo.
                    if (!context.Database.CompatibleWithModel(false))
                    {
                        //Atualiza o banco de dados.
                        var dbMigrator = new DbMigrator(new Configuration());
                        dbMigrator.Update();
                    }
                }
                //Se não existir
                else
                {
                    //Cria o Banco de dados com base no contexto.
                    //context.Database.Create();
                    //            Database.SetInitializer<DbContext>(new MigrateDatabaseToLatestVersion<DbContext,  Configuration>());
                    var initializer = new MigrateDatabaseToLatestVersion<DbContexto, ProjetoSantana.Migrations.Configuration>();
                    Database.SetInitializer(initializer);
                    try
                    {
                        context.Database.Initialize(true);
                    }
                    catch (Exception)
                    {
                        //Handle Error in some way
                    }
                }
                Seed(context);
            }

            protected void Seed(DbContexto db)
            {
                // Inserções de dados iniciais
            }
        }
    }
}