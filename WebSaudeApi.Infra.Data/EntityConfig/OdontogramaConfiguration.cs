using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class OdontogramaConfiguration : EntityTypeConfiguration<Odontograma>
    {
        public OdontogramaConfiguration()
        {
            ToTable("odontograma");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.PacienteId)
                .IsRequired()
                .HasColumnName("paciente_id");

            Property(c => c.NumeroDente)
                .IsRequired()
                .HasColumnName("numero_dente");

            Property(c => c.Face)
                .HasColumnName("face");

            Property(c => c.Descricao)
                .HasColumnType("text")
                .HasColumnName("descricao");

            Property(c => c.Status)
                .HasColumnName("status");
        }
    }
}