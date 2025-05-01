using FIAP.Hackathon.Domain.Entities;
using FIAP.Hackathon.Domain.Repositories;
using FIAP.Hackathon.Infrastructure.Data.Context;

namespace FIAP.Hackathon.Infrastructure.Repositories
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly HackathonDBContext _context;
        
        public EspecialidadeRepository(HackathonDBContext context) 
        {
            _context = context;
        }

        public List<Especialidade>? RetornarTodas()
        {
            return _context.Especialidade.ToList();
        }
    }
}
