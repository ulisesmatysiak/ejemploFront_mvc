using ejemplosFront.App_Code.Mappers;
using ejemplosFront.ejemploWS;
using ejemplosFront.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ejemplosFront.App_Code
{
    public class invocaejemplosAnses
    {
        public static PersonaViewModel obtenerPersona(int cuil)
        {
            var service = obtenerWS();
            var persona = service.obtenerPersona(cuil);
            return ejemploAnsesMappers.Persona(persona?.FirstOrDefault(x => x.Cuil == cuil));
        }

        public static List<PersonaViewModel> BuscarPorNombre(string nombre)
        {
            var service = obtenerWS();
            var persona = service.BuscarPorNombre(nombre);
            return persona.Select(x => ejemploAnsesMappers.Persona(x)).ToList();
        }

        private static ejemploWS.WebService1 obtenerWS()
        {
            return new ejemploWS.WebService1 {
                Url = ConfigurationManager.AppSettings["urlEjemploWS"],
                Credentials = System.Net.CredentialCache.DefaultCredentials
            };
        }
    }
}