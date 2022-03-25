using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository.Origen_Reserva
{
    public interface IOrigenReservaRepository
    {
        Task<List<OrigenReserva>> GetOrigenReserva();
        Task<OrigenReserva> Create(OrigenReservaDTO origenReserva);
        Task<OrigenReserva> Update(OrigenReservaDTO origenReserva);
        Task<bool> Delete(int id);
    }
}
