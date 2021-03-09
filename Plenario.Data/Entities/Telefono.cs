using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenario.Data.Entities
{
    public class Telefono
    {
        public int TelefonoId { get; set; }
        public int PersonaId { get; set; }
        public int NumeroDeTelefono { get; set; }
    }
}
