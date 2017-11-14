using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class EstoqueProdutoConfiguration : EntityTypeConfiguration<EstoqueProduto>
    {
        public EstoqueProdutoConfiguration()
        {
            ToTable("estoque_produto");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.UnidadeId)
                .IsRequired()
                .HasColumnName("unidade_id");

            Property(c => c.GrupoId)
                .IsRequired()
                .HasColumnName("grupo_id");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(c => c.QuantidadeMinima)
                .IsRequired()
                .HasColumnName("quantidade_minima");

            Property(c => c.Valor)
                .IsRequired()
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor");

            Property(c => c.Apresentacao)
                .IsRequired()
                .HasColumnName("apresentacao");

            Property(c => c.Ativo)
                .IsRequired()
                .HasColumnName("ativo");

            Property(c => c.CodigoTuss)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnName("codigo_tuss")
                .IsUnicode(false);

            Property(c => c.Controlado)
                .IsRequired()
                .HasColumnName("controlado");

            HasMany(e => e.EstoqueKardex)
                .WithRequired(e => e.EstoqueProduto)
                .HasForeignKey(e => e.EstoqueProdutoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.EstoqueLote)
                .WithRequired(e => e.EstoqueProduto)
                .HasForeignKey(e => e.EstoqueProdutoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.NotaFiscalItem)
                .WithRequired(e => e.EstoqueProduto)
                .HasForeignKey(e => e.EstoqueProdutoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteMatmed)
                .WithRequired(e => e.EstoqueProduto)
                .HasForeignKey(e => e.EstoqueId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProcedimentoMatmed)
                .WithRequired(e => e.EstoqueProduto)
                .HasForeignKey(e => e.EstoqueId)
                .WillCascadeOnDelete(false);
        }
    }
}