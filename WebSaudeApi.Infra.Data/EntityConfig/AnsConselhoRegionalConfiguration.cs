using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsConselhoRegionalConfiguration : EntityTypeConfiguration<AnsConselhoRegional>
    {
        public AnsConselhoRegionalConfiguration()
        {
            ToTable("ans_conselho_regional");

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

            HasMany(e => e.GuiaTissProfissional)
                .WithRequired(e => e.AnsConselhoRegional)
                .HasForeignKey(e => e.AnsConselhoId)
                .WillCascadeOnDelete(false);
        }
    }
}