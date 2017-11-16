using System;
using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class ProntuarioClinico
    {
        public ProntuarioClinico()
        {
            PacienteMatmed = new HashSet<PacienteMatmed>();
            PacienteProcedimento = new HashSet<PacienteProcedimento>();
        }

        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int ProfissionalId { get; set; }
        public int CboId { get; set; }
        public int UnidadeId { get; set; }
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; }
        public int? PressaoMax { get; set; }
        public int? PressaoMin { get; set; }
        public int? Saturacao { get; set; }
        public int? Peso { get; set; }
        public int? Altura { get; set; }
        public virtual Cbo Cbo { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual ICollection<PacienteMatmed> PacienteMatmed { get; set; }
        public virtual ICollection<PacienteProcedimento> PacienteProcedimento { get; set; }
        public virtual Profissional Profissional { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}