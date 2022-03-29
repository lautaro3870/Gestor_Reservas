using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Models.DTO
{
    public class ReservaDTO
    {
        public int MontoTotal { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Egreso { get; set; }
        public int? Senia { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Localidad { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Unidad { get; set; }
        public int CantidadAcompaniantes { get; set; }
        public string Observaciones { get; set; }
        public string Origen { get; set; }
        public bool Activo { get; set; }
    }
}
