using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Aluno")]
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }  
        public DateTime DataCriacao { get; set; }
    }
}

/*
    [Id] uniqueidentifier NOT NULL
    [Nome] NVARCHAR(120) NOT NULL
    [Email] NVARCHAR(180) NOT NULL
    [CPF] VARCHAR(11) NOT NULL
    [DataCriacao] DATETIME NOT NULL DEFAULT(GETDATE())
*/