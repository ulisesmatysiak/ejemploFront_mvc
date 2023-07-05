using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejemplosFront.Models
{
    public class PersonaViewModel
    {
        public int Cuil { get; set; }

        public string ApellidoYNombre { get; set; }

        public DateTime fechaNacimiento { get; set; }
    }
}