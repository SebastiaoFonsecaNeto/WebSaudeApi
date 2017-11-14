using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class PacienteConvenioConfiguration : EntityTypeConfiguration<PacienteConvenio>
    {
        public PacienteConvenioConfiguration()
        {
            ToTable("paciente_convenio");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.ConveniosId)
                .IsRequired()
                .HasColumnName("convenios_id");

            Property(c => c.PacienteId)
                .IsRequired()
                .HasColumnName("paciente_id");

            Property(c => c.NumeroPlano)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("numero_plano")
                .IsUnicode(false);

            Property(c => c.DescricaoPlano)
                .HasMaxLength(150)
                .HasColumnName("descricao_plano")
                .IsUnicode(false);

            Property(c => c.ValidadePlano)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("validade_plano");
        }
    }
}