using System;
using System.Collections.Generic;

#nullable disable

namespace Gestor_Reservas.Models
{
    public partial class Bloqueo
    {
        public int IdBloqueo { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Egreso { get; set; }
        public string Observaciones { get; set; }
        public int IdUnidad { get; set; }
        public bool Activo { get; set; }

        public virtual Unidade IdUnidadNavigation { get; set; }
    }
}
