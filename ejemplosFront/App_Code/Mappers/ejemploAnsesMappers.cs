using ejemplosFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejemplosFront.App_Code.Mappers
{
    public class ejemploAnsesMappers
    {
        public static PersonaViewModel Persona(ejemploWS.Persona data)
        {
            if (data == null)
            {
                return null;
            }
            return new PersonaViewModel
            {  
                Id = data.Id,
                Cuil = data.Cuil,
                ApellidoYNombre = data.ApellidoYNombre,
                fechaNacimiento = data.fechaNacimiento
            };
        }
    }
}