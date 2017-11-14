using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PacienteProntuarioUnidadeConfiguration : EntityTypeConfiguration<PacienteProntuarioUnidade>
    {
        public PacienteProntuarioUnidadeConfiguration()
        {
            ToTable("paciente_prontuario_unidade");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.PacienteId)
                .IsRequired()
                .HasColumnName("paciente_id");

            Property(c => c.UnidadeId)
                .IsRequired()
                .HasColumnName("unidade_id");

            Property(c => c.Numero)
                .IsRequired()
                .HasColumnName("numero");
        }
    }
}