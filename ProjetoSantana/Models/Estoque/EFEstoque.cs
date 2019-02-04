using FirebirdSql.Data.FirebirdClient;
using ProjetoSantana.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Models.Estoque
{
    public class EFEstoque : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        public List<Estoque> GetEstoques()
        {
            //Aqui instanciamos a classe DBManager p/ acessar seus métodos
            using (var DbConnection = new DbContextoFireBird())
            {
                //instanciamos o FbCommand
                using (FbCommand comando = new FbCommand())
                {
                    comando.Connection = DbConnection.AbrirConexao();
                    comando.CommandText = "SELECT POS.codigo, POS.descricao, POS.un, trunc(POS.matriz,3) as MATRIZ, trunc(POS.vilaisa,3) AS VILAISA, trunc(POS.cimento,3) AS CIMENTO, trunc(POS.cedis,3) AS CEDIS, trunc(POS.geral,3) AS DIFERENCA FROM posicaoestoque POS";

                    using (var dr = comando.ExecuteReader())
                    {
                        //criamos uma lista de UsuarioDTO p/ coletar os dados
                        List<Estoque> ListaEstoque = new List<Estoque>();

                        //lendo e populando a lista com objetos UsuarioDTO
                        while (dr.Read())
                        {
                            ListaEstoque.Add(new Estoque
                            {
                                CODIGO = int.Parse(dr["CODIGO"].ToString()),
                                DESCRICAO = dr["DESCRICAO"].ToString(),
                                UN = dr["UN"].ToString(),
                                MATRIZ = dr["MATRIZ"].ToString(),
                                VILAISA = dr["VILAISA"].ToString(),
                                CIMENTO = dr["CIMENTO"].ToString(),
                                CEDIS = dr["CEDIS"].ToString(),
                                DIFERENCA = dr["DIFERENCA"].ToString(),
                            });
                        }
                        return ListaEstoque;
                    }
                }
            }
        }
    }
}