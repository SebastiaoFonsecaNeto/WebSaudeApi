using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsMotivoEncerramentoConfiguration : EntityTypeConfiguration<AnsMotivoEncerramento>
    {
        public AnsMotivoEncerramentoConfiguration()
        {
            ToTable("ans_motivo_encerramento");

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
                .WithRequired(e => e.AnsMotivoEncerramento)
                .HasForeignKey(e => e.AnsMotivoEncerramentoId)
                .WillCascadeOnDelete(false);
        }
    }
}