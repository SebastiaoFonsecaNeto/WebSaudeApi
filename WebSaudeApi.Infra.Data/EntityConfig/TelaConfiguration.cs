using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class TelaConfiguration : EntityTypeConfiguration<Tela>
    {
        public TelaConfiguration()
        {
            ToTable("tela");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("descricao")
                .IsUnicode(false);

            HasMany(e => e.PermissaoItem)
                .WithRequired(e => e.Tela)
                .HasForeignKey(e => e.TelaId)
                .WillCascadeOnDelete(false);
        }
    }
}