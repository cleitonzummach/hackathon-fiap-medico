using FIAP.Hackathon.Application.Services;
using FIAP.Hackathon.Domain.Entities;
using FIAP.Hackathon.Domain.Repositories;
using Moq;

namespace FIAP.Hackathon.Tests.MedicoServicesTests
{
    public class MedicoServiceTestsBase
    {
        protected readonly Mock<IMedicoRepository> _mockMedicoRepository;
        protected readonly MedicoService _medicoService;

        public MedicoServiceTestsBase()
        {
            _mockMedicoRepository = new Mock<IMedicoRepository>();
            _medicoService = new MedicoService(_mockMedicoRepository.Object);
        }

        protected IEnumerable<Medico> GerarListaDeMedicos(Guid? especialidadeId = null)
        {
            return new List<Medico>
        {
            new Medico { MedicoId = Guid.NewGuid(), Nome = "Dr. João", EspecialidadeId = especialidadeId ?? Guid.NewGuid() },
            new Medico { MedicoId = Guid.NewGuid(), Nome = "Dra. Maria", EspecialidadeId = especialidadeId ?? Guid.NewGuid() },
            new Medico { MedicoId = Guid.NewGuid(), Nome = "Dr. Carlos", EspecialidadeId = Guid.NewGuid() }
        };
        }

        protected Medico GerarMedico(Guid medicoId)
        {
            return new Medico { MedicoId = medicoId, Nome = "Dr. Teste", EspecialidadeId = Guid.NewGuid(), Especialidade = new Especialidade() { EspecialidadeId = Guid.NewGuid(), Descricao = "Clínico Geral" } };
        }
    }
}
