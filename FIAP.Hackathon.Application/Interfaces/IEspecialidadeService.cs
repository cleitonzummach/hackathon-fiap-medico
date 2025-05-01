using FIAP.Hackathon.Application.Responses;

namespace FIAP.Hackathon.Application.Interfaces
{
    public interface IEspecialidadeService
    {
        IEnumerable<EspecialidadeResponse>? RetornarEspecialidades();
    }
}
