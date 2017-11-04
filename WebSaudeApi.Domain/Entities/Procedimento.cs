using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("procedimento")]
    public partial class Procedimento
    {
        
        public Procedimento()
        {
            PacienteProcedimento = new HashSet<PacienteProcedimento>();
            ProcedimentoConvenio = new HashSet<ProcedimentoConvenio>();
            ProcedimentoMatmed = new HashSet<ProcedimentoMatmed>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(8)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(250)]
        public string Descricao { get; set; }

        [Column(TypeName = "money")]
        public decimal? Valor { get; set; }

        public int? Tipo { get; set; }

        
        public virtual ICollection<PacienteProcedimento> PacienteProcedimento { get; set; }

        
        public virtual ICollection<ProcedimentoConvenio> ProcedimentoConvenio { get; set; }

        
        public virtual ICollection<ProcedimentoMatmed> ProcedimentoMatmed { get; set; }
    }
}
