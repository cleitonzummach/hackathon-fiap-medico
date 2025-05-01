using FIAP.Hackathon.Domain.Entities;

namespace FIAP.Hackathon.Domain.Repositories
{
    public interface IEspecialidadeRepository
    {
        List<Especialidade>? RetornarTodas();
    }
}
