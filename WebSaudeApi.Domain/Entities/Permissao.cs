using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Permissao
    {
        public Permissao()
        {
            PermissaoItem = new HashSet<PermissaoItem>();
            ProfissionalAcesso = new HashSet<ProfissionalAcesso>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PermissaoItem> PermissaoItem { get; set; }
        public virtual ICollection<ProfissionalAcesso> ProfissionalAcesso { get; set; }
    }
}