using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class PacienteMatmed
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }

        public int EstoqueId { get; set; }

        public int ProntuarioClinicoId { get; set; }

        [StringLength(25)]
        public string NumeroLote { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataVencimento { get; set; }

        [Column(TypeName = "money")]
        public decimal? Valor { get; set; }

        public int? Quantidade { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] DataHora { get; set; }

        public virtual EstoqueProduto EstoqueProduto { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual ProntuarioClinico ProntuarioClinico { get; set; }
    }
}
