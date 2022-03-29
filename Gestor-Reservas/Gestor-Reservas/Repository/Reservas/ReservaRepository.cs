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

        public async Task<Reserva> Create(ReservaInsert reservaInsert)
        {
            var reserva = new Reserva
            {
                MontoTotal = reservaInsert.MontoTotal,
                Ingreso = reservaInsert.Ingreso,
                Egreso = reservaInsert.Egreso,
                Senia = reservaInsert.Senia,
                Nombre = reservaInsert.Nombre,
                Apellido = reservaInsert.Apellido,
                Dni = reservaInsert.Dni,
                Localidad = reservaInsert.Localidad,
                Edad = reservaInsert.Edad,
                Email = reservaInsert.Email,
                Telefono = reservaInsert.Telefono,
                IdUnidad = reservaInsert.IdUnidad,
                CantidadAcompaniantes = reservaInsert.CantidadAcompaniantes,
                Observaciones = reservaInsert.Observaciones,
                IdOrigen = reservaInsert.IdOrigen,
                Activo = true
            };

            if (reserva != null)
            {
                context.Reservas.Add(reserva);
                await context.SaveChangesAsync();
                return reserva;
            }
            else
            {
                throw new Exception("No se pudo insertar la reserva");
            }
        }

        public async Task<List<ReservaDTO>> GetReservasAsync()
        {
            var reservas = await context.Reservas.Where(x => x.Activo == true && x.Ingreso >= DateTime.Today).OrderBy(x => x.IdReserva).ToListAsync();
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

        public async Task<Reserva> Update(ReservaUpdate reservaUpdate)
        {
            var reserva = await context.Reservas.FirstOrDefaultAsync(x => x.IdReserva == reservaUpdate.IdReserva);

            if (reserva != null)
            {
                reserva.IdReserva = reservaUpdate.IdReserva;
                reserva.MontoTotal = reservaUpdate.MontoTotal;
                reserva.Ingreso = reservaUpdate.Ingreso;
                reserva.Egreso = reservaUpdate.Egreso;
                reserva.Senia = reservaUpdate.Senia;
                reserva.Nombre = reservaUpdate.Nombre;
                reserva.Apellido = reservaUpdate.Apellido;
                reserva.Dni = reservaUpdate.Dni;
                reserva.Localidad = reservaUpdate.Localidad;
                reserva.Edad = reservaUpdate.Edad;
                reserva.Email = reservaUpdate.Email;
                reserva.Telefono = reservaUpdate.Telefono;
                reserva.IdUnidad = reservaUpdate.IdUnidad;
                reserva.CantidadAcompaniantes = reservaUpdate.CantidadAcompaniantes;
                reserva.Observaciones = reservaUpdate.Observaciones;
                reserva.IdOrigen = reservaUpdate.IdOrigen;
                reserva.Activo = true;
                
                context.Reservas.Update(reserva);
                await context.SaveChangesAsync();
                return reserva;
            }
            else
            {
                throw new Exception("No se encontro la reserva");
            }
        }
    }
}
