using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class AnsTecnicaConfiguration : EntityTypeConfiguration<AnsTecnica>
    {
        public AnsTecnicaConfiguration()
        {
            ToTable("ans_tecnica");

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

            HasMany(e => e.GuiaTissProcedimento)
                .WithRequired(e => e.AnsTecnica)
                .HasForeignKey(e => e.AnsTecnicaId)
                .WillCascadeOnDelete(false);
        }
    }
}