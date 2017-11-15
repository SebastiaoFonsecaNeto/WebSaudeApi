using System;

namespace WebSaude.Domain.Entities
{
    public class PacienteMatmed
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int EstoqueId { get; set; }
        public int ProntuarioClinicoId { get; set; }
        public string NumeroLote { get; set; }
        public DateTime? DataVencimento { get; set; }
        public decimal? Valor { get; set; }
        public int? Quantidade { get; set; }
        public int? Status { get; set; }
        public byte[] DataHora { get; set; }
        public virtual EstoqueProduto EstoqueProduto { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual ProntuarioClinico ProntuarioClinico { get; set; }
    }
}