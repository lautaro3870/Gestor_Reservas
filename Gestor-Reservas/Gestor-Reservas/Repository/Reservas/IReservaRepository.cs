using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using Gestor_Reservas.Repository.QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository.Reservas
{
    public interface IReservaRepository
    {
        Task<ReservaDTOId> GetReservaId(int id);
        Task<List<ReservaDTO>> GetReservasAsync(ReservasQueryFilters filters);
        Task<Reserva> Create(ReservaInsert reservaInsert);
        Task<Reserva> Update(ReservaUpdate reservaUpdate);
        Task<bool> DeleteAsync(int id);
    }
}
