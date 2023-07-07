using ejemplosFront.ejemploWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejemplosFront.Models
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        public int Cuil { get; set; }

        public string ApellidoYNombre { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public static explicit operator Persona(PersonaViewModel model)
        {
            return new Persona
            {
                Id = model.Id,
                Cuil = model.Cuil,
                ApellidoYNombre = model.ApellidoYNombre,
                fechaNacimiento = model.fechaNacimiento
            };
        }
    }
}