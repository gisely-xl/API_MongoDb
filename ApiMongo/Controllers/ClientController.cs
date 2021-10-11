using ApiMongo.Models;
using ApiMongo.Models.InterfacesRepository;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        // GET: api/<ClientController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientRepository.GetClients());
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(_clientRepository.GetClient(id));
        }

        // POST api/<ClientController>
        [HttpPost]
        public IActionResult Post([FromBody] Client newClient)
        {
            _clientRepository.Create(newClient);
            return CreatedAtAction(nameof(Get), new { Id = newClient.Id }, newClient);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] Client upClient)
        {
            upClient.Id = ObjectId.Parse(id);
            _clientRepository.Update(upClient);
            return Ok(upClient);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _clientRepository.Delete(id);
            return NoContent();
        }
    }
}
