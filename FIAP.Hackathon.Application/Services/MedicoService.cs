using FIAP.Hackathon.Application.Interfaces;
using FIAP.Hackathon.Application.Responses;
using FIAP.Hackathon.Domain.Entities;
using FIAP.Hackathon.Domain.Repositories;

namespace FIAP.Hackathon.Application.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoService(IMedicoRepository medicoRepository) 
        {
            _medicoRepository = medicoRepository;
        }

        public IEnumerable<MedicoResponse>? RetornarPorEspecialidade(Guid? especialidadeId)
        {
            var medicos = _medicoRepository.RetornarPorEspecialidade(especialidadeId);

            if (medicos != null)
            {
                return medicos.Select(e => new MedicoResponse(e));
            }

            return null;
        }

        public MedicoResponse? RetornarPorId(Guid medicoId)
        {
            var medico = _medicoRepository.RetornarPorId(medicoId);

            if (medico != null)
                return new MedicoResponse(medico);

            return null;
        }
    }
}
