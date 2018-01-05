using System.Collections.Generic;
using WebSaude.Domain.Commands;

namespace WebSaude.Domain.Entities
{
    public class Profissional
    {
        public Profissional()
        {
            Agenda = new HashSet<Agenda>();
            Encaminhamento = new HashSet<Encaminhamento>();
            Log = new HashSet<Log>();
            ProfissionalUnidade = new HashSet<ProfissionalUnidade>();
            ProntoAtendimento = new HashSet<ProntoAtendimento>();
            ProntuarioClinico = new HashSet<ProntuarioClinico>();
        }

        public int Id { get; set; }
        public int CboId { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int? CelularOperadoraId { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public bool Ativo { get; set; }
        public string Observacao { get; set; }
        public virtual ICollection<Agenda> Agenda { get; set; }
        public virtual Cbo Cbo { get; set; }
        public virtual CelularOperadora CelularOperadora { get; set; }
        public virtual ICollection<Encaminhamento> Encaminhamento { get; set; }
        public virtual ICollection<Log> Log { get; set; }
        public virtual ProfissionalAcesso ProfissionalAcesso { get; set; }
        public virtual ProfissionalClinico ProfissionalClinico { get; set; }
        public virtual ProfissionalPagamento ProfissionalPagamento { get; set; }
        public virtual ICollection<ProfissionalUnidade> ProfissionalUnidade { get; set; }
        public virtual ICollection<ProntoAtendimento> ProntoAtendimento { get; set; }
        public virtual ICollection<ProntuarioClinico> ProntuarioClinico { get; set; }

        public static Profissional Criar(ProfissionalCommand profissionalNovo)
        {
            return new Profissional
            {
                CboId = profissionalNovo.CboId,
                Nome = profissionalNovo.Nome,
                Documento = profissionalNovo.Documento,
                Email = profissionalNovo.Email,
                Telefone = profissionalNovo.Telefone,
                Celular = profissionalNovo.Celular,
                CelularOperadoraId = profissionalNovo.CelularOperadoraId,
                Endereco = profissionalNovo.Endereco,
                Numero = profissionalNovo.Numero,
                Complemento = profissionalNovo.Complemento,
                Bairro = profissionalNovo.Bairro,
                Cidade = profissionalNovo.Cidade,
                Estado = profissionalNovo.Estado,
                Cep = profissionalNovo.Cep,
                Ativo = profissionalNovo.Ativo,
                Observacao = profissionalNovo.Observacao
            };
        }

        public static void Alterar(Profissional profissional, ProfissionalCommand profissionalAlterado)
        {
            profissional.CboId = profissionalAlterado.CboId;
            profissional.Nome = profissionalAlterado.Nome;
            profissional.Documento = profissionalAlterado.Documento;
            profissional.Email = profissionalAlterado.Email;
            profissional.Telefone = profissionalAlterado.Telefone;
            profissional.Celular = profissionalAlterado.Celular;
            profissional.CelularOperadoraId = profissionalAlterado.CelularOperadoraId;
            profissional.Endereco = profissionalAlterado.Endereco;
            profissional.Numero = profissionalAlterado.Numero;
            profissional.Complemento = profissionalAlterado.Complemento;
            profissional.Bairro = profissionalAlterado.Bairro;
            profissional.Cidade = profissionalAlterado.Cidade;
            profissional.Estado = profissionalAlterado.Estado;
            profissional.Cep = profissionalAlterado.Cep;
            profissional.Ativo = profissionalAlterado.Ativo;
            profissional.Observacao = profissionalAlterado.Observacao;
        }
    }
}