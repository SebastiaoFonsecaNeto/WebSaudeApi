using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class ContaCategoria
    {
        public ContaCategoria()
        {
            PlanoContas = new HashSet<PlanoContas>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PlanoContas> PlanoContas { get; set; }
    }
}