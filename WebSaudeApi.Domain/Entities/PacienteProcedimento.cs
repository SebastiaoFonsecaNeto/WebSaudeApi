using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class PacienteProcedimento
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }

        public int ProcedimentoId { get; set; }

        public int? ProntuarioClinicoId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Valor { get; set; }

        public int Quantidade { get; set; }

        public bool? Faturado { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Procedimento Procedimento { get; set; }

        public virtual ProntuarioClinico ProntuarioClinico { get; set; }
    }
}
