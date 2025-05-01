using FIAP.Hackathon.Domain.Entities;

namespace FIAP.Hackathon.Tests.EspecialidadeServicesTests
{
    public class RetornarEspecialidadesServiceTests : EspecialidadeServiceTestsBase
    {
        [Fact]
        public void RetornarEspecialidades_ExistemEspecialidades_RetornaLista()
        {
            // Arrange
            var especialidades = new List<Especialidade>
            {
                new Especialidade { EspecialidadeId = new Guid(), Descricao = "Cardiologia" },
                new Especialidade { EspecialidadeId = new Guid(), Descricao = "Dermatologia" },
                new Especialidade { EspecialidadeId = new Guid(), Descricao = "Neurologia" }
            };
            _mockEspecialidadeRepository.Setup(repo => repo.RetornarTodas()).Returns(especialidades);

            // Act
            var response = _especialidadeService.RetornarEspecialidades();

            // Assert
            Assert.NotNull(response);
        }

        [Fact]
        public void RetornarEspecialidades_NaoExistemEspecialidades_RetornaNull()
        {
            // Arrange
            _mockEspecialidadeRepository.Setup(repo => repo.RetornarTodas()).Returns((List<Especialidade>)null);

            // Act
            var response = _especialidadeService.RetornarEspecialidades();

            // Assert
            Assert.Null(response);
        }
    }
}
