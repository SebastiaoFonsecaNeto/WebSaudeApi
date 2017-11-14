using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("procedimento")]
    public class Procedimento
    {
        public Procedimento()
        {
            PacienteProcedimento = new HashSet<PacienteProcedimento>();
            ProcedimentoConvenio = new HashSet<ProcedimentoConvenio>();
            ProcedimentoMatmed = new HashSet<ProcedimentoMatmed>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public int? Tipo { get; set; }
        public virtual ICollection<PacienteProcedimento> PacienteProcedimento { get; set; }
        public virtual ICollection<ProcedimentoConvenio> ProcedimentoConvenio { get; set; }
        public virtual ICollection<ProcedimentoMatmed> ProcedimentoMatmed { get; set; }
    }
}