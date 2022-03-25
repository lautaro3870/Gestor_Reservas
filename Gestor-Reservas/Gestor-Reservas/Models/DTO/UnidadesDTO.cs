using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Models.DTO
{
    public class UnidadesDTO
    {
        public int Id_Unidad { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Activo { get; set; }
    }
}
