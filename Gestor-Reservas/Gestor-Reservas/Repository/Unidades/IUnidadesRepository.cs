using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor_Reservas.Repository
{
    public interface IUnidadesRepository
    {
        Task<List<Unidade>> GetUnidades();
        Task<Unidade> Create(UnidadesDTO unidad);
        Task<Unidade> Update(UnidadesDTO unidad);
        Task<bool> Delete(int id);
    }
}
