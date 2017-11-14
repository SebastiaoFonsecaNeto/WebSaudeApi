using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsTipoFaturamentoConfiguration : EntityTypeConfiguration<AnsTipoFaturamento>
    {
        public AnsTipoFaturamentoConfiguration()
        {
            ToTable("ans_tipo_faturamento");

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
                .WithRequired(e => e.AnsTipoFaturamento)
                .HasForeignKey(e => e.AnsTipoFaturamentoId)
                .WillCascadeOnDelete(false);
        }
    }
}