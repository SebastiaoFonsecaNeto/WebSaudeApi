using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AgendaAparelhoConfiguration : EntityTypeConfiguration<AgendaAparelho>
    {
        public AgendaAparelhoConfiguration()
        {
            ToTable("agenda_aparelho");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.UnidadeId)
                .IsRequired()
                .HasColumnName("unidade_id");

            Property(c => c.AparelhoId)
                .IsRequired()
                .HasColumnName("aparelho_id");

            Property(c => c.PacienteId)
                .HasColumnName("paciente_id");

            Property(c => c.ConvenioId)
                .HasColumnName("convenio_id");

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
        }
    }
}