using System;

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
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public int Risco { get; set; }
        public string Obs { get; set; }
        public string Descricao { get; set; }
        public string Contato { get; set; }
        public string Contato2 { get; set; }
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