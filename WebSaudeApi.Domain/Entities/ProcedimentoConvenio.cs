namespace WebSaude.Domain.Entities
{
    public class ProcedimentoConvenio
    {
        public int Id { get; set; }
        public int ProcedimentoId { get; set; }
        public int ConvenioId { get; set; }
        public decimal Valor { get; set; }
        public virtual Convenio Convenio { get; set; }
        public virtual Procedimento Procedimento { get; set; }
    }
}