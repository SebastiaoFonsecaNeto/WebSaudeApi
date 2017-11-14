using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ContaTipoConfiguration : EntityTypeConfiguration<ContaTipo>
    {
        public ContaTipoConfiguration()
        {
            ToTable("conta_tipo");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("nome")
                .IsUnicode(false);

            HasMany(e => e.PacienteConta)
                .WithRequired(e => e.ContaTipo)
                .HasForeignKey(e => e.ContaTipoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PlanoContas)
                .WithRequired(e => e.ContaTipo)
                .HasForeignKey(e => e.ContaTipoId)
                .WillCascadeOnDelete(false);
        }
    }
}