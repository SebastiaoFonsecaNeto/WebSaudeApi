using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("cbo")]
    public partial class Cbo
    {
        public Cbo()
        {
            Agenda = new HashSet<Agenda>();
            Encaminhamento = new HashSet<Encaminhamento>();
            ProcedimentoCboConvenio = new HashSet<ProcedimentoCboConvenio>();
            Profissional = new HashSet<Profissional>();
            ProntoAtendimento = new HashSet<ProntoAtendimento>();
            ProntuarioClinico = new HashSet<ProntuarioClinico>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        public int DiasLimiteAtendimento { get; set; }

        public int DiasLimiteRetorno { get; set; }

        public bool Clinico { get; set; }
        
        public virtual ICollection<Agenda> Agenda { get; set; }
        
        public virtual ICollection<Encaminhamento> Encaminhamento { get; set; }
        
        public virtual ICollection<ProcedimentoCboConvenio> ProcedimentoCboConvenio { get; set; }
        
        public virtual ICollection<Profissional> Profissional { get; set; }
        
        public virtual ICollection<ProntoAtendimento> ProntoAtendimento { get; set; }
        
        public virtual ICollection<ProntuarioClinico> ProntuarioClinico { get; set; }
    }
}
