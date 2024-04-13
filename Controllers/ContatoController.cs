using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using ProvaBlue.Business;
using ProvaBlue.Models;

namespace ProvaBlue.Controllers {
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ContatoController : ControllerBase {

        private readonly ILogger<ContatoController> _logger;
        private readonly IContatoBusiness _contatoBusiness;

        public ContatoController(ILogger<ContatoController> logger, IContatoBusiness contatoBusiness) {
            _logger = logger;
            _contatoBusiness = contatoBusiness;
        }

        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<ContatoModel>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<ContatoModel>> FindAllContacts() {
            //List<ContatoModel> contatoLista = await _contatoBusiness.ListarTodosContatos();
            //return Ok(contatoLista);
            // ou
            return Ok(await _contatoBusiness.ListarTodosContatos());
        }

        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(List<ContatoModel>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<ContatoModel>> FindContactById(int id) {
            ContatoModel contato = await _contatoBusiness.ListarPorId(id);
            if(contato == null) {
                return NotFound($"O contato de id {id} não foi encontrado");
            }
            return Ok(contato);
        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(List<ContatoModel>))]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<ContatoModel>> InsertContact([FromBody]ContatoModel contato) {
            return Ok(await _contatoBusiness.CriarContato(contato));
        }

        [HttpPut]
        [ProducesResponseType((200), Type = typeof(List<ContatoModel>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<ActionResult<ContatoModel>> UpdateContact([FromBody]ContatoModel contato) {
            if(contato == null) {
                return BadRequest();
            }
            return Ok(await _contatoBusiness.ModificarContato(contato));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult DeleteContact(int id) {
            if(id == null) {
                return BadRequest();
            }
            _contatoBusiness.DeletarContato(id);
            return NoContent();
        }

    }
}
