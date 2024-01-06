using Microsoft.AspNetCore.Mvc;
using ContatosApp.Models;
using ContatosApp.Services;

namespace ContatosApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContatosController : ControllerBase
    {
        private readonly ContatoService _contatoService;

        public ContatosController(ContatoService contatoService)
        {
            _contatoService = contatoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Contato>>> GetAll()
        {
            var contatos = await _contatoService.GetAllContatos();
            return Ok(contatos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contato>> GetById(int id)
        {
            var contato = await _contatoService.GetContatoById(id);
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Contato contato)
        {
            await _contatoService.CreateContato(contato);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Contato contato)
        {
            if (id != contato.Id)
            {
                return BadRequest();
            }
            await _contatoService.UpdateContato(contato);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _contatoService.DeleteContato(id);
            return Ok();
        }
    }
}
