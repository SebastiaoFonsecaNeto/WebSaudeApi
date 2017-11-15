using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class EncaminhamentoConfiguration : EntityTypeConfiguration<Encaminhamento>
    {
        public EncaminhamentoConfiguration()
        {
            ToTable("encaminhamento");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.CboId)
                .IsRequired()
                .HasColumnName("cbo_id");

            Property(c => c.ProfissionalId)
                .IsRequired()
                .HasColumnName("profissional_id");

            Property(c => c.PacienteId)
                .IsRequired()
                .HasColumnName("paciente_id");

            Property(c => c.DataHora)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnType("timestamp")
                .HasColumnName("data_hora");

            Property(c => c.Descricao)
                .HasColumnType("text")
                .HasColumnName("descricao")
                .IsUnicode(false);
        }
    }
}