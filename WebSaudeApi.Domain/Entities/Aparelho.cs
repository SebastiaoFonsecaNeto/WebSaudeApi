using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("aparelho")]
    public partial class Aparelho
    {
        public Aparelho()
        {
            AgendaAparelho = new HashSet<AgendaAparelho>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Descricao { get; set; }

        public int? LimiteHorario { get; set; }

        public bool? Ativo { get; set; }

        public virtual ICollection<AgendaAparelho> AgendaAparelho { get; set; }
    }
}
