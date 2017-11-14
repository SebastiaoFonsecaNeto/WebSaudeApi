using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class CboConfiguration : EntityTypeConfiguration<Cbo>
    {
        public CboConfiguration()
        {
            ToTable("cbo");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Codigo)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("codigo")
                .IsUnicode(false);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(e => e.DiasLimiteAtendimento)
                .HasColumnName("dias_limite_atendimento");

            Property(e => e.DiasLimiteRetorno)
                .HasColumnName("dias_limite_retorno");

            Property(e => e.Clinico)
                .HasColumnName("clinico");

            HasMany(e => e.Agenda)
                .WithOptional(e => e.Cbo)
                .HasForeignKey(e => e.CboId);

            HasMany(e => e.Encaminhamento)
                .WithRequired(e => e.Cbo)
                .HasForeignKey(e => e.CboId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProcedimentoCboConvenio)
                .WithRequired(e => e.Cbo)
                .HasForeignKey(e => e.CboId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.Profissional)
                .WithRequired(e => e.Cbo)
                .HasForeignKey(e => e.CboId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProntoAtendimento)
                .WithOptional(e => e.Cbo)
                .HasForeignKey(e => e.CboId);

            HasMany(e => e.ProntuarioClinico)
                .WithRequired(e => e.Cbo)
                .HasForeignKey(e => e.CboId)
                .WillCascadeOnDelete(false);
        }
    }
}