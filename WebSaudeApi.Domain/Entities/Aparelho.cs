using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Aparelho
    {
        public Aparelho()
        {
            AgendaAparelho = new HashSet<AgendaAparelho>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? LimiteHorario { get; set; }
        public bool? Ativo { get; set; }
        public virtual ICollection<AgendaAparelho> AgendaAparelho { get; set; }
    }
}