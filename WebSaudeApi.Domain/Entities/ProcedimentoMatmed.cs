using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class ProcedimentoMatmed
    {
        public int Id { get; set; }

        public int ProcedimentoId { get; set; }

        public int EstoqueId { get; set; }

        public int Quantidade { get; set; }

        [StringLength(8)]
        public string CodigoTuss { get; set; }

        public virtual EstoqueProduto EstoqueProduto { get; set; }

        public virtual Procedimento Procedimento { get; set; }
    }
}
