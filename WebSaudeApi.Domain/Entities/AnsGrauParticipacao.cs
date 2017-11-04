using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class AnsGrauParticipacao
    {
        public AnsGrauParticipacao()
        {
            GuiaTissProfissional = new HashSet<GuiaTissProfissional>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int? TermoTiss { get; set; }
        
        public virtual ICollection<GuiaTissProfissional> GuiaTissProfissional { get; set; }
    }
}
