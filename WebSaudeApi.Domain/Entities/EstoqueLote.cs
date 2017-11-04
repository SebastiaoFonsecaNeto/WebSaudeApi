using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class EstoqueLote
    {
        public EstoqueLote()
        {
            EstoqueKardex = new HashSet<EstoqueKardex>();
        }

        public int Id { get; set; }

        public int EstoqueProdutoId { get; set; }

        public int NotaFiscalItemId { get; set; }

        [StringLength(30)]
        public string NumeroLote { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataVencimento { get; set; }

        public int? Quantidade { get; set; }

        [Column(TypeName = "money")]
        public decimal? ValorUnitario { get; set; }
        
        public virtual ICollection<EstoqueKardex> EstoqueKardex { get; set; }

        public virtual EstoqueProduto EstoqueProduto { get; set; }

        public virtual NotaFiscalItem NotaFiscalItem { get; set; }
    }
}
