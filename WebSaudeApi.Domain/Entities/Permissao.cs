using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSaude.Domain.Entities
{
    [Table("permissao")]
    public partial class Permissao
    {
        
        public Permissao()
        {
            PermissaoItem = new HashSet<PermissaoItem>();
            Profissional = new HashSet<Profissional>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Descricao { get; set; }

        
        public virtual ICollection<PermissaoItem> PermissaoItem { get; set; }

        
        public virtual ICollection<Profissional> Profissional { get; set; }
    }
}
