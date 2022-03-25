using Gestor_Reservas.Models;
using Gestor_Reservas.Models.DTO;
using Gestor_Reservas.Repository.Origen_Reserva;
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
    public class OrigenReservaController : ControllerBase
    {
        private readonly IOrigenReservaRepository origenReserva;

        public OrigenReservaController(IOrigenReservaRepository origenReserva)
        {
            this.origenReserva = origenReserva;
        }

        // GET: api/<OrigenReserva>
        [HttpGet]
        public async Task<List<OrigenReserva>> Get()
        {
            return await origenReserva.GetOrigenReserva();
        }

        // GET api/<OrigenReserva>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrigenReserva>
        [HttpPost]
        public async Task<OrigenReserva> Post(OrigenReservaDTO origen)
        {
            return await origenReserva.Create(origen);
        }

        // PUT api/<OrigenReserva>/5
        [HttpPut]
        public async Task<OrigenReserva> Put(OrigenReservaDTO origen)
        {
            return await origenReserva.Update(origen);
        }

        // DELETE api/<OrigenReserva>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await origenReserva.Delete(id);
        }
    }
}
