using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsCaraterAtendimentoConfiguration : EntityTypeConfiguration<AnsCaraterAtendimento>
    {
        public AnsCaraterAtendimentoConfiguration()
        {
            ToTable("ans_carater_atendimento");

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

            HasMany(e => e.GuiaTissInternacao)
                .WithRequired(e => e.AnsCaraterAtendimento)
                .HasForeignKey(e => e.AnsCaraterAtendimentoId)
                .WillCascadeOnDelete(false);

            HasMany(e => e.GuiaTissSpsadt)
                .WithRequired(e => e.AnsCaraterAtendimento)
                .HasForeignKey(e => e.CaraterAtendimentoId)
                .WillCascadeOnDelete(false);
        }
    }
}