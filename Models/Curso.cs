using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Curso")]
    public class Curso
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public Guid AutorId { get; set; }
        public Guid CategoriaId { get; set; }
    }
}

/*
    [Id] uniqueidentifier NOT NULL
    [Titulo] NVARCHAR(160) NOT NULL
    [Descricao] NVARCHAR(2000) NOT NULL
    [DuracaoEmMinutos] INT NOT NULL
    [DataCriacao] DATETIME NOT NULL
    [DataUltimaAtualizacao] DATETIME NOT NULL
    [AutorId] uniqueidentifier NOT NULL
    [CategoriaId] uniqueidentifier NOT NULL
*/