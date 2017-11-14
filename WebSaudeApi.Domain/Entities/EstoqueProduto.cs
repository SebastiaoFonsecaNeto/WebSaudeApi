using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class EstoqueProduto
    {
        public EstoqueProduto()
        {
            EstoqueKardex = new HashSet<EstoqueKardex>();
            EstoqueLote = new HashSet<EstoqueLote>();
            NotaFiscalItem = new HashSet<NotaFiscalItem>();
            PacienteMatmed = new HashSet<PacienteMatmed>();
            ProcedimentoMatmed = new HashSet<ProcedimentoMatmed>();
        }

        public int Id { get; set; }
        public int UnidadeId { get; set; }
        public int GrupoId { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeMinima { get; set; }
        public decimal Valor { get; set; }
        public int Apresentacao { get; set; }
        public bool Ativo { get; set; }
        public string CodigoTuss { get; set; }
        public bool Controlado { get; set; }
        public virtual EstoqueGrupo EstoqueGrupo { get; set; }
        public virtual ICollection<EstoqueKardex> EstoqueKardex { get; set; }
        public virtual ICollection<EstoqueLote> EstoqueLote { get; set; }
        public virtual Unidade Unidade { get; set; }
        public virtual ICollection<NotaFiscalItem> NotaFiscalItem { get; set; }
        public virtual ICollection<PacienteMatmed> PacienteMatmed { get; set; }
        public virtual ICollection<ProcedimentoMatmed> ProcedimentoMatmed { get; set; }
    }
}