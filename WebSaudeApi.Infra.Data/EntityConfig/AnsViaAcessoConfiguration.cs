using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsViaAcessoConfiguration : EntityTypeConfiguration<AnsViaAcesso>
    {
        public AnsViaAcessoConfiguration()
        {
            ToTable("ans_via_acesso");

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

            HasMany(e => e.GuiaTissProcedimento)
                .WithRequired(e => e.AnsViaAcesso)
                .HasForeignKey(e => e.AnsViaId)
                .WillCascadeOnDelete(false);
        }
    }
}