using System;

namespace WebSaude.Domain.Entities
{
    public class Encaminhamento
    {
        public int Id { get; set; }
        public int CboId { get; set; }
        public int ProfissionalId { get; set; }
        public int PacienteId { get; set; }
        public byte[] DataHora { get; set; }
        public string Descricao { get; set; }
        public virtual Cbo Cbo { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}