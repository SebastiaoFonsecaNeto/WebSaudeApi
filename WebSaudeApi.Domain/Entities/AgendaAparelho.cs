using System;

namespace WebSaude.Domain.Entities
{
    public class AgendaAparelho
    {
        public int Id { get; set; }
        public int UnidadeId { get; set; }
        public int AparelhoId { get; set; }
        public int? PacienteId { get; set; }
        public int? ConvenioId { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public string Descricao { get; set; }
        public string Contato { get; set; }
        public string Contato2 { get; set; }
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