using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class ProfissionalPagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProfissionalId { get; set; }

        public int PagamentoId { get; set; }

        public int ReciboId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Valor { get; set; }

        public virtual Pagamento Pagamento { get; set; }

        public virtual Profissional Profissional { get; set; }

        public virtual Recibo Recibo { get; set; }
    }
}
