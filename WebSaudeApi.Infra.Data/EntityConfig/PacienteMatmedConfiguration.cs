using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PacienteMatmedConfiguration : EntityTypeConfiguration<PacienteMatmed>
    {
        public PacienteMatmedConfiguration()
        {
            ToTable("paciente_matmed");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.PacienteId)
                .IsRequired()
                .HasColumnName("paciente_id");

            Property(c => c.EstoqueId)
                .IsRequired()
                .HasColumnName("estoque_id");

            Property(c => c.ProntuarioClinicoId)
                .IsRequired()
                .HasColumnName("prontuario_clinico_id");

            Property(c => c.NumeroLote)
                .HasMaxLength(25)
                .HasColumnName("numero_lote")
                .IsUnicode(false);

            Property(c => c.DataVencimento)
                .HasColumnType("date")
                .HasColumnName("data_vencimento");

            Property(c => c.Valor)
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor");

            Property(c => c.Quantidade)
                .HasColumnName("quantidade");

            Property(c => c.Status)
                .HasColumnName("status");

            Property(c => c.DataHora)
                .IsRequired()
                .HasColumnType("datetime")
                .HasColumnName("data_hora");
        }
    }
}