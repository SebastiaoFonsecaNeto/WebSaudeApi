using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class GuiaTissHonorarioConfiguration : EntityTypeConfiguration<GuiaTissHonorario>
    {
        public GuiaTissHonorarioConfiguration()
        {
            ToTable("guia_tiss_honorario");

            HasKey(c => c.GuiaTissId);

            Property(c => c.GuiaTissId)
                .IsRequired()
                .HasColumnName("guia_tiss_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.DataEmissao)
                .HasColumnType("date")
                .HasColumnName("data_emissao");

            Property(c => c.Observacao)
                .HasMaxLength(500)
                .HasColumnName("observacao")
                .IsUnicode(false);

            Property(c => c.ValorTotal)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_total");

            Property(c => c.LocalCodigoOperadora)
                .HasMaxLength(14)
                .HasColumnName("local_codigo_operadora")
                .IsUnicode(false);

            Property(c => c.LocalCnpj)
                .HasMaxLength(14)
                .HasColumnName("local_cnpj")
                .IsUnicode(false);

            Property(c => c.LocalNome)
                .HasMaxLength(70)
                .HasColumnName("local_nome")
                .IsUnicode(false);

            Property(c => c.LocalCnes)
                .HasMaxLength(7)
                .HasColumnName("local_cnes")
                .IsUnicode(false);

            Property(c => c.DataInicioFaturamento)
                .HasColumnType("date")
                .HasColumnName("data_inicio_faturamento");

            Property(c => c.DataFinalFaturamento)
                .HasColumnType("date")
                .HasColumnName("data_final_faturamento");

            HasOptional(e => e.GuiaTiss)
                .WithRequired(e => e.GuiaTissHonorario);
        }
    }
}