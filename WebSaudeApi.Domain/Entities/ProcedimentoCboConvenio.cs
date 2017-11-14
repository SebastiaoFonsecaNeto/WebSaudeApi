namespace WebSaude.Domain.Entities
{
    public class ProcedimentoCboConvenio
    {
        public int Id { get; set; }
        public int ConvenioId { get; set; }
        public int CboId { get; set; }
        public string Codigo { get; set; }
        public virtual Cbo Cbo { get; set; }
        public virtual Convenio Convenio { get; set; }
    }
}