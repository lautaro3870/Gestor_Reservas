using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
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

        public async Task<OrigenReserva> Create(OrigenReservaDTO origenReserva)
        {
            OrigenReserva o = new OrigenReserva
            {
                Origen = origenReserva.Origen,
                Activo = true
            };

            if (o != null)
            {
                context.OrigenReservas.Add(o);
                await context.SaveChangesAsync();
                return o;
            }
            else
            {
                throw new Exception("No se pudo insertar");
            }
        }

        public async Task<bool> Delete(int id)
        {
            var o = await context.OrigenReservas.FindAsync(id);
            if (o != null)
            {
                o.Activo = false;
                
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                throw new Exception("Origen no encontrado");
            }
        }

        public async Task<List<OrigenReserva>> GetOrigenReserva()
        {
            return await context.OrigenReservas.Where(x => x.Activo == true).ToListAsync();
        }

        public async Task<OrigenReserva> Update(OrigenReservaDTO origenReserva)
        {
            var o = await context.OrigenReservas.FirstOrDefaultAsync(x => x.IdOrigen == origenReserva.IdOrigen);
            if (o == null)
            {
                throw new Exception("Origen no encontrado");
            }
            else
            {
                o.Origen = origenReserva.Origen;
                context.OrigenReservas.Update(o);
                await context.SaveChangesAsync();
                return o;
            }
        }
    }
}
