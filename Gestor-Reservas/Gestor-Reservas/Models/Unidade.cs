using System;
using System.Collections.Generic;

#nullable disable

namespace Gestor_Reservas.Models
{
    public partial class Unidade
    {
        public Unidade()
        {
            Bloqueos = new HashSet<Bloqueo>();
            Reservas = new HashSet<Reserva>();
        }

        public int IdUnidad { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Bloqueo> Bloqueos { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
