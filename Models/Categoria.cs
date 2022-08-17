using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Categoria")]
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}

/*
    [Id] uniqueidentifier NOT NULL
    [Titulo] NVARCHAR(160) NOT NULL
    [Descricao] TEXT NOT NULL
*/