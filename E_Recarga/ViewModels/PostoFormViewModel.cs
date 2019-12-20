using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using E_Recarga.Models;

namespace E_Recarga.ViewModels
{
    public class PostoFormViewModel
    {
        public IEnumerable<Estacao> Estacaos { get; set; }
        public Posto Posto { get; set; }
    }
}