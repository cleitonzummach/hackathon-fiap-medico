using FIAP.Hackathon.Domain.Entities;

namespace FIAP.Hackathon.Tests.TokenServicesTests
{
    public class RetornarTokenServiceTests : TokenServiceTestsBase
    {
        private const string EmailValido = "teste@email.com";
        private const string SenhaValida = "senha123";

        [Fact]
        public void RetornarToken_CredenciaisValidas_RetornaTokenJWT()
        {
            // Arrange
            Medico medicoValido = new Medico(Guid.NewGuid(), "Nome Teste", "159753", "email@teste.com", "senha");
            medicoValido.MedicoId = Guid.NewGuid();
            _mockMedicoRepository.Setup(repo => repo.ValidarLogin(EmailValido, SenhaValida)).Returns(medicoValido);

            // Act
            var tokenString = _tokenService.RetornarToken(EmailValido, SenhaValida);

            // Assert
            Assert.NotNull(tokenString);
            Assert.NotEmpty(tokenString);
        }

        [Fact]
        public void RetornarToken_CredenciaisInvalidas_RetornaNull()
        {
            // Arrange
            _mockMedicoRepository.Setup(repo => repo.ValidarLogin(EmailValido, SenhaValida)).Returns((Medico?)null);

            // Act
            var tokenString = _tokenService.RetornarToken(EmailValido, SenhaValida);

            // Assert
            Assert.NotNull(tokenString);
            Assert.Empty(tokenString);
        }
    }
}
