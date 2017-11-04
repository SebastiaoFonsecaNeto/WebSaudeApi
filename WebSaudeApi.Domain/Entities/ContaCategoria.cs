using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class ContaCategoria
    {
        public ContaCategoria()
        {
            PlanoContas = new HashSet<PlanoContas>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }
        
        public virtual ICollection<PlanoContas> PlanoContas { get; set; }
    }
}
