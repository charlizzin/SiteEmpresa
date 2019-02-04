using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Models
{
    public class EnderecoIP
    {
        [Key]
        public int Codigo { get; set; }
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Ip { get; set; }
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Setor { get; set; }
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Empresa { get; set; }
        [StringLength(maximumLength: 20, ErrorMessage = "Tamanho maximo 20")]
        public string Usuario { get; set; }
        public string Observacao { get; set; }
    }
}