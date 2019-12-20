using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Recarga.Models
{
    public class Posto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome Do Posto")]
        public string Name { get; set; }

        [Display(Name = "Localização Do Posto")]
        public string Location { get; set; }

        [Display(Name = "Preço da reserva (1 hora)")]
        public float Price { get; set; }

        public Estacao Estacao { get; set; }

        [Display(Name = "Estação")]
        public byte EstacaoId { get; set; }
    }
}