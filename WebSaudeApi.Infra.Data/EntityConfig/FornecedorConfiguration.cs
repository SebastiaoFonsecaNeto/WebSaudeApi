using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            ToTable("fornecedor");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome")
                .IsUnicode(false);

            Property(c => c.Documento)
                .HasMaxLength(14)
                .HasColumnName("documento")
                .IsUnicode(false);

            Property(c => c.Telefone)
                .HasMaxLength(11)
                .HasColumnName("telefone")
                .IsUnicode(false);

            Property(c => c.Email)
                .HasMaxLength(150)
                .HasColumnName("email")
                .IsUnicode(false);

            Property(c => c.Ativo)
                .IsRequired()
                .HasColumnName("ativo");

            HasMany(e => e.NotaFiscal)
                .WithRequired(e => e.Fornecedor)
                .HasForeignKey(e => e.FornecedorId)
                .WillCascadeOnDelete(false);
        }
    }
}