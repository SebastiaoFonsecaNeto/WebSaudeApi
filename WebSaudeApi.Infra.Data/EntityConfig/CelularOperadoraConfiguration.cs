using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class CelularOperadoraConfiguration : EntityTypeConfiguration<CelularOperadora>
    {
        public CelularOperadoraConfiguration()
        {
            ToTable("celular_operadora");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("nome")
                .IsUnicode(false);

            HasMany(e => e.Paciente)
                .WithOptional(e => e.CelularOperadora)
                .HasForeignKey(e => e.CelularOperadoraId);

            HasMany(e => e.Profissional)
                .WithOptional(e => e.CelularOperadora)
                .HasForeignKey(e => e.CelularOperadoraId);
        }
    }
}