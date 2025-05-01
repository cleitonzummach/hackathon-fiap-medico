using FIAP.Hackathon.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FIAP.Hackathon.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicoController : Controller
    {
        private readonly ITokenService _tokenService;
        private readonly IMedicoService _medicoService;

        public MedicoController(ITokenService tokenService, IMedicoService medicoService)
        {
            _tokenService = tokenService;
            _medicoService = medicoService;
        }

        [HttpPost("Autenticar")]
        public IActionResult AutenticarPaciente([Required] string email, [Required] string senha)
        {
            var token = _tokenService.RetornarToken(email, senha);

            if (!string.IsNullOrEmpty(token))
            {
                return Ok(token);
            }

            return BadRequest("Não foi possível autenticar. Favor verifique.");
        }

        [HttpGet("Consultar")]
        public IActionResult RetornarMedicos(Guid? especialidadeId)
        {
            var medicos = _medicoService.RetornarPorEspecialidade(especialidadeId);
            return Ok(medicos);
        }

        [HttpGet("{medicoId}")]
        public IActionResult RetornarDadosMedico(Guid medicoId)
        {
            var medico = _medicoService.RetornarPorId(medicoId);
            return Ok(medico);
        }
    }
}
