using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Autor")]
    public class Autor
    { 
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
    }
}

/*
    [Id] uniqueidentifier NOT NULL
    [Nome] NVARCHAR(80) NOT NULL
    [Bio] NVARCHAR(2000) NOT NULL 
    [Email] NVARCHAR(160) NOT NULL
*/