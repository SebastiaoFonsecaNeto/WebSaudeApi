using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsMotivoEncerramentoObitoConfiguration : EntityTypeConfiguration<AnsMotivoEncerramentoObito>
    {
        public AnsMotivoEncerramentoObitoConfiguration()
        {
            ToTable("ans_motivo_encerramento_obito");

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

            HasMany(e => e.GuiaTissSpsadt)
                .WithRequired(e => e.AnsMotivoEncerramentoObito)
                .HasForeignKey(e => e.MotivoEncerramentoObitoId)
                .WillCascadeOnDelete(false);
        }
    }
}