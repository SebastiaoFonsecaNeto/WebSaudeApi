using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PermissaoConfiguration : EntityTypeConfiguration<Permissao>
    {
        public PermissaoConfiguration()
        {
            ToTable("permissao");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("descricao")
                .IsUnicode(false);

            HasMany(e => e.PermissaoItem)
                .WithRequired(e => e.Permissao)
                .HasForeignKey(e => e.PermissaoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProfissionalAcesso)
                .WithRequired(e => e.Permissao)
                .HasForeignKey(e => e.PermissaoId)
                .WillCascadeOnDelete(false);
        }
    }
}