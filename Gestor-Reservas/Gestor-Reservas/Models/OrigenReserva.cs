using System;
using System.Collections.Generic;

#nullable disable

namespace Gestor_Reservas.Models
{
    public partial class OrigenReserva
    {
        public OrigenReserva()
        {
            Reservas = new HashSet<Reserva>();
        }

        public int IdOrigen { get; set; }
        public string Origen { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
