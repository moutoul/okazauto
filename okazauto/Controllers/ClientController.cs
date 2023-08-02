using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Okazauto.Entities;
using Okazauto.Models;
using Okazauto.Repositories;

namespace okazauto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IRepository<ClientPOCO, int> _clientRepository;

        public ClientController(IRepository<ClientPOCO, int> clientRepository)
        {
            _clientRepository = clientRepository;
        }
        [HttpPost]
        public IActionResult CreateClient([FromBody] ClientDTO client)
        {
            try
            {
                ClientPOCO NouvClient = new ClientPOCO();
                NouvClient.Prenom = client.Prenom;
                NouvClient.Nom = client.Nom;
                NouvClient.Email = client.Email;
                NouvClient.Adresse = client.Adresse;
                NouvClient.Telephone = client.Telephone;

                int id = _clientRepository.Add(NouvClient);
                return Ok($"Creation client d'un nouveau client  Id: {id}");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error creating client: {ex.Message}");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            try
            {
                _clientRepository.Delete(id);
                return Ok("supression de ce fdp");
            }
            catch (Exception ex)
            {
                return BadRequest("pas possible de supprimer cet id");
            }
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                IEnumerable<ClientPOCO> clients = _clientRepository.GetAll();
                return Ok(clients);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }


    }

}

        

     
