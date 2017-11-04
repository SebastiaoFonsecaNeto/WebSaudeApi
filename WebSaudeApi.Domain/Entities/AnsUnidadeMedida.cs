using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class AnsUnidadeMedida
    {
        public AnsUnidadeMedida()
        {
            GuiaTissDespesa = new HashSet<GuiaTissDespesa>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int? TermoTiss { get; set; }
        
        public virtual ICollection<GuiaTissDespesa> GuiaTissDespesa { get; set; }
    }
}
