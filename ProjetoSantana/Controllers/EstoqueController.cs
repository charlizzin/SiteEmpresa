using ProjetoSantana.Models.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoSantana.Controllers
{
    public class EstoqueController : Controller
    {
        private IUEstoque GetIUEstoque = new IUEstoque();
        // GET: Estoque
        public ActionResult Index()
        {
            return View(GetIUEstoque.GetEstoques().ToList().OrderBy(x => x.CODIGO));
        }
    }
}