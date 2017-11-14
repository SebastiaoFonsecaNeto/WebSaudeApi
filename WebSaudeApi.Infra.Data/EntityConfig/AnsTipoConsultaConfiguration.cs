using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsTipoConsultaConfiguration : EntityTypeConfiguration<AnsTipoConsulta>
    {
        public AnsTipoConsultaConfiguration()
        {
            ToTable("ans_tipo_consulta");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .IsUnicode(false);

            Property(c => c.TermoTiss)
                .HasColumnName("termo_tiss");

            HasMany(e => e.Agenda)
                .WithRequired(e => e.AnsTipoConsulta)
                .HasForeignKey(e => e.AnsConsultaId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.GuiaTissSpsadt)
                .WithRequired(e => e.AnsTipoConsulta)
                .HasForeignKey(e => e.TipoConsultaId)
                .WillCascadeOnDelete(false);
        }
    }
}