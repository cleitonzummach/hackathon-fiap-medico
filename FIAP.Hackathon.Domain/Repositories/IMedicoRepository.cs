using FIAP.Hackathon.Domain.Entities;

namespace FIAP.Hackathon.Domain.Repositories
{
    public interface IMedicoRepository
    {
        Medico? ValidarLogin(string email, string senha);
        IEnumerable<Medico>? RetornarPorEspecialidade(Guid? especialidadeId);
        Medico? RetornarPorId(Guid medicoId);
    }
}
