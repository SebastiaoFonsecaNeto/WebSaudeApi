using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class LogConfiguration : EntityTypeConfiguration<Log>
    {
        public LogConfiguration()
        {
            ToTable("log");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.ProfissionalId)
                .IsRequired()
                .HasColumnName("profissional_id");

            Property(c => c.Data)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnType("timestamp")
                .HasColumnName("data");

            Property(c => c.Tabela)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("tabela")
                .IsUnicode(false);

            Property(c => c.TipoManutencao)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("tipo_manutencao")
                .IsUnicode(false);

            Property(c => c.DadosAnt)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("dados_ant")
                .IsUnicode(false);

            Property(c => c.DadosPost)
                .IsRequired()
                .HasColumnType("text")
                .HasColumnName("dados_post")
                .IsUnicode(false);

            Property(c => c.RegId)
                .IsRequired()
                .HasColumnName("reg_id");
        }
    }
}