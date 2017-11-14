using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class GuiaTissDespesaConfiguration : EntityTypeConfiguration<GuiaTissDespesa>
    {
        public GuiaTissDespesaConfiguration()
        {
            ToTable("guia_tiss_despesa");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .IsRequired()
                .HasColumnName("id");

            Property(c => c.GuiaTissId)
                .IsRequired()
                .HasColumnName("guia_tiss_id");

            Property(c => c.AnsDespesaId)
                .IsRequired()
                .HasColumnName("ans_despesa_id");

            Property(c => c.DataExecucao)
                .HasColumnType("date")
                .HasColumnName("data_execucao");

            Property(c => c.HoraInicial)
                .HasColumnName("hora_inicial");

            Property(c => c.HoraFinal)
                .HasColumnName("hora_final");

            Property(c => c.ProcedimentoTabela)
                .HasColumnName("procedimento_tabela");

            Property(c => c.ProcedimentoCodigo)
                .HasColumnName("procedimento_codigo");

            Property(c => c.ProcedimentoDescricao)
                .HasMaxLength(300)
                .HasColumnName("procedimento_descricao")
                .IsUnicode(false);

            Property(c => c.QuantidadeExecutada)
                .HasPrecision(7, 4)
                .HasColumnType("numeric")
                .HasColumnName("quantidade_executada");

            Property(c => c.AnsUnidadeMedidaId)
                .IsRequired()
                .HasColumnName("ans_unidade_medida_id");

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

            Property(c => c.RegistroAnvisa)
                .HasMaxLength(15)
                .HasColumnName("registro_anvisa")
                .IsUnicode(false);

            Property(c => c.CodigoRefFabricante)
                .HasMaxLength(60)
                .HasColumnName("codigo_ref_fabricante")
                .IsUnicode(false);

            Property(c => c.AutorizacaoFuncionamento)
                .HasMaxLength(30)
                .HasColumnName("autorizacao_funcionamento")
                .IsUnicode(false);
        }
    }
}