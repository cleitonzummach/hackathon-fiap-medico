using FIAP.Hackathon.Domain.Entities;

namespace FIAP.Hackathon.Tests.MedicoServicesTests
{
    public class RetornarPorEspecialidadeServiceTests : MedicoServiceTestsBase
    {
        private readonly Guid _especialidadeId = Guid.NewGuid();

        [Fact]
        public void RetornarPorEspecialidade_EspecialidadeIdValido_RetornaLista()
        {
            // Arrange
            var medicos = GerarListaDeMedicos(_especialidadeId).ToList();
            var outrosMedicos = GerarListaDeMedicos().Where(m => m.EspecialidadeId != _especialidadeId);
            var listaCompleta = medicos.Concat(outrosMedicos).ToList();

            _mockMedicoRepository.Setup(repo => repo.RetornarPorEspecialidade(_especialidadeId)).Returns(medicos);

            // Act
            var response = _medicoService.RetornarPorEspecialidade(_especialidadeId);

            // Assert
            Assert.NotNull(response);
        }

        [Fact]
        public void RetornarPorEspecialidade_EspecialidadeSemMedicos_RetornaNull()
        {
            // Arrange
            _mockMedicoRepository.Setup(repo => repo.RetornarPorEspecialidade(_especialidadeId)).Returns((IEnumerable<Medico>)null);

            // Act
            var response = _medicoService.RetornarPorEspecialidade(_especialidadeId);

            // Assert
            Assert.Null(response);
        }
    }
}
