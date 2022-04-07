using System;
using System.Collections.Generic;

#nullable disable

namespace Gestor_Reservas.Models
{
    public partial class Reserva
    {
        public int IdReserva { get; set; }
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
        public int IdUnidad { get; set; }
        public int CantidadAcompaniantes { get; set; }
        public string Observaciones { get; set; }
        public int IdOrigen { get; set; }
        public bool Activo { get; set; }
        public int? Noches { get; set; }
        public int? Saldo { get; set; }
        public bool? Cochera { get; set; }

        public virtual OrigenReserva IdOrigenNavigation { get; set; }
        public virtual Unidade IdUnidadNavigation { get; set; }
    }
}
