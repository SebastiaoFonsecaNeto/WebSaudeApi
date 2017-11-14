using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public partial class Tela
    {
        public Tela()
        {
            PermissaoItem = new HashSet<PermissaoItem>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PermissaoItem> PermissaoItem { get; set; }
    }
}