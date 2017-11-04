using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("conta")]
    public partial class Conta
    {
        public Conta()
        {
            PlanoContas = new HashSet<PlanoContas>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        
        public virtual ICollection<PlanoContas> PlanoContas { get; set; }
    }
}
