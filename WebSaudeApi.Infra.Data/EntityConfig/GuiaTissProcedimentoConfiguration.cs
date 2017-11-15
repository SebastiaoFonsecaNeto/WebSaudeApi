using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class GuiaTissProcedimentoConfiguration : EntityTypeConfiguration<GuiaTissProcedimento>
    {
        public GuiaTissProcedimentoConfiguration()
        {
            ToTable("guia_tiss_procedimento");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.GuiaTissId)
                .IsRequired()
                .HasColumnName("guia_tiss_id");

            Property(c => c.ProcedimentoTabela)
                .HasColumnName("procedimento_tabela");

            Property(c => c.ProcedimentoCodigo)
                .HasColumnName("procedimento_codigo");

            Property(c => c.ProcedimentoDescricao)
                .HasMaxLength(300)
                .HasColumnName("procedimento_descricao")
                .IsUnicode(false);

            Property(c => c.Quantidade)
                .HasPrecision(3, 0)
                .HasColumnType("numeric")
                .HasColumnName("quantidade");

            Property(c => c.AnsViaId)
                .IsRequired()
                .HasColumnName("ans_via_id");

            Property(c => c.AnsTecnicaId)
                .IsRequired()
                .HasColumnName("ans_tecnica_id");

            Property(c => c.ReducaoAcrescimo)
                .HasPrecision(3, 2)
                .HasColumnType("numeric")
                .HasColumnName("reducao_acrescimo");

            Property(c => c.ValorUnitario)
                .HasPrecision(8, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_unitario");

            Property(c => c.ValorTotal)
                .HasPrecision(8, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_total");

            Property(c => c.Data)
                .HasColumnType("date")
                .HasColumnName("data_execucao");

            Property(c => c.HoraInicial)
                .HasColumnName("hora_inicial");

            Property(c => c.HoraFinal)
                .HasColumnName("hora_final");

            HasMany(e => e.GuiaTissProfissional)
                .WithRequired(e => e.GuiaTissProcedimento)
                .HasForeignKey(e => e.GuiaTissProcedimentoId)
                .WillCascadeOnDelete(false);
        }
    }
}