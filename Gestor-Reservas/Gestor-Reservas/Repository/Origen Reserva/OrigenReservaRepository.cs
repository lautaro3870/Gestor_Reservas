using Gestor_Reservas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository.Origen_Reserva
{
    public class OrigenReservaRepository : IOrigenReservaRepository
    {
        private readonly d8ea1777vdeq8kContext context;

        public OrigenReservaRepository(d8ea1777vdeq8kContext context)
        {
            this.context = context;
        }
        public async Task<List<OrigenReserva>> GetOrigenReserva()
        {
            return await context.OrigenReservas.Where(x => x.Activo == true).ToListAsync();
        }
    }
}
