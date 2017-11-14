using System;
using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class NotaFiscalItem
    {
        public NotaFiscalItem()
        {
            EstoqueLote = new HashSet<EstoqueLote>();
        }

        public int Id { get; set; }
        public int EstoqueProdutoId { get; set; }
        public int NotaFiscalId { get; set; }
        public string NumeroLote { get; set; }
        public DateTime? DataVencimento { get; set; }
        public int? Quantidade { get; set; }
        public decimal? ValorUnitario { get; set; }
        public virtual ICollection<EstoqueLote> EstoqueLote { get; set; }
        public virtual EstoqueProduto EstoqueProduto { get; set; }
        public virtual NotaFiscal NotaFiscal { get; set; }
    }
}