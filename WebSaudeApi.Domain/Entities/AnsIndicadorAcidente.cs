using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class AnsIndicadorAcidente
    {
        public AnsIndicadorAcidente()
        {
            Agenda = new HashSet<Agenda>();
            GuiaTissInternacao = new HashSet<GuiaTissInternacao>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? TermoTiss { get; set; }
        public virtual ICollection<Agenda> Agenda { get; set; }
        public virtual ICollection<GuiaTissInternacao> GuiaTissInternacao { get; set; }
    }
}