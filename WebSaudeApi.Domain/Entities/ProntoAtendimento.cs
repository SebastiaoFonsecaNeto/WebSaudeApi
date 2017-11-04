using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class ProntoAtendimento
    {
        public int Id { get; set; }

        public int? UnidadeId { get; set; }

        public int? ProfissionalId { get; set; }

        public int? PacienteId { get; set; }

        public int? ConvenioId { get; set; }

        public int? CboId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public TimeSpan Hora { get; set; }

        public int Risco { get; set; }

        [Required]
        [StringLength(200)]
        public string Obs { get; set; }

        public int Bloqueado { get; set; }

        public int? Faturado { get; set; }

        public int AnsConsultaId { get; set; }

        public int AnsAcidenteId { get; set; }

        public virtual Cbo Cbo { get; set; }

        public virtual Convenio Convenio { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Profissional Profissional { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}
