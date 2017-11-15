using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PacienteContaConfiguration : EntityTypeConfiguration<PacienteConta>
    {
        public PacienteContaConfiguration()
        {
            ToTable("paciente_conta");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.PacienteId)
                .IsRequired()
                .HasColumnName("paciente_id");

            Property(c => c.ContaTipoId)
                .IsRequired()
                .HasColumnName("conta_tipo_id");

            Property(c => c.DataHora)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnType("timestamp")
                .HasColumnName("data_hora");

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(c => c.Valor)
                .IsRequired()
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor");

            Property(c => c.NumeroRecibo)
                .HasColumnName("numero_recibo");

            Property(c => c.GuiaTissId)
                .HasColumnName("guia_tiss_id");

            HasMany(e => e.PlanoContas)
                .WithOptional(e => e.PacienteConta)
                .HasForeignKey(e => e.PacienteContaId);
        }
    }
}