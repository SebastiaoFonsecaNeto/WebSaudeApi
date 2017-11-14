using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PermissaoItemConfiguration : EntityTypeConfiguration<PermissaoItem>
    {
        public PermissaoItemConfiguration()
        {
            ToTable("permissao_item");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.PermissaoId)
                .IsRequired()
                .HasColumnName("permissao_id");

            Property(c => c.TelaId)
                .IsRequired()
                .HasColumnName("tela_id");

            Property(c => c.Incluir)
                .IsRequired()
                .HasColumnName("incluir");

            Property(c => c.Excluir)
                .IsRequired()
                .HasColumnName("excluir");

            Property(c => c.Alterar)
                .IsRequired()
                .HasColumnName("alterar");
        }
    }
}