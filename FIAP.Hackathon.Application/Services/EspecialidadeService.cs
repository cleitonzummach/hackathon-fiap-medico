using FIAP.Hackathon.Application.Interfaces;
using FIAP.Hackathon.Application.Responses;
using FIAP.Hackathon.Domain.Repositories;

namespace FIAP.Hackathon.Application.Services
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly IEspecialidadeRepository _especialidadeRepository;

        public EspecialidadeService(IEspecialidadeRepository especialidadeRepository) 
        {
            _especialidadeRepository = especialidadeRepository;
        }

        public IEnumerable<EspecialidadeResponse>? RetornarEspecialidades()
        {
            var especialidades = _especialidadeRepository.RetornarTodas();

            if (especialidades != null)
            {
                return especialidades.Select(e => new EspecialidadeResponse(e));
            }

            return null;
        }
    }
}
