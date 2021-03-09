using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenario.Data.Entities
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int CreditoMaximo { get; set; }

    }
}
