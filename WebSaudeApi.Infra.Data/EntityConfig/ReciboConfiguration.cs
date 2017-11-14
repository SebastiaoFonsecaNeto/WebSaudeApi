using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ReciboConfiguration : EntityTypeConfiguration<Recibo>
    {
        public ReciboConfiguration()
        {
            ToTable("recibo");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("descricao")
                .IsUnicode(false);

            HasMany(e => e.ProfissionalPagamento)
                .WithRequired(e => e.Recibo)
                .HasForeignKey(e => e.ReciboId)
                .WillCascadeOnDelete(false);
        }
    }
}