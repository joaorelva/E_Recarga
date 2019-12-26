using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Recarga.Models;
using E_Recarga.ViewModels;

namespace E_Recarga.Controllers
{
    public class ReservasController : Controller
    {
        private ApplicationDbContext _context;

        public ReservasController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

         public ActionResult New()
         {
             var postos = _context.Postoes.ToList();
             var viewModel = new NewReservaViewModel
             {
                 Postos = postos
             };

            return View(viewModel);
        }

         [HttpPost]
         public ActionResult Save(Reserva reserva)
         {
             var postos = _context.Postoes.ToList();
             var viewModel = new NewReservaViewModel
             {
                 Postos = postos
             };

             if (reserva.Id == 0)
                 _context.Reservas.Add(reserva);
             else
             {
                 var reservaInDb = _context.Reservas.Single(c => c.Id == reserva.Id);
                 reservaInDb.PostoId = reserva.PostoId;
                 //nao faz nada
                 foreach (var p in viewModel.Postos)
                 {
                     if (p.Id == reservaInDb.PostoId)
                        reservaInDb.Custo = p.Price;
                 }


             }

             _context.SaveChanges();
             return RedirectToAction("Index","Home");
         }
    }
}