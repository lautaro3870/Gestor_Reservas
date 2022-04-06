using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository.QueryFilters
{
    public class ReservasQueryFilters
    {
        public int? IdReserva { get; set; }
        public int? Unidad { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Salida { get; set; }
    }
}
