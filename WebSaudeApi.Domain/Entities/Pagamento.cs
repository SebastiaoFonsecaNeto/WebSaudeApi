using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("pagamento")]
    public partial class Pagamento
    {
        public Pagamento()
        {
            ProfissionalPagamento = new HashSet<ProfissionalPagamento>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }

        public bool Porcentagem { get; set; }
        
        public virtual ICollection<ProfissionalPagamento> ProfissionalPagamento { get; set; }
    }
}
