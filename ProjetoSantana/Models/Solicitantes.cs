using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Models
{
    public class Solicitantes
    {
        public string CodSolicitante { get; set; }
        public string NomeSolicitante { get; set; }

        public List<Solicitantes> ListaSolicitantes()
        {
            List<Solicitantes> solicitantes = new List<Solicitantes>
            {
                new Solicitantes
                {
                    CodSolicitante = "Charles Andrade",
                    NomeSolicitante = "Charles Andrade"
                },
                new Solicitantes
                {
                    CodSolicitante = "Claudio Henrique",
                    NomeSolicitante = "Claudio Henrique"
                }
            };
            return solicitantes;
        }
    }
}