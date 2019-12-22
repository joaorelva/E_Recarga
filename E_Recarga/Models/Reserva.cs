using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Recarga.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        public int UtilizadorId { get; set; }

        public int Custo { get; set; }

        public Posto Posto { get; set; }

        [Display(Name = "Postos")]
        public byte PostoId { get; set; }

        //public int 
    }
}