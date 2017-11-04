using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class AnsTecnica
    {
        public AnsTecnica()
        {
            GuiaTissProcedimento = new HashSet<GuiaTissProcedimento>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int? TermoTiss { get; set; }
        
        public virtual ICollection<GuiaTissProcedimento> GuiaTissProcedimento { get; set; }
    }
}
