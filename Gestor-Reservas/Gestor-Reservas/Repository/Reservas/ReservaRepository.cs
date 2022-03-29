using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository.Reservas
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly d8ea1777vdeq8kContext context;

        public ReservaRepository(d8ea1777vdeq8kContext context)
        {
            this.context = context;
        }
        public async Task<List<ReservaDTO>> GetReservasAsync()
        {
            var reservas = await context.Reservas.Where(x => x.Activo == true && x.Ingreso >= DateTime.Now).OrderBy(x => x.IdReserva).ToListAsync();
            var unidadDB = await context.Unidades.ToListAsync();
            var origenDB = await context.OrigenReservas.ToListAsync();

            var listaReservasDTO = new List<ReservaDTO>();

            if (reservas.Count == 0)
            {
                throw new Exception("No hay reservas");
            }
            foreach (var i in reservas)
            {
                var unidad = unidadDB.FirstOrDefault(x => x.IdUnidad == i.IdUnidad);
                var origen = origenDB.FirstOrDefault(x => x.IdOrigen == i.IdOrigen);

                var reservaDto = new ReservaDTO
                {
                    MontoTotal = i.MontoTotal,
                    Ingreso = i.Ingreso,
                    Egreso = i.Egreso,
                    Senia = i.Senia,
                    Nombre = i.Nombre,
                    Apellido = i.Apellido,
                    Dni = i.Dni,
                    Localidad = i.Localidad,
                    Edad = i.Edad,
                    Email = i.Email,
                    Telefono = i.Telefono,
                    Unidad = unidad.Nombre,
                    CantidadAcompaniantes = i.CantidadAcompaniantes,
                    Observaciones = i.Observaciones,
                    Origen = origen.Origen,
                    Activo = i.Activo
                };
                listaReservasDTO.Add(reservaDto);
            }
            return listaReservasDTO;
        }
    }
}
