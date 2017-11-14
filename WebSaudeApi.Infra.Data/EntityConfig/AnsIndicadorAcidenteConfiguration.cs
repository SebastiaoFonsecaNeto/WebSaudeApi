using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsIndicadorAcidenteConfiguration : EntityTypeConfiguration<AnsIndicadorAcidente>
    {
        public AnsIndicadorAcidenteConfiguration()
        {
            ToTable("ans_indicador_acidente");

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
                .WithRequired(e => e.AnsIndicadorAcidente)
                .HasForeignKey(e => e.AnsAcidenteId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.GuiaTissInternacao)
                .WithRequired(e => e.AnsIndicadorAcidente)
                .HasForeignKey(e => e.AnsIndicadorAcidenteId)
                .WillCascadeOnDelete(false);
        }
    }
}