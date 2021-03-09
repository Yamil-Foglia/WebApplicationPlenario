using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationPlenario.Core;

namespace WebApplicationPlenario.Models
{
    public class TelefonoVM
    {
        public int TelefonoId { get; set; }
        public int PersonaId { get; set; }
        public int NumeroDeTelefono { get; set; }

        public static TelefonoVM AgregarTelefono(int personaId, int numeroDeTelefono)
        {
            var telefono = new TelefonoVM();

            telefono.TelefonoId = DBFalsaTelefono.GenerarTelefonoId();
            telefono.PersonaId = personaId;
            telefono.NumeroDeTelefono = numeroDeTelefono;

            return telefono;
        }
        public static TelefonoVM AgregarTelefono(int telefonoId ,int personaId, int numeroDeTelefono)
        {
            var telefono = new TelefonoVM();

            telefono.TelefonoId = telefonoId;
            telefono.PersonaId = personaId;
            telefono.NumeroDeTelefono = numeroDeTelefono;

            return telefono;
        }


    }
}