using ejemplosFront.ejemploWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejemplosFront.App_Code
{
    public class Utils
    {
        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            return edad;
        }
    }
}