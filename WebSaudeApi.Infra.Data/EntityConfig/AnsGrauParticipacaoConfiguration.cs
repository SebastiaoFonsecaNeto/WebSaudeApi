using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsGrauParticipacaoConfiguration : EntityTypeConfiguration<AnsGrauParticipacao>
    {
        public AnsGrauParticipacaoConfiguration()
        {
            ToTable("ans_grau_participacao");

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
                .WithRequired(e => e.AnsGrauParticipacao)
                .HasForeignKey(e => e.AnsGrauParticipacaoId)
                .WillCascadeOnDelete(false);
        }
    }
}