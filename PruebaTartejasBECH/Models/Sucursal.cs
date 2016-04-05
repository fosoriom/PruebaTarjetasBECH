using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PruebaTartejasBECH.Models
{
    public class Sucursal
    {
       public string codigo_sucursal { get; set; }

        [Required]
        [Display(Name ="Nombre")]
       public string nombre_sucursal { get; set; }

        [Required]
        [Display(Name ="Región")]
        public string region_sucursal { get; set; }

        [Required]
        [Display(Name ="ServiEstado")]
        public string serviEstado_sucurcal { get; set; }

        [Required]
        [Display(Name ="Zona")]
        public string zona_sucursal { get; set; }

        
    }
}