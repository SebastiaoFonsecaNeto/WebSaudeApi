using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class EstoqueKardexConfiguration : EntityTypeConfiguration<EstoqueKardex>
    {
        public EstoqueKardexConfiguration()
        {
            ToTable("estoque_kardex");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.EstoqueProdutoId)
                .IsRequired()
                .HasColumnName("estoque_produto_id");

            Property(c => c.UnidadeId)
                .IsRequired()
                .HasColumnName("unidade_id");

            Property(c => c.EstoqueLoteId)
                .IsRequired()
                .HasColumnName("estoque_lote_id");

            Property(c => c.SaldoAtual)
                .IsRequired()
                .HasColumnName("saldo_atual");

            Property(c => c.Operacao)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("operacao")
                .IsUnicode(false);

            Property(c => c.Tipo)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("tipo")
                .IsUnicode(false);

            Property(c => c.Quantidade)
                .IsRequired()
                .HasColumnName("quantidade");

            Property(c => c.SaldoPosterior)
                .IsRequired()
                .HasColumnName("saldo_posterior");

            Property(c => c.Data)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("data");

            Property(c => c.DataLancamento)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("data_lancamento");
        }
    }
}