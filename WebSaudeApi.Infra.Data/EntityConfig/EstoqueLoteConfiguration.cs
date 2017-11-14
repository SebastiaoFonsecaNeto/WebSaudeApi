using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class EstoqueLoteConfiguration : EntityTypeConfiguration<EstoqueLote>
    {
        public EstoqueLoteConfiguration()
        {
            ToTable("estoque_lote");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.EstoqueProdutoId)
                .IsRequired()
                .HasColumnName("estoque_produto_id");

            Property(c => c.NotaFiscalItemId)
                .IsRequired()
                .HasColumnName("nota_fiscal_item_id");

            Property(c => c.NumeroLote)
                .HasMaxLength(30)
                .HasColumnName("numero_lote")
                .IsUnicode(false);

            Property(c => c.DataVencimento)
                .HasColumnType("date")
                .HasColumnName("data_vencimento");

            Property(c => c.Quantidade)
                .HasColumnName("quantidade");

            Property(c => c.ValorUnitario)
                .HasPrecision(19, 4)
                .HasColumnType("money")
                .HasColumnName("valor_unitario");

            HasMany(e => e.EstoqueKardex)
                .WithRequired(e => e.EstoqueLote)
                .HasForeignKey(e => e.EstoqueLoteId)
                .WillCascadeOnDelete(false);
        }
    }
}