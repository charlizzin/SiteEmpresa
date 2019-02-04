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
    public class SuporteAtsController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: SuporteAts
        public ActionResult Index()
        {
            return View(db.SuporteAts.ToList());
        }
        // GET: SuporteAts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuporteAts suporteAts = db.SuporteAts.Find(id);
            if (suporteAts == null)
            {
                return HttpNotFound();
            }
            return View(suporteAts);
        }
        // GET: SuporteAts/Create
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

        // POST: SuporteAts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,DataInicio,DescProblema,Empresa,Solicitante,Atendente,CodAtendimento,CodChamado,Solucao,Status")] SuporteAts suporteAts)
        {
            ViewBag.Empresa = new SelectList(new Empresa().ListaEmpresas(), "CodEmpresa", "nomeEmpresa");
            ViewBag.Solicitantes = new SelectList(new Solicitantes().ListaSolicitantes(), "CodSolicitante", "NomeSolicitante");
            ViewBag.Status = new SelectList(new Status().ListaStatus(), "CodStatus", "NomeStatus");
            if (ModelState.IsValid)
            {
                db.SuporteAts.Add(suporteAts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(suporteAts);
        }

        // GET: SuporteAts/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.Status = new SelectList(new Status().ListaStatus(), "CodStatus", "NomeStatus");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuporteAts suporteAts = db.SuporteAts.Find(id);
            if (suporteAts == null)
            {
                return HttpNotFound();
            }

            return View(suporteAts);
        }

        // POST: SuporteAts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,DataInicio,DescProblema,Empresa,Solicitante,Atendente,CodAtendimento,CodChamado,Solucao,Status")] SuporteAts suporteAts)
        {
            ViewBag.Status = new SelectList(new Status().ListaStatus(), "CodStatus", "NomeStatus");
            if (ModelState.IsValid)
            {
                db.Entry(suporteAts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(suporteAts);
        }
        // GET: SuporteAts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuporteAts suporteAts = db.SuporteAts.Find(id);
            if (suporteAts == null)
            {
                return HttpNotFound();
            }
            return View(suporteAts);
        }

        // POST: SuporteAts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuporteAts suporteAts = db.SuporteAts.Find(id);
            db.SuporteAts.Remove(suporteAts);
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
