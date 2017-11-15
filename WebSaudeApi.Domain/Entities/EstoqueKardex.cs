using System;

namespace WebSaude.Domain.Entities
{
    public class EstoqueKardex
    {
        public int Id { get; set; }
        public int EstoqueProdutoId { get; set; }
        public int UnidadeId { get; set; }
        public int EstoqueLoteId { get; set; }
        public int SaldoAtual { get; set; }
        public string Operacao { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public int SaldoPosterior { get; set; }
        public byte[] Data { get; set; }
        public DateTime DataLancamento { get; set; }
        public virtual EstoqueLote EstoqueLote { get; set; }
        public virtual EstoqueProduto EstoqueProduto { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}