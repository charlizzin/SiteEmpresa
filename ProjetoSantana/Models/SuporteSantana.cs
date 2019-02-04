using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Models
{
    public class SuporteSantana
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
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Atendente { get; set; }
        //public string Responsavel { get; set; }
        //public DateTime Prazo { get; set; }
        [Display(Name = "Solução do Problema")]
        public string Solucao { get; set; }
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Status { get; set; }
    }
}