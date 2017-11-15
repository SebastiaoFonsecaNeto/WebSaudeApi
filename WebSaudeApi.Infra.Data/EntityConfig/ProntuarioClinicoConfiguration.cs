using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProntuarioClinicoConfiguration : EntityTypeConfiguration<ProntuarioClinico>
    {
        public ProntuarioClinicoConfiguration()
        {
            ToTable("prontuario_clinico");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.UnidadeId)
                .IsRequired()
                .HasColumnName("unidade_id");

            Property(c => c.ProfissionalId)
                .IsRequired()
                .HasColumnName("profissional_id");

            Property(c => c.PacienteId)
                .HasColumnName("paciente_id");

            Property(c => c.CboId)
                .HasColumnName("cbo_id");

            Property(e => e.DataHora)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnType("timestamp")
                .HasColumnName("data_hora");

            Property(e => e.Descricao)
                .HasColumnType("text")
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(e => e.PressaoMax)
                .HasColumnName("pressao_max");

            Property(e => e.PressaoMin)
                .HasColumnName("pressao_min");

            Property(e => e.Saturacao)
                .HasColumnName("saturacao");

            Property(e => e.Peso)
                .HasColumnName("peso");

            Property(e => e.Altura)
                .HasColumnName("altura");

            HasMany(e => e.PacienteMatmed)
                .WithRequired(e => e.ProntuarioClinico)
                .HasForeignKey(e => e.ProntuarioClinicoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.PacienteProcedimento)
                .WithRequired(e => e.ProntuarioClinico)
                .HasForeignKey(e => e.ProntuarioClinicoId)
                .WillCascadeOnDelete(false);
        }
    }
}