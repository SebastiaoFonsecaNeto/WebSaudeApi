using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class ContaTipo
    {
        public ContaTipo()
        {
            PacienteConta = new HashSet<PacienteConta>();
            PlanoContas = new HashSet<PlanoContas>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Nome { get; set; }
        
        public virtual ICollection<PacienteConta> PacienteConta { get; set; }
        
        public virtual ICollection<PlanoContas> PlanoContas { get; set; }
    }
}
