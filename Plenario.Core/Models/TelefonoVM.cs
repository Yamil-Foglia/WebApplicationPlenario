using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plenario.Core.Models
{
    public class TelefonoVM
    {
        public int TelefonoId { get; set; }
        public int PersonaId { get; set; }
        public int NumeroDeTelefono { get; set; }

        public static TelefonoVM AgregarTelefono(int personaId, int numeroDeTelefono)
        {
            var telefono = new TelefonoVM();

            telefono.PersonaId = personaId;
            telefono.NumeroDeTelefono = numeroDeTelefono;

            return telefono;
        }
    }
}