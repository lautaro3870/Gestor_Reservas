using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using Gestor_Reservas.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestor_Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("Prog3")]
    public class UnidadesController : ControllerBase
    {
        private readonly IUnidadesRepository unidadesRepository;
        public UnidadesController(IUnidadesRepository unidadesRepository)
        {
            this.unidadesRepository = unidadesRepository;
        }

        [HttpGet]
        public async Task<List<Unidade>> Get()
        {
            return await unidadesRepository.GetUnidades();
        }

        // GET api/<UnidadesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UnidadesController>
        [HttpPost]
        public async Task<Unidade> Post([FromBody] UnidadesDTO unidad)
        {
            return await unidadesRepository.Create(unidad);
        }

        // PUT api/<UnidadesController>/5
        [HttpPut()]
        public async Task<Unidade> Put ([FromBody] UnidadesDTO unidad)
        {
            return await unidadesRepository.Update(unidad);
        }

        // DELETE api/<UnidadesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
