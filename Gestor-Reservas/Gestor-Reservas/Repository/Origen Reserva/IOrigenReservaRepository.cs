using Gestor_Reservas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository.Origen_Reserva
{
    public interface IOrigenReservaRepository
    {
        Task<List<OrigenReserva>> GetOrigenReserva();
    }
}
