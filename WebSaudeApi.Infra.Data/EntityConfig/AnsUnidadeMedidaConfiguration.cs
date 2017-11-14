using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsUnidadeMedidaConfiguration : EntityTypeConfiguration<AnsUnidadeMedida>
    {
        public AnsUnidadeMedidaConfiguration()
        {
            ToTable("ans_unidade_medida");

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
                .WithRequired(e => e.AnsUnidadeMedida)
                .HasForeignKey(e => e.AnsUnidadeMedidaId)
                .WillCascadeOnDelete(false);
        }
    }
}