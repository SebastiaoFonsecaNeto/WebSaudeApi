using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ContaCategoriaConfiguration : EntityTypeConfiguration<ContaCategoria>
    {
        public ContaCategoriaConfiguration()
        {
            ToTable("conta_categoria");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .IsUnicode(false);

            HasMany(e => e.PlanoContas)
                .WithRequired(e => e.ContaCategoria)
                .HasForeignKey(e => e.ContaCategoriaId)
                .WillCascadeOnDelete(false);
        }
    }
}