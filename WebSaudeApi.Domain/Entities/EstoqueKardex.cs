using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    public partial class EstoqueKardex
    {
        public int Id { get; set; }

        public int EstoqueProdutoId { get; set; }

        public int UnidadeId { get; set; }

        public int EstoqueLoteId { get; set; }

        public int SaldoAtual { get; set; }

        [Required]
        [StringLength(250)]
        public string Operacao { get; set; }

        [Required]
        [StringLength(10)]
        public string Tipo { get; set; }

        public int Quantidade { get; set; }

        public int SaldoPosterior { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Data { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataLancamento { get; set; }

        public virtual EstoqueLote EstoqueLote { get; set; }

        public virtual EstoqueProduto EstoqueProduto { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}
