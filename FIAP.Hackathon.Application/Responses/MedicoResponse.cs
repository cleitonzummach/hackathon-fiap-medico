using FIAP.Hackathon.Domain.Entities;

namespace FIAP.Hackathon.Application.Responses
{
    public class MedicoResponse
    {
        public string Especialidade { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Endereco { get; set; }

        public MedicoResponse(Medico medico)
        {
            Especialidade = medico.Especialidade.Descricao;
            Nome = medico.Nome;
            CRM = medico.CRM;
            Endereco = string.Format("{0} - {1}/{2} - {3}", medico.Endereco, medico.Cidade, medico.Estado, medico.CEP);
        }
    }
}
