namespace WebSaude.Domain.Entities
{
    public partial class PermissaoItem
    {
        public int Id { get; set; }

        public int PermissaoId { get; set; }

        public int TelaId { get; set; }

        public bool Incluir { get; set; }

        public bool Excluir { get; set; }

        public bool Alterar { get; set; }

        public virtual Permissao Permissao { get; set; }

        public virtual Tela Tela { get; set; }
    }
}
