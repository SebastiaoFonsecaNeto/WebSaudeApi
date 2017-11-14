using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Conselho
    {
        public Conselho()
        {
            ProfissionalClinico = new HashSet<ProfissionalClinico>();
        }

        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ProfissionalClinico> ProfissionalClinico { get; set; }
    }
}