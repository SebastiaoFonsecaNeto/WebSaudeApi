using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsRegimeInternacaoConfiguration : EntityTypeConfiguration<AnsRegimeInternacao>
    {
        public AnsRegimeInternacaoConfiguration()
        {
            ToTable("ans_regime_internacao");

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

            HasMany(e => e.GuiaTissInternacao)
                .WithRequired(e => e.AnsRegimeInternacao)
                .HasForeignKey(e => e.AnsRegimeInternacaoId)
                .WillCascadeOnDelete(false);
        }
    }
}