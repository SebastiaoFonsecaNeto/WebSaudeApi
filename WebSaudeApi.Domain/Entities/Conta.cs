using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Conta
    {
        public Conta()
        {
            PlanoContas = new HashSet<PlanoContas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<PlanoContas> PlanoContas { get; set; }
    }
}