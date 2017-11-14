using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class AnsTipoConsulta
    {
        public AnsTipoConsulta()
        {
            Agenda = new HashSet<Agenda>();
            GuiaTissSpsadt = new HashSet<GuiaTissSpsadt>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? TermoTiss { get; set; }
        public virtual ICollection<Agenda> Agenda { get; set; }
        public virtual ICollection<GuiaTissSpsadt> GuiaTissSpsadt { get; set; }
    }
}