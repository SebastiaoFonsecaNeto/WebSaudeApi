using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class AnsRegimeInternacao
    {
        public AnsRegimeInternacao()
        {
            GuiaTissInternacao = new HashSet<GuiaTissInternacao>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int? TermoTiss { get; set; }
        
        public virtual ICollection<GuiaTissInternacao> GuiaTissInternacao { get; set; }
    }
}
