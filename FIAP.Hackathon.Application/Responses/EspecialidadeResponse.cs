using FIAP.Hackathon.Domain.Entities;

namespace FIAP.Hackathon.Application.Responses
{
    public class EspecialidadeResponse
    {
        public Guid EspecialidadeId { get; set; }
        public string Descricao { get; set; }

        public EspecialidadeResponse(Especialidade especialidade)
        {
            EspecialidadeId = especialidade.EspecialidadeId;
            Descricao = especialidade.Descricao;
        }
    }
}
