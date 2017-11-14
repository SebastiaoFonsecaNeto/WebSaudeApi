using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class NotaFiscalConfiguration : EntityTypeConfiguration<NotaFiscal>
    {
        public NotaFiscalConfiguration()
        {
            ToTable("nota_fiscal");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.UnidadeId)
                .IsRequired()
                .HasColumnName("unidade_id");

            Property(c => c.FornecedorId)
                .IsRequired()
                .HasColumnName("fornecedor_id");

            Property(c => c.Numero)
                .HasMaxLength(25)
                .HasColumnName("numero")
                .IsUnicode(false);

            Property(c => c.DataEntrada)
                .HasColumnType("date")
                .HasColumnName("data_entrada");

            Property(c => c.DataEmissao)
                .HasColumnType("date")
                .HasColumnName("data_emissao");

            HasMany(e => e.NotaFiscalItem)
                .WithRequired(e => e.NotaFiscal)
                .HasForeignKey(e => e.NotaFiscalId)
                .WillCascadeOnDelete(false);
        }
    }
}