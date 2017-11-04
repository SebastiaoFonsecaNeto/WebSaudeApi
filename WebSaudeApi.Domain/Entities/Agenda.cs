using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class Agenda
    {
        public int Id { get; set; }

        public int UnidadeId { get; set; }

        public int ProfissionalId { get; set; }

        public int? PacienteId { get; set; }

        public int? ConvenioId { get; set; }

        public int? CboId { get; set; }

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

        public int AnsConsultaId { get; set; }

        public int AnsAcidenteId { get; set; }

        public virtual AnsIndicadorAcidente AnsIndicadorAcidente { get; set; }

        public virtual AnsTipoConsulta AnsTipoConsulta { get; set; }

        public virtual Cbo Cbo { get; set; }

        public virtual Convenio Convenio { get; set; }

        public virtual Paciente Paciente { get; set; }

        public virtual Profissional Profissional { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}
