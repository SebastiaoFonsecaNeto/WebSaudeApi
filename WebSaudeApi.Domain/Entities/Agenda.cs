using System;

namespace WebSaude.Domain.Entities
{
    public class Agenda
    {
        public int Id { get; set; }
        public int UnidadeId { get; set; }
        public int ProfissionalId { get; set; }
        public int? PacienteId { get; set; }
        public int? ConvenioId { get; set; }
        public int? CboId { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descricao { get; set; }
        public string Contato { get; set; }
        public string Contato2 { get; set; }
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