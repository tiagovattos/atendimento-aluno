using Microsoft.EntityFrameworkCore;
using atendimento_aluno.Models;

namespace atendimento_aluno.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<atendimento_aluno.Models.Aluno> Aluno { get; set; }

        public DbSet<atendimento_aluno.Models.Atendimento> Atendimento { get; set; }

        public DbSet<atendimento_aluno.Models.Sala> Sala { get; set; }

    }
}
