using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class AnsDespesa
    {
        public AnsDespesa()
        {
            GuiaTissDespesa = new HashSet<GuiaTissDespesa>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? TermoTiss { get; set; }
        public virtual ICollection<GuiaTissDespesa> GuiaTissDespesa { get; set; }
    }
}