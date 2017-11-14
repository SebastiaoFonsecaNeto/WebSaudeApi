using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Pagamento
    {
        public Pagamento()
        {
            ProfissionalPagamento = new HashSet<ProfissionalPagamento>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Porcentagem { get; set; }
        public virtual ICollection<ProfissionalPagamento> ProfissionalPagamento { get; set; }
    }
}