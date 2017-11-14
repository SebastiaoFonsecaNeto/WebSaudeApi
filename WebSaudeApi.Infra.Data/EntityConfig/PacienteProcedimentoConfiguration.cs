using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PacienteProcedimentoConfiguration : EntityTypeConfiguration<PacienteProcedimento>
    {
        public PacienteProcedimentoConfiguration()
        {
            ToTable("paciente_procedimento");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.PacienteId)
                .IsRequired()
                .HasColumnName("paciente_id");

            Property(c => c.ProcedimentoId)
                .IsRequired()
                .HasColumnName("procedimento_id");

            Property(c => c.ProntuarioClinicoId)
                .IsRequired()
                .HasColumnName("prontuario_clinico_id");

            Property(c => c.Valor)
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor");

            Property(c => c.Quantidade)
                .HasColumnName("quantidade");

            Property(c => c.Faturado)
                .HasColumnName("faturado");
        }
    }
}