using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Models
{
    public class Status
    {
        public string CodStatus { get; set; }
        public string NomeStatus { get; set; }
        public List<Status> ListaStatus()
        {
            List<Status> status = new List<Status>
            {
                new Status
                {
                    CodStatus = "Aberto",
                    NomeStatus = "Aberto"
                },
                new Status
                {
                    CodStatus = "Fechado",
                    NomeStatus= "Fechado"
                }
            };
            return status;
        }
    }
}