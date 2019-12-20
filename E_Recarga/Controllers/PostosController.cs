using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Recarga.Models;
using System.Data.Entity;
using System.Net;
using System.Web.Security;
using E_Recarga.ViewModels;



namespace E_Recarga.Controllers
{
    public class PostosController : Controller
    {
        private ApplicationDbContext _context;

        public PostosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var postos = _context.Postoes.Include(c => c.Estacao).ToList();
            if(User.IsInRole("Admin"))
                return View(postos);
            
            return View("Index-Users", postos);
        }

        public ActionResult Details(int id)
        {
            var posto = _context.Postoes.SingleOrDefault(c => c.Id == id);

            if (posto == null)
                return HttpNotFound();

            var viewModel = new PostoFormViewModel
            {
                Posto = posto,
                Estacaos = _context.Estacaos.ToList()
            };

            return View(viewModel);
        }


        public ViewResult New ()
        {
            var estacoes = _context.Estacaos.ToList();
            var viewModel = new PostoFormViewModel
            {
                Estacaos = estacoes
            };

            return View("PostoForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Posto posto)
        {
            if (posto.Id == 0)
                _context.Postoes.Add(posto);
            else
            {
                var postoInDb = _context.Postoes.Single(c => c.Id == posto.Id);
                postoInDb.Name = posto.Name;
                postoInDb.Price = posto.Price;
                postoInDb.Location = posto.Location;
                postoInDb.EstacaoId = posto.EstacaoId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index","Postos");
        }

        public ActionResult Edit(int id)
        {
            var posto = _context.Postoes.SingleOrDefault(c => c.Id == id);

            if (posto == null)
                return HttpNotFound();

            var viewModel = new PostoFormViewModel
            {
                Posto = posto,
                Estacaos = _context.Estacaos.ToList()
            };
            return View("PostoForm", viewModel);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Posto postos = _context.Postoes.Find(id);

            var viewModel = new PostoFormViewModel
            {
                Posto = postos,
                Estacaos = _context.Estacaos.ToList()
            };

            if (postos == null)
                return HttpNotFound();

            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Posto postos = _context.Postoes.Find(id);
            _context.Postoes.Remove(postos);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}