using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Recarga.Models
{
    public class Estacao
    {
        public byte Id { get; set; }

        [Display(Name = "Nome Da Estação")]
        public string Name { get; set; }
    }
}