using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PacienteImagemConfiguration : EntityTypeConfiguration<PacienteImagem>
    {
        public PacienteImagemConfiguration()
        {
            ToTable("paciente_imagem");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.PacienteId)
                .IsRequired()
                .HasColumnName("paciente_id");

            Property(c => c.ImagemTipoId)
                .IsRequired()
                .HasColumnName("imagem_tipo_id");

            Property(c => c.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(c => c.Imagem)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("imagem")
                .IsUnicode(false);
        }
    }
}