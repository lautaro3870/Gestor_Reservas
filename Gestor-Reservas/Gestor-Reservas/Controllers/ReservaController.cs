using AutoMapper;
using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using Gestor_Reservas.Repository.Reservas;
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
    public class ReservaController : ControllerBase
    {
        private readonly IReservaRepository reservaRepository;
        private readonly IMapper mapper;

        public ReservaController(IReservaRepository reservaRepository, IMapper mapper)
        {
            this.reservaRepository = reservaRepository;
            this.mapper = mapper;
        }

        // GET: api/<ReservaController>
        [HttpGet]
        public async Task<ActionResult<List<ReservaDTO>>> GetReservas()
        {
            var reservas = await reservaRepository.GetReservasAsync();
            return Ok(reservas);
        }

        // GET api/<ReservaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReservaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
