using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class AnsUnidadeFederacao
    {
        public AnsUnidadeFederacao()
        {
            GuiaTissProfissional = new HashSet<GuiaTissProfissional>();
            GuiaTissSpsadt = new HashSet<GuiaTissSpsadt>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? TermoTiss { get; set; }
        public virtual ICollection<GuiaTissProfissional> GuiaTissProfissional { get; set; }
        public virtual ICollection<GuiaTissSpsadt> GuiaTissSpsadt { get; set; }
    }
}