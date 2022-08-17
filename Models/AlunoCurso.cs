using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("AlunoCurso")]
    public class AlunoCurso
    {
        public Guid CoursoId { get; set; }
        public Guid AlunoId { get; set; }
        public byte Progresso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime UltimaDataAtualizacao { get; set; }
    }
}

/*
    [CoursoId] uniqueidentifier NOT NULL
    [AlunoId] uniqueidentifier NOT NULL
    [Progresso] TINYINT NOT NULL
    [DataInicio] DATETIME NOT NULL
    [UltimaDataAtualizacao] DATETIME NULL DEFAULT(GETDATE())
*/