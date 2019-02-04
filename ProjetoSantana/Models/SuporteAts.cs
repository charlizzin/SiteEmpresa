using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoSantana.Models
{
    public class SuporteAts
    {
        [Key]
        public int Codigo { get; set; }
        [Display(Name = "Data")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Descrição do Problema")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string DescProblema { get; set; }
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Empresa { get; set; }
        //public string SetorSolicitante { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Solicitante { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Atendente { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = "Codigo do Atendimento")]
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string CodAtendimento { get; set; }
        [Display(Name = "Codigo Chamado")]
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string CodChamado { get; set; }
        //public string Responsavel { get; set; }
        //public DateTime Prazo { get; set; }
        [Display(Name = "Solução do Problema")]
        public string Solucao { get; set; }
        public string Status { get; set; }
    }

    //public class Empresa
    //{
    //    public string CodEmpresa { get; set; }
    //    public string NomeEmpresa { get; set; }

    //    public List<Empresa> ListaEmpresas()
    //    {
    //        List<Empresa> empresas = new List<Empresa>
    //        {
    //            new Empresa
    //            {
    //                CodEmpresa = "Matriz",
    //                NomeEmpresa = "Matriz"
    //            },
    //            new Empresa
    //            {
    //                CodEmpresa = "Vila Isa",
    //                NomeEmpresa = "Vila Isa"
    //            },
    //            new Empresa
    //            {
    //                CodEmpresa = "Cimento",
    //                NomeEmpresa = "Cimento"
    //            },
    //            new Empresa
    //            {
    //                CodEmpresa = "Cedis",
    //                NomeEmpresa = "Cedis"
    //            },
    //            new Empresa
    //            {
    //                CodEmpresa = "Industria",
    //                NomeEmpresa = "Industria"
    //            },
    //            new Empresa
    //            {
    //                CodEmpresa = "Juiz de Fora",
    //                NomeEmpresa = "Juiz de Fora"
    //            },
    //            new Empresa
    //            {
    //                CodEmpresa = "Uberlandia",
    //                NomeEmpresa = "Uberlandia"
    //            }
    //        };
    //        return empresas;
    //    }
    //}

    //public class Solicitantes
    //{
    //    public int CodSolicitante { get; set; }
    //    public string NomeSolicitante { get; set; }

    //    public List<Solicitantes> ListaSolicitantes()
    //    {
    //        List<Solicitantes> solicitantes = new List<Solicitantes>
    //        {
    //            new Solicitantes
    //            {
    //                CodSolicitante = 00,
    //                NomeSolicitante = "Charles Andrade"
    //            },
    //            new Solicitantes
    //            {
    //                CodSolicitante = 00,
    //                NomeSolicitante = "Claudio Henrique"
    //            }
    //        };
    //        return solicitantes;
    //    }
    //}

    //public class Status
    //{
    //    public string CodStatus { get; set; }
    //    public string NomeStatus { get; set; }
    //    public List<Status> ListaStatus()
    //    {
    //        List<Status> status = new List<Status>
    //        {
    //            new Status
    //            {
    //                CodStatus = "Aberto",
    //                NomeStatus = "Aberto"
    //            },
    //            new Status
    //            {
    //                CodStatus = "Fechado",
    //                NomeStatus= "Fechado"
    //            }
    //        };
    //        return status;
    //    }
    //}

}