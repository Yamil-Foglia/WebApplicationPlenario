using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plenario.Core
{
    public static class DBFalsaTelefono
    {

        public static List<Models.TelefonoVM> telefonos = new List<Models.TelefonoVM>();
        public static int telefonoID = 0;
        public static int personaID = 0;

        public static void Add(Models.TelefonoVM telefono)
        {
            telefonos.Add(telefono);
        }

        public static int GenerarTelefonoId()
        {
            return telefonoID++;
        }

        public static void setPersonaId(int id)
        {
            personaID = id;
        }

        public static int getPersonaId()
        {
            return personaID;
        }
    }
}