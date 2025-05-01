namespace FIAP.Hackathon.Domain.Entities
{
    public class Medico
    {
        public Guid MedicoId { get; set; }
        public Guid EspecialidadeId { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? DataExclusao { get; set; }

        public Especialidade Especialidade { get; set; }

        public Medico() 
        {
        
        }
        
        public Medico(Guid especialidadeId, string nome, string crm, string email, string senha)
        {
            EspecialidadeId = especialidadeId;
            Nome = nome;
            CRM = crm;
            Email = email;
            Senha = senha;
        }
    }
}
