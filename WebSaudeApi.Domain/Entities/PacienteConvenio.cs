using System;

namespace WebSaude.Domain.Entities
{
    public class PacienteConvenio
    {
        public int Id { get; set; }
        public int ConveniosId { get; set; }
        public int PacienteId { get; set; }
        public string NumeroPlano { get; set; }
        public string DescricaoPlano { get; set; }
        public DateTime? ValidadePlano { get; set; }
        public virtual Convenio Convenio { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}