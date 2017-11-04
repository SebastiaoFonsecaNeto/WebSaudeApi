using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class PacienteConta
    {
        public PacienteConta()
        {
            PlanoContas = new HashSet<PlanoContas>();
        }

        public int Id { get; set; }

        public int PacienteId { get; set; }

        public int ContaTipoId { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] DataHora { get; set; }

        [Required]
        [StringLength(250)]
        public string Descricao { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        public int? NumeroRecibo { get; set; }

        public int? GuiaTissId { get; set; }

        public virtual ContaTipo ContaTipo { get; set; }

        public virtual GuiaTiss GuiaTiss { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual ICollection<PlanoContas> PlanoContas { get; set; }
    }
}
