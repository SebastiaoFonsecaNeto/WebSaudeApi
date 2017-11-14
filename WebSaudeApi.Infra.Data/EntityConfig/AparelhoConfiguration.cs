using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AparelhoConfiguration : EntityTypeConfiguration<Aparelho>
    {
        public AparelhoConfiguration()
        {
            ToTable("aparelho");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(e => e.LimiteHorario)
                .HasColumnName("limite_horario");

            Property(e => e.Ativo)
                .HasColumnName("ativo");

            HasMany(e => e.AgendaAparelho)
                .WithRequired(e => e.Aparelho)
                .HasForeignKey(e => e.AparelhoId)
                .WillCascadeOnDelete(false);
        }
    }
}