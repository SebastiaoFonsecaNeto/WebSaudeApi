using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsUnidadeFederacaoConfiguration : EntityTypeConfiguration<AnsUnidadeFederacao>
    {
        public AnsUnidadeFederacaoConfiguration()
        {
            ToTable("ans_unidade_federacao");

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
                .WithRequired(e => e.AnsUnidadeFederacao)
                .HasForeignKey(e => e.AnsUfId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.GuiaTissSpsadt)
                .WithRequired(e => e.AnsUnidadeFederacao)
                .HasForeignKey(e => e.ProfSolicUfConselhoId)
                .WillCascadeOnDelete(false);
        }
    }
}