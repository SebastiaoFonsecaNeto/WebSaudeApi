using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("tela")]
    public partial class Tela
    {
        public Tela()
        {
            PermissaoItem = new HashSet<PermissaoItem>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Descricao { get; set; }
        
        public virtual ICollection<PermissaoItem> PermissaoItem { get; set; }
    }
}
