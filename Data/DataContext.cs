using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class DataContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoCurso> Matriculas { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder DBOptions) 
            => DBOptions.UseSqlServer(@"SQL_CONNECTION_STRING");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoCurso>()
                .HasKey(x => new { x.CoursoId, x.AlunoId });
        }
    }
}