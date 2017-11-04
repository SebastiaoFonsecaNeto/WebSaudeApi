using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("conselho")]
    public partial class Conselho
    {
        public Conselho()
        {
            ProfissionalClinico = new HashSet<ProfissionalClinico>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(7)]
        public string Sigla { get; set; }

        [StringLength(70)]
        public string Descricao { get; set; }
        
        public virtual ICollection<ProfissionalClinico> ProfissionalClinico { get; set; }
    }
}
