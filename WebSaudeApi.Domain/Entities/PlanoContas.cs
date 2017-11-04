using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class PlanoContas
    {
        public int Id { get; set; }

        public int ContaCategoriaId { get; set; }

        public int? PacienteContaId { get; set; }

        public int ContaTipoId { get; set; }

        public int ContaId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        [StringLength(250)]
        public string Descricao { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        public virtual Conta Conta { get; set; }

        public virtual ContaCategoria ContaCategoria { get; set; }

        public virtual ContaTipo ContaTipo { get; set; }

        public virtual PacienteConta PacienteConta { get; set; }
    }
}
