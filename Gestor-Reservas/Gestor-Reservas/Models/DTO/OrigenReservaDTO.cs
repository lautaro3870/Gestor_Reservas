using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Models.DTO
{
    public class OrigenReservaDTO
    {
        public int IdOrigen { get; set; }
        public string Origen { get; set; }
        public bool Activo { get; set; }
    }
}
