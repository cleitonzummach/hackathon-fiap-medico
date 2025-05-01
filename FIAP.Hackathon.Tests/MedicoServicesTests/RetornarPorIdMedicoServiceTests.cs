using FIAP.Hackathon.Domain.Entities;

namespace FIAP.Hackathon.Tests.MedicoServicesTests
{
    public class RetornarPorIdMedicoServiceTests : MedicoServiceTestsBase
    {
        private readonly Guid _medicoIdExistente = Guid.NewGuid();
        private readonly Guid _medicoIdInexistente = Guid.NewGuid();

        [Fact]
        public void RetornarPorId_MedicoExistente_RetornaMedico()
        {
            // Arrange
            var medico = GerarMedico(_medicoIdExistente);
            _mockMedicoRepository.Setup(repo => repo.RetornarPorId(_medicoIdExistente)).Returns(medico);

            // Act
            var response = _medicoService.RetornarPorId(_medicoIdExistente);

            // Assert
            Assert.NotNull(response);
        }

        [Fact]
        public void RetornarPorId_MedicoInexistente_RetornaNull()
        {
            // Arrange
            _mockMedicoRepository.Setup(repo => repo.RetornarPorId(_medicoIdInexistente)).Returns((Medico?)null);

            // Act
            var response = _medicoService.RetornarPorId(_medicoIdInexistente);

            // Assert
            Assert.Null(response);
        }
    }
}
