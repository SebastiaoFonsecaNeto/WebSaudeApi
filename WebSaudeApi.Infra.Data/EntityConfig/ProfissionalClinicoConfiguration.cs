using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProfissionalClinicoConfiguration : EntityTypeConfiguration<ProfissionalClinico>
    {
        public ProfissionalClinicoConfiguration()
        {
            ToTable("profissional_clinico");

            HasKey(c => c.ProfissionalId);

            Property(c => c.ProfissionalId)
                .IsRequired()
                .HasColumnName("profissional_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.ConselhoId)
                .IsRequired()
                .HasColumnName("conselho_id");

            Property(c => c.NumeroConselho)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("numero_conselho")
                .IsUnicode(false);

            Property(c => c.UfConselho)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnName("uf_conselho")
                .IsUnicode(false);

            Property(c => c.ValorConsulta)
                .HasColumnType("money")
                .HasPrecision(19, 4)
                .HasColumnName("valor_consulta");

            Property(c => c.CodigoConsulta)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnName("codigo_consulta")
                .IsUnicode(false);

            Property(c => c.AtendeSeg)
                .HasColumnName("atende_seg");

            Property(c => c.AtendeTer)
                .HasColumnName("atende_ter");

            Property(c => c.AtendeQua)
                .HasColumnName("atende_qua");

            Property(c => c.AtendeQui)
                .HasColumnName("atende_qui");

            Property(c => c.AtendeSex)
                .HasColumnName("atende_sex");

            Property(c => c.AtendeSab)
                .HasColumnName("atende_sab");

            Property(c => c.HoraInicio)
                .HasColumnName("hora_inicio");

            Property(c => c.HoraFim)
                .HasColumnName("hora_fim");

            Property(c => c.IntervaloConsulta)
                .HasColumnName("intervalo_consulta");

            Property(c => c.MaximoConsulta)
                .HasColumnName("maximo_consulta");

            Property(c => c.MaximoEncaixe)
                .HasColumnName("maximo_encaixe");

            HasOptional(e => e.Profissional)
                .WithRequired(e => e.ProfissionalClinico);
        }
    }
}