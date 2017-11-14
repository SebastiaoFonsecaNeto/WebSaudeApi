using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsTipoInternacaoConfiguration : EntityTypeConfiguration<AnsTipoInternacao>
    {
        public AnsTipoInternacaoConfiguration()
        {
            ToTable("ans_tipo_internacao");

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
                .WithRequired(e => e.AnsTipoInternacao)
                .HasForeignKey(e => e.AnsTipoInternacaoId)
                .WillCascadeOnDelete(false);
        }
    }
}