using System;
using System.Collections.Generic;

#nullable disable

namespace Gestor_Reservas.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }
    }
}
