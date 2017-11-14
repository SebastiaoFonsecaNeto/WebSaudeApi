using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebSaude.Domain.Entities;

namespace WebSaude.Infra.Data.EntityConfig
{
    public class GuiaTissSpsadtConfiguration : EntityTypeConfiguration<GuiaTissSpsadt>
    {
        public GuiaTissSpsadtConfiguration()
        {
            ToTable("guia_tiss_spsadt");

            HasKey(c => c.GuiaTissId);

            Property(c => c.GuiaTissId)
                .IsRequired()
                .HasColumnName("guia_tiss_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(c => c.DataAutorizacao)
                .HasColumnType("date")
                .HasColumnName("data_autorizacao");

            Property(c => c.DataValidadeSenha)
                .HasColumnType("date")
                .HasColumnName("data_validade_senha");

            Property(c => c.ValorTotal)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_total");

            Property(c => c.CaraterAtendimentoId)
                .IsRequired()
                .HasColumnName("ans_carater_atendimento_id");

            Property(c => c.SolicitacaoData)
                .HasColumnType("date")
                .HasColumnName("solicitacao_data");

            Property(c => c.IndicacaoClinica)
                .HasMaxLength(500)
                .HasColumnName("indicacao_clinica")
                .IsUnicode(false);

            Property(c => c.SolicitanteCodigoOperadora)
                .HasMaxLength(14)
                .HasColumnName("solicitante_codigo_operadora")
                .IsUnicode(false);

            Property(c => c.SolicitanteCnpj)
                .HasMaxLength(14)
                .HasColumnName("solicitante_cnpj")
                .IsUnicode(false);

            Property(c => c.SolicitanteCpf)
                .HasMaxLength(11)
                .HasColumnName("solicitante_cpf")
                .IsUnicode(false);

            Property(c => c.SolicitanteNome)
                .HasMaxLength(70)
                .HasColumnName("solicitante_nome")
                .IsUnicode(false);

            Property(c => c.ProfSolicNome)
                .HasMaxLength(70)
                .HasColumnName("prof_solic_nome")
                .IsUnicode(false);

            Property(c => c.ProfSolicCodConselhoId)
                .IsRequired()
                .HasColumnName("prof_solic_conselho_id");

            Property(c => c.ProfSolicNumeroConselho)
                .HasMaxLength(15)
                .HasColumnName("prof_solic_numero_conselho")
                .IsUnicode(false);

            Property(c => c.ProfSolicUfConselhoId)
                .IsRequired()
                .HasColumnName("prof_solic_uf_conselho_id");

            Property(c => c.ProfSolicCbo)
                .HasMaxLength(6)
                .HasColumnName("prof_solic_cbo")
                .IsUnicode(false);

            Property(c => c.IndicadorAcidenteId)
                .IsRequired()
                .HasColumnName("ans_indicador_acidente_id");

            Property(c => c.DataAtendimento)
                .HasColumnType("date")
                .HasColumnName("data_atendimento");

            Property(c => c.TipoConsultaId)
                .IsRequired()
                .HasColumnName("ans_tipo_consulta_id");

            Property(c => c.ObservacaoJustificativa)
                .HasMaxLength(500)
                .HasColumnName("observacao_justificativa")
                .IsUnicode(false);

            Property(c => c.MotivoEncerramentoObitoId)
                .IsRequired()
                .HasColumnName("ans_motivo_encerramento_obito_id");

            Property(c => c.ValorProcedimentos)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_procedimentos");

            Property(c => c.ValorTaxasAlugueis)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_taxas_alugueis");

            Property(c => c.ValorMateriais)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_materiais");

            Property(c => c.ValorMedicamentos)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_medicamentos");

            Property(c => c.ValorOpme)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_opme");

            Property(c => c.ValorGasesMedicinais)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_gases_medicinais");

            Property(c => c.ValorTotalGeral)
                .HasPrecision(10, 2)
                .HasColumnType("numeric")
                .HasColumnName("valor_total_geral");

            Property(c => c.TipoAtendimentoId)
                .IsRequired()
                .HasColumnName("ans_tipo_atendimento_id");

            HasOptional(e => e.GuiaTiss)
                .WithRequired(e => e.GuiaTissSpsadt);
        }
    }
}