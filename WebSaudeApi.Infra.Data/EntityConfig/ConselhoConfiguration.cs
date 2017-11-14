using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ConselhoConfiguration : EntityTypeConfiguration<Conselho>
    {
        public ConselhoConfiguration()
        {
            ToTable("conselho");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Sigla)
                .IsRequired()
                .HasMaxLength(7)
                .HasColumnName("sigla")
                .IsUnicode(false);

            Property(c => c.Descricao)
                .HasMaxLength(70)
                .HasColumnName("descricao")
                .IsUnicode(false);

            HasMany(e => e.ProfissionalClinico)
                .WithRequired(e => e.Conselho)
                .HasForeignKey(e => e.ConselhoId)
                .WillCascadeOnDelete(false);
        }
    }
}