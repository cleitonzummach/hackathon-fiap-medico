using FIAP.Hackathon.Application.Services;
using FIAP.Hackathon.Domain.Repositories;
using Moq;

namespace FIAP.Hackathon.Tests.EspecialidadeServicesTests
{
    public class EspecialidadeServiceTestsBase
    {
        protected readonly Mock<IEspecialidadeRepository> _mockEspecialidadeRepository;
        protected readonly EspecialidadeService _especialidadeService;

        public EspecialidadeServiceTestsBase()
        {
            _mockEspecialidadeRepository = new Mock<IEspecialidadeRepository>();
            _especialidadeService = new EspecialidadeService(_mockEspecialidadeRepository.Object);
        }
    }
}
