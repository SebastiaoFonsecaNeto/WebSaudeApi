using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ImagemTipoConfiguration : EntityTypeConfiguration<ImagemTipo>
    {
        public ImagemTipoConfiguration()
        {
            ToTable("imagem_tipo");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("nome")
                .IsUnicode(false);

            HasMany(e => e.PacienteImagem)
                .WithRequired(e => e.ImagemTipo)
                .HasForeignKey(e => e.ImagemTipoId)
                .WillCascadeOnDelete(false);
        }
    }
}