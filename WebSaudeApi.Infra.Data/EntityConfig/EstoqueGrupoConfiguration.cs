using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class EstoqueGrupoConfiguration : EntityTypeConfiguration<EstoqueGrupo>
    {
        public EstoqueGrupoConfiguration()
        {
            ToTable("estoque_grupo");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .IsUnicode(false);

            HasMany(e => e.EstoqueProduto)
                .WithRequired(e => e.EstoqueGrupo)
                .HasForeignKey(e => e.GrupoId)
                .WillCascadeOnDelete(false);
        }
    }
}