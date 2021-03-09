using Plenario.Core.Models;
using Plenario.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenario.Core
{
    public static class Mapper
    {
        public static Persona MapPersona(PersonaVM personsaVM)
        {
            Persona persona = new Persona();

            persona.PersonaID = personsaVM.PersonaId;
            persona.Nombre = personsaVM.NombreCompleto;
            persona.FechaNacimiento = personsaVM.FechaDeNacimiento;
            persona.CreditoMaximo = personsaVM.CreditoMaximo;

            return persona;
        }

        public static Telefono MapTelefono(TelefonoVM telefonoVM)
        {
            Telefono telefono = new Telefono();

            telefono.TelefonoID = telefonoVM.TelefonoId;
            telefono.PersonaID = telefonoVM.PersonaId;
            telefono.Telefono1 = telefonoVM.NumeroDeTelefono.ToString();

            return telefono;
        }
    }
}
