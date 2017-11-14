using System;
using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class EstoqueLote
    {
        public EstoqueLote()
        {
            EstoqueKardex = new HashSet<EstoqueKardex>();
        }

        public int Id { get; set; }
        public int EstoqueProdutoId { get; set; }
        public int NotaFiscalItemId { get; set; }
        public string NumeroLote { get; set; }
        public DateTime? DataVencimento { get; set; }
        public int? Quantidade { get; set; }
        public decimal? ValorUnitario { get; set; }
        public virtual ICollection<EstoqueKardex> EstoqueKardex { get; set; }
        public virtual EstoqueProduto EstoqueProduto { get; set; }
        public virtual NotaFiscalItem NotaFiscalItem { get; set; }
    }
}