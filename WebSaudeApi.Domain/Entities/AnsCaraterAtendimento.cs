using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class AnsCaraterAtendimento
    {
        public AnsCaraterAtendimento()
        {
            GuiaTissInternacao = new HashSet<GuiaTissInternacao>();
            GuiaTissSpsadt = new HashSet<GuiaTissSpsadt>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? TermoTiss { get; set; }
        public virtual ICollection<GuiaTissInternacao> GuiaTissInternacao { get; set; }
        public virtual ICollection<GuiaTissSpsadt> GuiaTissSpsadt { get; set; }
    }
}