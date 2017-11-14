using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PagamentoConfiguration : EntityTypeConfiguration<Pagamento>
    {
        public PagamentoConfiguration()
        {
            ToTable("pagamento");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(c => c.Porcentagem)
                .IsRequired()
                .HasColumnName("porcentagem");

            HasMany(e => e.ProfissionalPagamento)
                .WithRequired(e => e.Pagamento)
                .HasForeignKey(e => e.PagamentoId)
                .WillCascadeOnDelete(false);
        }
    }
}