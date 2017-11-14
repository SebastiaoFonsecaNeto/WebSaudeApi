using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class AnsRegimeInternacao
    {
        public AnsRegimeInternacao()
        {
            GuiaTissInternacao = new HashSet<GuiaTissInternacao>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? TermoTiss { get; set; }
        public virtual ICollection<GuiaTissInternacao> GuiaTissInternacao { get; set; }
    }
}