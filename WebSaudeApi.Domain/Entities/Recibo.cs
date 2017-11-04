using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("recibo")]
    public partial class Recibo
    {
        
        public Recibo()
        {
            ProfissionalPagamento = new HashSet<ProfissionalPagamento>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }

        
        public virtual ICollection<ProfissionalPagamento> ProfissionalPagamento { get; set; }
    }
}
