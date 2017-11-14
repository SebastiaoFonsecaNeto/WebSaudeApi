using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class EstoqueGrupo
    {
        public EstoqueGrupo()
        {
            EstoqueProduto = new HashSet<EstoqueProduto>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Matmed { get; set; }
        public virtual ICollection<EstoqueProduto> EstoqueProduto { get; set; }
    }
}