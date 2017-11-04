using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class AnsUnidadeFederacao
    {
        public AnsUnidadeFederacao()
        {
            GuiaTissProfissional = new HashSet<GuiaTissProfissional>();
            GuiaTissSpsadt = new HashSet<GuiaTissSpsadt>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int? TermoTiss { get; set; }
        
        public virtual ICollection<GuiaTissProfissional> GuiaTissProfissional { get; set; }
        
        public virtual ICollection<GuiaTissSpsadt> GuiaTissSpsadt { get; set; }
    }
}
