using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProfissionalAcessoConfiguration : EntityTypeConfiguration<ProfissionalAcesso>
    {
        public ProfissionalAcessoConfiguration()
        {
            ToTable("profissional_acesso");

            HasKey(c => c.ProfissionalId);

            Property(c => c.ProfissionalId)
                .IsRequired()
                .HasColumnName("profissional_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.PermissaoId)
                .IsRequired()
                .HasColumnName("permissao_id");

            Property(c => c.Senha)
                .HasMaxLength(250)
                .HasColumnName("senha")
                .IsUnicode(false);

            Property(c => c.HoraInicio)
                .HasColumnName("hora_inicio");

            Property(c => c.HoraFim)
                .HasColumnName("hora_fim");

            Property(c => c.Dom)
                .HasColumnName("dom");

            Property(c => c.Seg)
                .HasColumnName("seg");

            Property(c => c.Ter)
                .HasColumnName("ter");

            Property(c => c.Qua)
                .HasColumnName("qua");

            Property(c => c.Qui)
                .HasColumnName("qui");

            Property(c => c.Sex)
                .HasColumnName("sex");

            Property(c => c.Sab)
                .HasColumnName("sab");

            Property(c => c.Ultimo)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnType("timestamp")
                .HasColumnName("ultimo");

            Property(c => c.Ip)
                .HasColumnName("ip");

            Property(c => c.QuantidadeMinuto)
                .HasColumnName("quantidade_minuto");

            Property(c => c.Token)
                .HasMaxLength(500)
                .HasColumnName("token")
                .IsUnicode(false);

            HasOptional(e => e.Profissional)
                .WithRequired(e => e.ProfissionalAcesso);
        }
    }
}