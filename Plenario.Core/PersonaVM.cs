using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Plenario.Core.;

namespace WebApplicationPlenario.Models
{
    public class PersonaVM
    {
        public int PersonaId { get; set; }
        public string NombreCompleto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int CreditoMaximo { get; set; }


        public static PersonaVM CrearPersona(string nombre, string apellido, DateTime fechaDeNacimiento, int creditoMaximo)
        {
            var persona = new PersonaVM();

            persona.PersonaId = DBFalsaPersona.GenerarPersonaId();
            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.NombreCompleto = nombre + " " + apellido;
            persona.FechaDeNacimiento = fechaDeNacimiento;
            persona.CreditoMaximo = creditoMaximo;

            return persona;
        }

        public static PersonaVM CrearPersona(int personaId, string nombre, string apellido, DateTime fechaDeNacimiento, int creditoMaximo)
        {
            var persona = new PersonaVM();

            persona.PersonaId = personaId;
            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.NombreCompleto = nombre + " " + apellido;
            persona.FechaDeNacimiento = fechaDeNacimiento;
            persona.CreditoMaximo = creditoMaximo;

            return persona;
        }


    }
}