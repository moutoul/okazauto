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
                return Ok($"Creation d'un nouveau client  Id: {id}");
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
        [HttpGet("{id}")]

        public IActionResult GetClient(int id) 
        {
            try
            {
                if (id == 0)
                {
                    ClientPOCO client = _clientRepository.Get(id);
                    return Ok(client);
                }
                else
                {
                    return NotFound("pas de client correspondant a cet ID");
                }
            }
            catch (Exception ex)
            {
                return NotFound("pas de client correspondant a cet ID");
            }
        }
        [HttpGet]
        public IActionResult GetAllClients()
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
        [HttpPatch]
        public IActionResult UpdateClient(int id, ClientDTO UpClient)
        {
            
            try
            {
                ClientPOCO clientUP = new ClientPOCO();
                clientUP.Id = id;
                clientUP.Nom = UpClient.Nom;
                clientUP.Prenom = UpClient.Prenom;
                clientUP.Telephone = UpClient.Telephone;
                clientUP.Email = UpClient.Email;
                clientUP.Adresse = UpClient.Adresse;

                Console.WriteLine(clientUP.Nom);

                _clientRepository.Update(clientUP);
                 return Ok($"client mis a jour id: {id}");
                
            }
            catch (Exception ex)
            {
                return BadRequest($"Error updating client: {ex.Message}");
            }
        }
    }

}

        

     
