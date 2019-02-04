using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Models
{
    public class Empresa
    {
        public string CodEmpresa { get; set; }
        public string NomeEmpresa { get; set; }

        public List<Empresa> ListaEmpresas()
        {
            List<Empresa> empresas = new List<Empresa>
            {
                new Empresa
                {
                    CodEmpresa = "Matriz",
                    NomeEmpresa = "Matriz"
                },
                new Empresa
                {
                    CodEmpresa = "Vila Isa",
                    NomeEmpresa = "Vila Isa"
                },
                new Empresa
                {
                    CodEmpresa = "Cimento",
                    NomeEmpresa = "Cimento"
                },
                new Empresa
                {
                    CodEmpresa = "Cedis",
                    NomeEmpresa = "Cedis"
                },
                new Empresa
                {
                    CodEmpresa = "Industria",
                    NomeEmpresa = "Industria"
                },
                new Empresa
                {
                    CodEmpresa = "Juiz de Fora",
                    NomeEmpresa = "Juiz de Fora"
                },
                new Empresa
                {
                    CodEmpresa = "Uberlandia",
                    NomeEmpresa = "Uberlandia"
                }

            };
            return empresas;
        
        }
    }
}