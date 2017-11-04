using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class NotaFiscalItem
    {
        public NotaFiscalItem()
        {
            EstoqueLote = new HashSet<EstoqueLote>();
        }

        public int Id { get; set; }

        public int EstoqueProdutoId { get; set; }

        public int NotaFiscalId { get; set; }

        [StringLength(30)]
        public string NumeroLote { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataVencimento { get; set; }

        public int? Quantidade { get; set; }

        [Column(TypeName = "money")]
        public decimal? ValorUnitario { get; set; }
        
        public virtual ICollection<EstoqueLote> EstoqueLote { get; set; }

        public virtual EstoqueProduto EstoqueProduto { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }
    }
}
