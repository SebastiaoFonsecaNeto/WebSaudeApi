using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class EstoqueGrupo
    {
        public EstoqueGrupo()
        {
            EstoqueProduto = new HashSet<EstoqueProduto>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public byte[] Descricao { get; set; }

        public bool Matmed { get; set; }
        
        public virtual ICollection<EstoqueProduto> EstoqueProduto { get; set; }
    }
}
