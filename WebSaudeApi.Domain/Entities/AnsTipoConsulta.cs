using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebSaude.Domain.Entities
{
    public partial class AnsTipoConsulta
    {
        public AnsTipoConsulta()
        {
            Agenda = new HashSet<Agenda>();
            GuiaTissSpsadt = new HashSet<GuiaTissSpsadt>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int? TermoTiss { get; set; }
        
        public virtual ICollection<Agenda> Agenda { get; set; }
        
        public virtual ICollection<GuiaTissSpsadt> GuiaTissSpsadt { get; set; }
    }
}
