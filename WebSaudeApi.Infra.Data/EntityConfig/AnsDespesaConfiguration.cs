using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsDespesaConfiguration : EntityTypeConfiguration<AnsDespesa>
    {
        public AnsDespesaConfiguration()
        {
            ToTable("ans_despesa");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(c => c.TermoTiss)
                .HasColumnName("termo_tiss");

            HasMany(e => e.GuiaTissDespesa)
                .WithRequired(e => e.AnsDespesa)
                .HasForeignKey(e => e.AnsDespesaId)
                .WillCascadeOnDelete(false);
        }
    }
}