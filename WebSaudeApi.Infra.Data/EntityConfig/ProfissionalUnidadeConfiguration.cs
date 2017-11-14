using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class ProfissionalUnidadeConfiguration : EntityTypeConfiguration<ProfissionalUnidade>
    {
        public ProfissionalUnidadeConfiguration()
        {
            ToTable("profissional_unidade");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.ProfissionalId)
                .IsRequired()
                .HasColumnName("profissional_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.UnidadeId)
                .IsRequired()
                .HasColumnName("unidade_id");
        }
    }
}