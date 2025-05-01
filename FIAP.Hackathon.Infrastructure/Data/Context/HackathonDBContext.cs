using FIAP.Hackathon.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FIAP.Hackathon.Infrastructure.Data.Context
{
    public class HackathonDBContext : DbContext
    {
        public HackathonDBContext(DbContextOptions<HackathonDBContext> options) : base(options)
        {
        }

        public DbSet<Medico> Medico { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidade>()
                .HasKey(e => e.EspecialidadeId);

            modelBuilder.Entity<Medico>()
                .HasKey(m => m.MedicoId);

            modelBuilder.Entity<Medico>()
                .HasOne(m => m.Especialidade) // Propriedade de navegação para Especialidade
                .WithMany(e => e.Medicos)    // Propriedade de navegação para a coleção de Medicos em Especialidade
                .HasForeignKey(m => m.EspecialidadeId); // Coluna que é a chave estrangeira

            base.OnModelCreating(modelBuilder);
        }
    }
}
