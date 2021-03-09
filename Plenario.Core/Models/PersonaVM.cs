using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plenario.Core.Models
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

            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.NombreCompleto = nombre + " " + apellido;
            persona.FechaDeNacimiento = fechaDeNacimiento;
            persona.CreditoMaximo = creditoMaximo;

            return persona;
        }
    }
}