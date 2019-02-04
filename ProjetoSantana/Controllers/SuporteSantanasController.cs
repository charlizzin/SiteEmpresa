using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoSantana.Infraestrutura;
using ProjetoSantana.Models;

namespace ProjetoSantana.Controllers
{
    [Authorize]
    public class SuporteSantanasController : Controller
    {
        private DbContexto db = new DbContexto();
        // GET: SuporteSantanas
        public ActionResult Index()
        {
            return View(db.SuporteSantanas.ToList());
        }
        // GET: SuporteSantanas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuporteSantana suporteSantana = db.SuporteSantanas.Find(id);
            if (suporteSantana == null)
            {
                return HttpNotFound();
            }
            return View(suporteSantana);
        }
        // GET: SuporteSantanas/Create
        public ActionResult Create()
        {
            ViewBag.Empresas = new SelectList(
                new Empresa().ListaEmpresas(), "CodEmpresa", "NomeEmpresa");
            ViewBag.Solicitantes = new SelectList(
                new Solicitantes().ListaSolicitantes(), "CodSolicitante", "NomeSolicitante");
            ViewBag.Status = new SelectList(
                new Status().ListaStatus(), "CodStatus", "NomeStatus");
            return View();
        }

        // POST: SuporteSantanas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,DataInicio,DescProblema,Empresa,Solicitante,Atendente,Solucao,Status")] SuporteSantana suporteSantana)
        {
            ViewBag.Empresa = new SelectList(new Empresa().ListaEmpresas(), "CodEmpresa", "nomeEmpresa");
            ViewBag.Solicitantes = new SelectList(new Solicitantes().ListaSolicitantes(), "CodSolicitante", "NomeSolicitante");
            ViewBag.Status = new SelectList(new Status().ListaStatus(), "CodStatus", "NomeStatus");
            if (ModelState.IsValid)
            {
                db.SuporteSantanas.Add(suporteSantana);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(suporteSantana);
        }
        // GET: SuporteSantanas/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.Status = new SelectList(new Status().ListaStatus(), "CodStatus", "NomeStatus");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuporteSantana suporteSantana = db.SuporteSantanas.Find(id);
            if (suporteSantana == null)
            {
                return HttpNotFound();
            }
            return View(suporteSantana);
        }

        // POST: SuporteSantanas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,DataInicio,DescProblema,Empresa,Solicitante,Atendente,Solucao,Status")] SuporteSantana suporteSantana)
        {
            ViewBag.Status = new SelectList(new Status().ListaStatus(), "CodStatus", "NomeStatus");
            if (ModelState.IsValid)
            {
                db.Entry(suporteSantana).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(suporteSantana);
        }
        // GET: SuporteSantanas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuporteSantana suporteSantana = db.SuporteSantanas.Find(id);
            if (suporteSantana == null)
            {
                return HttpNotFound();
            }
            return View(suporteSantana);
        }

        // POST: SuporteSantanas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuporteSantana suporteSantana = db.SuporteSantanas.Find(id);
            db.SuporteSantanas.Remove(suporteSantana);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
