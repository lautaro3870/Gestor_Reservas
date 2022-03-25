using Gestor_Reservas.Models;
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
        private readonly d8ea1777vdeq8kContext context;
        public UnidadesController(d8ea1777vdeq8kContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Unidade> Get()
        {
            return context.Unidades.ToList();
        }

        // GET api/<UnidadesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UnidadesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UnidadesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UnidadesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
