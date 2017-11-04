using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("convenio")]
    public partial class Convenio
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

        [Required]
        [StringLength(150)]
        public string RazaoSocial { get; set; }

        [Required]
        [StringLength(150)]
        public string NomeFantasia { get; set; }

        public int RegistroAns { get; set; }

        [Required]
        [StringLength(25)]
        public string CodigoOperadora { get; set; }

        [StringLength(50)]
        public string LoginOperadora { get; set; }

        [StringLength(30)]
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
