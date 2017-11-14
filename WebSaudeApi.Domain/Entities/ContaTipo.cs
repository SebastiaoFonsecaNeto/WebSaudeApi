using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class ContaTipo
    {
        public ContaTipo()
        {
            PacienteConta = new HashSet<PacienteConta>();
            PlanoContas = new HashSet<PlanoContas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<PacienteConta> PacienteConta { get; set; }
        public virtual ICollection<PlanoContas> PlanoContas { get; set; }
    }
}