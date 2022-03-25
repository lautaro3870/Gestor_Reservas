using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository
{
    public class UnidadesRepository : IUnidadesRepository
    {
        private readonly d8ea1777vdeq8kContext context;

        public UnidadesRepository(d8ea1777vdeq8kContext context)
        {
            this.context = context;
        }

        public async Task<Unidade> Create(UnidadesDTO unidad)
        {
            Unidade u = new Unidade
            {
                Nombre = unidad.Nombre,
                Capacidad = unidad.Capacidad,
                Activo = true
            };

            if (u != null)
            {
                context.Unidades.Add(u);
                var valor = await context.SaveChangesAsync();
                if (valor == 0)
                {
                    throw new Exception("No se pudo insertar el proyecto");
                }
                return u;
            }
            return null;
        }

        public async Task<List<Unidade>> GetUnidades()
        {
            return await context.Unidades.Where(x => x.Activo == true).ToListAsync();
        }

        public async Task<Unidade> Update(UnidadesDTO unidad)
        {
            
            var u = await context.Unidades.FirstOrDefaultAsync(x => x.IdUnidad == unidad.Id_Unidad);
            if (u != null)
            {
                u.Nombre = unidad.Nombre;
                u.Capacidad = unidad.Capacidad;
                context.Unidades.Update(u);
                await context.SaveChangesAsync();
                return u;
            }
            return null;
        }
    }
}
