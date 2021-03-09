using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plenario.Core
{
    public static class DBFalsaPersona
    {
        public static List<Models.PersonaVM> personas = new List<Models.PersonaVM>();
        public static int personaID = 0;

        public static void Add(Models.PersonaVM persona)
        {
            personas.Add(persona);
        }

        public static int GenerarPersonaId()
        {
            return personaID++;
        }


    }
}