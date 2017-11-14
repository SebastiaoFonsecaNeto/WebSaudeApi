using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Convenio
    {
        public Convenio()
        {
            Agenda = new HashSet<Agenda>();
            AgendaAparelho = new HashSet<AgendaAparelho>();
            PacienteConvenio = new HashSet<PacienteConvenio>();
            ProcedimentoCboConvenio = new HashSet<ProcedimentoCboConvenio>();
            ProcedimentoConvenio = new HashSet<ProcedimentoConvenio>();
            ProntoAtendimento = new HashSet<ProntoAtendimento>();
        }

        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int RegistroAns { get; set; }
        public string CodigoOperadora { get; set; }
        public string LoginOperadora { get; set; }
        public string SenhaOperadora { get; set; }
        public int? PercentualMatmed { get; set; }
        public int? PercentualHonorario { get; set; }
        public virtual ICollection<Agenda> Agenda { get; set; }
        public virtual ICollection<AgendaAparelho> AgendaAparelho { get; set; }
        public virtual ICollection<PacienteConvenio> PacienteConvenio { get; set; }
        public virtual ICollection<ProcedimentoCboConvenio> ProcedimentoCboConvenio { get; set; }
        public virtual ICollection<ProcedimentoConvenio> ProcedimentoConvenio { get; set; }
        public virtual ICollection<ProntoAtendimento> ProntoAtendimento { get; set; }
    }
}