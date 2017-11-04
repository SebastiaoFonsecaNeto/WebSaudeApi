using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class ProcedimentoConvenio
    {
        public int Id { get; set; }

        public int ProcedimentoId { get; set; }

        public int ConvenioId { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        public virtual Convenio Convenio { get; set; }

        public virtual Procedimento Procedimento { get; set; }
    }
}
