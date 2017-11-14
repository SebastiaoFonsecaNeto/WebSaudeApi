using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ContaConfiguration : EntityTypeConfiguration<Conta>
    {
        public ContaConfiguration()
        {
            ToTable("conta");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nome")
                .IsUnicode(false);

            HasMany(e => e.PlanoContas)
                .WithRequired(e => e.Conta)
                .HasForeignKey(e => e.ContaId)
                .WillCascadeOnDelete(false);
        }
    }
}