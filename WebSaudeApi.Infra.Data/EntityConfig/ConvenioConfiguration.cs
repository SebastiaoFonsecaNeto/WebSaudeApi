using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ConvenioConfiguration : EntityTypeConfiguration<Convenio>
    {
        public ConvenioConfiguration()
        {
            ToTable("convenio");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.RazaoSocial)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("razao_social")
                .IsUnicode(false);

            Property(c => c.NomeFantasia)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("nome_fantasia")
                .IsUnicode(false);

            Property(c => c.RegistroAns)
                .IsRequired()
                .HasColumnName("registro_ans");

            Property(c => c.CodigoOperadora)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("codigo_operadora")
                .IsUnicode(false);

            Property(c => c.LoginOperadora)
                .HasMaxLength(50)
                .HasColumnName("login_operadora")
                .IsUnicode(false);

            Property(c => c.SenhaOperadora)
                .HasMaxLength(30)
                .HasColumnName("senha_operadora")
                .IsUnicode(false);

            Property(c => c.PercentualMatmed)
                .HasColumnName("percentual_matmed");

            Property(c => c.PercentualHonorario)
                .HasColumnName("percentual_honorario");

            HasMany(e => e.Agenda)
                .WithOptional(e => e.Convenio)
                .HasForeignKey(e => e.ConvenioId);

            HasMany(e => e.AgendaAparelho)
                .WithOptional(e => e.Convenio)
                .HasForeignKey(e => e.ConvenioId);

            HasMany(e => e.PacienteConvenio)
                .WithRequired(e => e.Convenio)
                .HasForeignKey(e => e.ConveniosId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProcedimentoCboConvenio)
                .WithRequired(e => e.Convenio)
                .HasForeignKey(e => e.ConvenioId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProcedimentoConvenio)
                .WithRequired(e => e.Convenio)
                .HasForeignKey(e => e.ConvenioId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ProntoAtendimento)
                .WithOptional(e => e.Convenio)
                .HasForeignKey(e => e.ConvenioId);
        }
    }
}