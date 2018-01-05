using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AgendaConfiguration : EntityTypeConfiguration<Agenda>
    {
        public AgendaConfiguration()
        {
            ToTable("agenda");

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

            Property(c => c.ConvenioId)
                .HasColumnName("convenio_id");

            Property(c => c.CboId)
                .HasColumnName("cbo_id");

            Property(e => e.Data)
                .IsRequired()
                .HasColumnType("date")
                .HasColumnName("data");

            Property(e => e.Hora)
                .IsRequired()
                .HasColumnName("hora");

            Property(e => e.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(250)
                .IsUnicode(false);

            Property(e => e.Contato)
                .HasColumnName("contato")
                .HasMaxLength(11)
                .IsUnicode(false);

            Property(e => e.Contato2)
                .HasColumnName("contato2")
                .HasMaxLength(11)
                .IsUnicode(false);

            Property(e => e.Observacao)
                .HasColumnName("observacao")
                .HasMaxLength(250)
                .IsUnicode(false);

            Property(e => e.Falta)
                .IsRequired()
                .HasColumnName("falta");

            Property(e => e.Bloqueado)
                .IsRequired()
                .HasColumnName("bloqueado");

            Property(e => e.Faturado)
                .IsRequired()
                .HasColumnName("faturado");

            Property(e => e.AnsConsultaId)
                .IsRequired()
                .HasColumnName("ans_consulta_id");

            Property(e => e.AnsAcidenteId)
                .IsRequired()
                .HasColumnName("ans_acidente_id");
            
            HasOptional(e => e.Cbo)
                .WithMany()
                .HasForeignKey(e => e.CboId);
        }
    }
}