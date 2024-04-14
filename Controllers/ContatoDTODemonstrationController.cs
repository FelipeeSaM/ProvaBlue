using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvaBlue.Models;
using ProvaBlue.Models.DTOs;

namespace ProvaBlue.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoDTODemonstrationController : ControllerBase {
        private readonly ILogger<ContatoDTODemonstrationController> _logger;
        private readonly IMapper _mapper;

        public ContatoDTODemonstrationController(ILogger<ContatoDTODemonstrationController> logger, IMapper mapper) {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUserDTOExample() {

            var contato = new ContatoModel() {
                Id = 1,
                Nome = "usuario teste",
                Email = "teste@demonstracao.com",
                Numero = "81-9-9922-1356"
            };

            var returnedUser = _mapper.Map<ContatoAutoMapperDTO>(contato);
            return Ok(returnedUser);

        }

    }
}
