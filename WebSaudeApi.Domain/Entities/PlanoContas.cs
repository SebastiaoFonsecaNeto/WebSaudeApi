using System;

namespace WebSaude.Domain.Entities
{
    public class PlanoContas
    {
        public int Id { get; set; }
        public int ContaCategoriaId { get; set; }
        public int? PacienteContaId { get; set; }
        public int ContaTipoId { get; set; }
        public int ContaId { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public virtual Conta Conta { get; set; }
        public virtual ContaCategoria ContaCategoria { get; set; }
        public virtual ContaTipo ContaTipo { get; set; }
        public virtual PacienteConta PacienteConta { get; set; }
    }
}