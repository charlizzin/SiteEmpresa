using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSantana.Models.Estoque
{
    public class IUEstoque : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        public List<Estoque> GetEstoques()
        {
            using (var est = new EFEstoque())
            {
                return est.GetEstoques();
            }
        }
    }
}