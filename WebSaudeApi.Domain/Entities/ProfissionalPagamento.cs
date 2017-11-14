namespace WebSaude.Domain.Entities
{
    public class ProfissionalPagamento
    {
        public int ProfissionalId { get; set; }
        public int PagamentoId { get; set; }
        public int ReciboId { get; set; }
        public decimal? Valor { get; set; }
        public virtual Pagamento Pagamento { get; set; }
        public virtual Profissional Profissional { get; set; }
        public virtual Recibo Recibo { get; set; }
    }
}