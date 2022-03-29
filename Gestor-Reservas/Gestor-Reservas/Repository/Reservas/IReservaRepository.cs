using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository.Reservas
{
    public interface IReservaRepository
    {
        Task<List<ReservaDTO>> GetReservasAsync();
    }
}
