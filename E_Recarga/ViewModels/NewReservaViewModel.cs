using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Recarga.Models;

namespace E_Recarga.ViewModels
{
    public class NewReservaViewModel
    {
        public IEnumerable<Posto> Postos { get; set; }
        public Reserva Reserva { get; set; }
    }
}