namespace WebSaude.Domain.Entities
{
    public partial class ProfissionalUnidade
    {
        public int Id { get; set; }

        public int ProfissionalId { get; set; }

        public int UnidadeId { get; set; }

        public virtual Profissional Profissional { get; set; }

        public virtual Unidade Unidade { get; set; }
    }
}
