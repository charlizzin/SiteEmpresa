using FirebirdSql.Data.FirebirdClient;
using ProjetoSantana.Models.Estoque;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Infraestrutura
{
    public class DbContextoFireBird:IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        public DbSet<Estoque> GetEstoques { get; set; }

        private String StringConexao = ConfigurationManager.ConnectionStrings["FirebirdConnStr"].ToString();

        public FbConnection AbrirConexao()
        {
            FbConnection con = new FbConnection(StringConexao);
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            return con;
        }

        public FbConnection FecharConexao(FbConnection con)
        {
            if (con.State != System.Data.ConnectionState.Closed)
                con.Close();
            return con;
        }

        public FbCommand CriarComandoSQL(String Query)
        {
            FbConnection Conexao = AbrirConexao();
            FbCommand ComandoSQL = new FbCommand(Query, Conexao);
            return ComandoSQL;
        }
    }
}