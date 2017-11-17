using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebSaude.Domain.Entities;
using WebSaude.Infra.Data.EntityConfig;

namespace WebSaude.Infra.Data.Contexto
{
    public class WebSaudeContext : DbContext
    {
        public WebSaudeContext() : base("WebSaude")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<Agenda> Agenda { get; set; }
        public virtual DbSet<AgendaAparelho> AgendaAparelho { get; set; }
        public virtual DbSet<AnsCaraterAtendimento> AnsCaraterAtendimento { get; set; }
        public virtual DbSet<AnsConselhoRegional> AnsConselhoRegional { get; set; }
        public virtual DbSet<AnsDespesa> AnsDespesa { get; set; }
        public virtual DbSet<AnsGrauParticipacao> AnsGrauParticipacao { get; set; }
        public virtual DbSet<AnsIndicadorAcidente> AnsIndicadorAcidente { get; set; }
        public virtual DbSet<AnsMotivoEncerramento> AnsMotivoEncerramento { get; set; }
        public virtual DbSet<AnsMotivoEncerramentoObito> AnsMotivoEncerramentoObito { get; set; }
        public virtual DbSet<AnsRegimeInternacao> AnsRegimeInternacao { get; set; }
        public virtual DbSet<AnsTecnica> AnsTecnica { get; set; }
        public virtual DbSet<AnsTipoAtendimento> AnsTipoAtendimento { get; set; }
        public virtual DbSet<AnsTipoConsulta> AnsTipoConsulta { get; set; }
        public virtual DbSet<AnsTipoFaturamento> AnsTipoFaturamento { get; set; }
        public virtual DbSet<AnsTipoInternacao> AnsTipoInternacao { get; set; }
        public virtual DbSet<AnsUnidadeFederacao> AnsUnidadeFederacao { get; set; }
        public virtual DbSet<AnsUnidadeMedida> AnsUnidadeMedida { get; set; }
        public virtual DbSet<AnsViaAcesso> AnsViaAcesso { get; set; }
        public virtual DbSet<Aparelho> Aparelho { get; set; }
        public virtual DbSet<Cbo> Cbo { get; set; }
        public virtual DbSet<CelularOperadora> CelularOperadora { get; set; }
        public virtual DbSet<Conselho> Conselho { get; set; }
        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<ContaCategoria> ContaCategoria { get; set; }
        public virtual DbSet<ContaTipo> ContaTipo { get; set; }
        public virtual DbSet<Convenio> Convenio { get; set; }
        public virtual DbSet<Encaminhamento> Encaminhamento { get; set; }
        public virtual DbSet<EstoqueGrupo> EstoqueGrupo { get; set; }
        public virtual DbSet<EstoqueKardex> EstoqueKardex { get; set; }
        public virtual DbSet<EstoqueLote> EstoqueLote { get; set; }
        public virtual DbSet<EstoqueProduto> EstoqueProduto { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<GuiaTiss> GuiaTiss { get; set; }
        public virtual DbSet<GuiaTissDespesa> GuiaTissDespesa { get; set; }
        public virtual DbSet<GuiaTissHonorario> GuiaTissHonorario { get; set; }
        public virtual DbSet<GuiaTissInternacao> GuiaTissInternacao { get; set; }
        public virtual DbSet<GuiaTissProcedimento> GuiaTissProcedimento { get; set; }
        public virtual DbSet<GuiaTissProfissional> GuiaTissProfissional { get; set; }
        public virtual DbSet<GuiaTissSpsadt> GuiaTissSpsadt { get; set; }
        public virtual DbSet<ImagemTipo> ImagemTipo { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LoteGuia> LoteGuia { get; set; }
        public virtual DbSet<NotaFiscal> NotaFiscal { get; set; }
        public virtual DbSet<NotaFiscalItem> NotaFiscalItem { get; set; }
        public virtual DbSet<Odontograma> Odontograma { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<PacienteConta> PacienteConta { get; set; }
        public virtual DbSet<PacienteConvenio> PacienteConvenio { get; set; }
        public virtual DbSet<PacienteImagem> PacienteImagem { get; set; }
        public virtual DbSet<PacienteMatmed> PacienteMatmed { get; set; }
        public virtual DbSet<PacienteProcedimento> PacienteProcedimento { get; set; }
        public virtual DbSet<PacienteProntuarioUnidade> PacienteProntuarioUnidade { get; set; }
        public virtual DbSet<Pagamento> Pagamento { get; set; }
        public virtual DbSet<Permissao> Permissao { get; set; }
        public virtual DbSet<PermissaoItem> PermissaoItem { get; set; }
        public virtual DbSet<PlanoContas> PlanoContas { get; set; }
        public virtual DbSet<Procedimento> Procedimento { get; set; }
        public virtual DbSet<ProcedimentoCboConvenio> ProcedimentoCboConvenio { get; set; }
        public virtual DbSet<ProcedimentoConvenio> ProcedimentoConvenio { get; set; }
        public virtual DbSet<ProcedimentoMatmed> ProcedimentoMatmed { get; set; }
        public virtual DbSet<Profissional> Profissional { get; set; }
        public virtual DbSet<ProfissionalAcesso> ProfissionalAcesso { get; set; }
        public virtual DbSet<ProfissionalClinico> ProfissionalClinico { get; set; }
        public virtual DbSet<ProfissionalPagamento> ProfissionalPagamento { get; set; }
        public virtual DbSet<ProfissionalUnidade> ProfissionalUnidade { get; set; }
        public virtual DbSet<ProntoAtendimento> ProntoAtendimento { get; set; }
        public virtual DbSet<ProntuarioClinico> ProntuarioClinico { get; set; }
        public virtual DbSet<Recibo> Recibo { get; set; }
        public virtual DbSet<Tela> Tela { get; set; }
        public virtual DbSet<Unidade> Unidade { get; set; }
        public virtual DbSet<WebControle> WebControle { get; set; }
        public virtual DbSet<Tuss> Tuss { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AgendaConfiguration());
            modelBuilder.Configurations.Add(new AgendaAparelhoConfiguration());
            modelBuilder.Configurations.Add(new AnsCaraterAtendimentoConfiguration());
            modelBuilder.Configurations.Add(new AnsConselhoRegionalConfiguration());
            modelBuilder.Configurations.Add(new AnsDespesaConfiguration());
            modelBuilder.Configurations.Add(new AnsGrauParticipacaoConfiguration());
            modelBuilder.Configurations.Add(new AnsIndicadorAcidenteConfiguration());
            modelBuilder.Configurations.Add(new AnsMotivoEncerramentoConfiguration());
            modelBuilder.Configurations.Add(new AnsMotivoEncerramentoObitoConfiguration());
            modelBuilder.Configurations.Add(new AnsRegimeInternacaoConfiguration());
            modelBuilder.Configurations.Add(new AnsTecnicaConfiguration());
            modelBuilder.Configurations.Add(new AnsTipoAtendimentoConfiguration());
            modelBuilder.Configurations.Add(new AnsTipoConsultaConfiguration());
            modelBuilder.Configurations.Add(new AnsTipoFaturamentoConfiguration());
            modelBuilder.Configurations.Add(new AnsTipoInternacaoConfiguration());
            modelBuilder.Configurations.Add(new AnsUnidadeFederacaoConfiguration());
            modelBuilder.Configurations.Add(new AnsUnidadeMedidaConfiguration());
            modelBuilder.Configurations.Add(new AnsViaAcessoConfiguration());
            modelBuilder.Configurations.Add(new AparelhoConfiguration());
            modelBuilder.Configurations.Add(new CelularOperadoraConfiguration());
            modelBuilder.Configurations.Add(new ConselhoConfiguration());
            modelBuilder.Configurations.Add(new ContaConfiguration());
            modelBuilder.Configurations.Add(new ContaCategoriaConfiguration());
            modelBuilder.Configurations.Add(new ContaTipoConfiguration());
            modelBuilder.Configurations.Add(new ConvenioConfiguration());
            modelBuilder.Configurations.Add(new EncaminhamentoConfiguration());
            modelBuilder.Configurations.Add(new EstoqueGrupoConfiguration());
            modelBuilder.Configurations.Add(new EstoqueKardexConfiguration());
            modelBuilder.Configurations.Add(new EstoqueLoteConfiguration());
            modelBuilder.Configurations.Add(new EstoqueProdutoConfiguration());
            modelBuilder.Configurations.Add(new FornecedorConfiguration());
            modelBuilder.Configurations.Add(new GuiaTissConfiguration());
            modelBuilder.Configurations.Add(new GuiaTissDespesaConfiguration());
            modelBuilder.Configurations.Add(new GuiaTissHonorarioConfiguration());
            modelBuilder.Configurations.Add(new GuiaTissInternacaoConfiguration());
            modelBuilder.Configurations.Add(new GuiaTissProcedimentoConfiguration());
            modelBuilder.Configurations.Add(new GuiaTissProfissionalConfiguration());
            modelBuilder.Configurations.Add(new GuiaTissSpsadtConfiguration());
            modelBuilder.Configurations.Add(new ImagemTipoConfiguration());
            modelBuilder.Configurations.Add(new LogConfiguration());
            modelBuilder.Configurations.Add(new LoteGuiaConfiguration());
            modelBuilder.Configurations.Add(new NotaFiscalConfiguration());
            modelBuilder.Configurations.Add(new NotaFiscalItemConfiguration());
            modelBuilder.Configurations.Add(new OdontogramaConfiguration());
            modelBuilder.Configurations.Add(new PacienteConfiguration());
            modelBuilder.Configurations.Add(new PacienteContaConfiguration());
            modelBuilder.Configurations.Add(new PacienteConvenioConfiguration());
            modelBuilder.Configurations.Add(new PacienteImagemConfiguration());
            modelBuilder.Configurations.Add(new PacienteMatmedConfiguration());
            modelBuilder.Configurations.Add(new PacienteProcedimentoConfiguration());
            modelBuilder.Configurations.Add(new PacienteProntuarioUnidadeConfiguration());
            modelBuilder.Configurations.Add(new PagamentoConfiguration());
            modelBuilder.Configurations.Add(new PermissaoConfiguration());
            modelBuilder.Configurations.Add(new PermissaoItemConfiguration());
            modelBuilder.Configurations.Add(new PlanoContasConfiguration());
            modelBuilder.Configurations.Add(new ProcedimentoConfiguration());
            modelBuilder.Configurations.Add(new ProcedimentoCboConvenioConfiguration());
            modelBuilder.Configurations.Add(new ProcedimentoConvenioConfiguration());
            modelBuilder.Configurations.Add(new ProcedimentoMatmedConfiguration());
            modelBuilder.Configurations.Add(new ProfissionalConfiguration());
            modelBuilder.Configurations.Add(new ProfissionalAcessoConfiguration());
            modelBuilder.Configurations.Add(new ProfissionalClinicoConfiguration());
            modelBuilder.Configurations.Add(new ProfissionalPagamentoConfiguration());
            modelBuilder.Configurations.Add(new ProfissionalUnidadeConfiguration());
            modelBuilder.Configurations.Add(new ProntoAtendimentoConfiguration());
            modelBuilder.Configurations.Add(new ProntuarioClinicoConfiguration());
            modelBuilder.Configurations.Add(new ReciboConfiguration());
            modelBuilder.Configurations.Add(new TelaConfiguration());
            modelBuilder.Configurations.Add(new UnidadeConfiguration());
            modelBuilder.Configurations.Add(new WebControleConfiguration());
            modelBuilder.Configurations.Add(new TussConfiguration());
        }
    }
}