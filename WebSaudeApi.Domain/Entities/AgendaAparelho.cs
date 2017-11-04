using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class AgendaAparelho
    {
        public int Id { get; set; }

        public int UnidadeId { get; set; }

        public int AparelhoId { get; set; }

        public int? PacienteId { get; set; }

        public int? ConvenioId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data { get; set; }

        public TimeSpan Hora { get; set; }

        [StringLength(250)]
        public string Descricao { get; set; }

        [StringLength(11)]
        public string Contato { get; set; }

        [StringLength(11)]
        public string Contato2 { get; set; }

        [StringLength(250)]
        public string Observacao { get; set; }

        public bool Falta { get; set; }

        public bool Bloqueado { get; set; }

        public bool Faturado { get; set; }

        public virtual Aparelho Aparelho { get; set; }

        public virtual Convenio Convenio { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}
