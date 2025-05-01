using FIAP.Hackathon.Application.Responses;

namespace FIAP.Hackathon.Application.Interfaces
{
    public interface IMedicoService
    {
        IEnumerable<MedicoResponse>? RetornarPorEspecialidade(Guid? especialidadeId);
        MedicoResponse? RetornarPorId(Guid medicoId);
    }
}
