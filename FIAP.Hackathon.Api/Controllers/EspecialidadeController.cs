using FIAP.Hackathon.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.Hackathon.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EspecialidadeController : Controller
    {
        private readonly IEspecialidadeService _especialidadeService;

        public EspecialidadeController(IEspecialidadeService especialidadeService) 
        {
            _especialidadeService = especialidadeService;
        }

        [HttpGet]
        public IActionResult RetornarEspecialidades()
        {
            return Ok(_especialidadeService.RetornarEspecialidades());
        }
    }
}
