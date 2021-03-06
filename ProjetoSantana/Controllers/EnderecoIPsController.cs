﻿using System;
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
    public class EnderecoIPsController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: EnderecoIPs
        public ActionResult Index()
        {
            return View(db.EnderecoIPs.ToList());
        }

        // GET: EnderecoIPs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnderecoIP enderecoIP = db.EnderecoIPs.Find(id);
            if (enderecoIP == null)
            {
                return HttpNotFound();
            }
            return View(enderecoIP);
        }

        // GET: EnderecoIPs/Create
        public ActionResult Create()
        {
            ViewBag.Empresas = new SelectList(
                new Empresa().ListaEmpresas(), "CodEmpresa", "NomeEmpresa");
            return View();
        }

        // POST: EnderecoIPs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,Ip,Setor,Empresa,Usuario,Observacao")] EnderecoIP enderecoIP)
        {
            ViewBag.Empresas = new SelectList(
                new Empresa().ListaEmpresas(), "CodEmpresa", "NomeEmpresa");
            if (ModelState.IsValid)
            {
                db.EnderecoIPs.Add(enderecoIP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enderecoIP);
        }

        // GET: EnderecoIPs/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.Empresas = new SelectList(
                new Empresa().ListaEmpresas(), "CodEmpresa", "NomeEmpresa");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnderecoIP enderecoIP = db.EnderecoIPs.Find(id);
            if (enderecoIP == null)
            {
                return HttpNotFound();
            }
            return View(enderecoIP);
        }

        // POST: EnderecoIPs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,Ip,Setor,Empresa,Usuario,Observacao")] EnderecoIP enderecoIP)
        {
            ViewBag.Empresas = new SelectList(
                new Empresa().ListaEmpresas(), "CodEmpresa", "NomeEmpresa");
            if (ModelState.IsValid)
            {
                db.Entry(enderecoIP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enderecoIP);
        }

        // GET: EnderecoIPs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnderecoIP enderecoIP = db.EnderecoIPs.Find(id);
            if (enderecoIP == null)
            {
                return HttpNotFound();
            }
            return View(enderecoIP);
        }

        // POST: EnderecoIPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EnderecoIP enderecoIP = db.EnderecoIPs.Find(id);
            db.EnderecoIPs.Remove(enderecoIP);
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
