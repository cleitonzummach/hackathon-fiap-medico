using FIAP.Hackathon.Domain.Entities;
using FIAP.Hackathon.Domain.Repositories;
using FIAP.Hackathon.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FIAP.Hackathon.Infrastructure.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly HackathonDBContext _context;
        
        public MedicoRepository(HackathonDBContext context) 
        {
            _context = context;
        }

        public Medico? ValidarLogin(string email, string senha)
        {
            return _context.Medico.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }

        public IEnumerable<Medico>? RetornarPorEspecialidade(Guid? especialidadeId)
        {
            var query = _context.Medico
                .Include(m => m.Especialidade)
                .AsQueryable();

            if (especialidadeId.HasValue)
                query = query.Where(x => x.EspecialidadeId == especialidadeId.Value);

            return query.ToList();
        }

        public Medico? RetornarPorId(Guid medicoId)
        {
            return _context.Medico
                .Include(m => m.Especialidade)
                .FirstOrDefault(x => x.MedicoId == medicoId);
        }
    }
}
