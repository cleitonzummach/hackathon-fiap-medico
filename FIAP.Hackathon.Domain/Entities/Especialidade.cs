namespace FIAP.Hackathon.Domain.Entities
{
    public class Especialidade
    {
        public Guid EspecialidadeId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Medico> Medicos { get; set; }
    }
}
