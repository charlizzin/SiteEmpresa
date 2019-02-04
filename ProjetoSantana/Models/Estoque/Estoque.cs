using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Models.Estoque
{
    public class Estoque
    {
        public int CODIGO { get; set; }
        public string DESCRICAO { get; set; }
        public string UN { get; set; }
        public string MATRIZ { get; set; }
        public string VILAISA { get; set; }
        public string CIMENTO { get; set; }
        public string CEDIS { get; set; }
        public string DIFERENCA { get; set; }
    }
}