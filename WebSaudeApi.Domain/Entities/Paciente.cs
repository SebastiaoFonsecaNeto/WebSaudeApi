using System;
using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class Paciente
    {
        public Paciente()
        {
            Agenda = new HashSet<Agenda>();
            AgendaAparelho = new HashSet<AgendaAparelho>();
            Encaminhamento = new HashSet<Encaminhamento>();
            Odontograma = new HashSet<Odontograma>();
            PacienteConta = new HashSet<PacienteConta>();
            PacienteConvenio = new HashSet<PacienteConvenio>();
            PacienteImagem = new HashSet<PacienteImagem>();
            PacienteMatmed = new HashSet<PacienteMatmed>();
            PacienteProcedimento = new HashSet<PacienteProcedimento>();
            PacienteProntuarioUnidade = new HashSet<PacienteProntuarioUnidade>();
            ProntoAtendimento = new HashSet<ProntoAtendimento>();
            ProntuarioClinico = new HashSet<ProntuarioClinico>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Sexo { get; set; }
        public string Cpf { get; set; }
        public string Cns { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int? CelularOperadoraId { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public int? Dependente { get; set; }
        public string Responsavel { get; set; }
        public virtual ICollection<Agenda> Agenda { get; set; }
        public virtual ICollection<AgendaAparelho> AgendaAparelho { get; set; }
        public virtual CelularOperadora CelularOperadora { get; set; }
        public virtual ICollection<Encaminhamento> Encaminhamento { get; set; }
        public virtual ICollection<Odontograma> Odontograma { get; set; }
        public virtual ICollection<PacienteConta> PacienteConta { get; set; }
        public virtual ICollection<PacienteConvenio> PacienteConvenio { get; set; }
        public virtual ICollection<PacienteImagem> PacienteImagem { get; set; }
        public virtual ICollection<PacienteMatmed> PacienteMatmed { get; set; }
        public virtual ICollection<PacienteProcedimento> PacienteProcedimento { get; set; }
        public virtual ICollection<PacienteProntuarioUnidade> PacienteProntuarioUnidade { get; set; }
        public virtual ICollection<ProntoAtendimento> ProntoAtendimento { get; set; }
        public virtual ICollection<ProntuarioClinico> ProntuarioClinico { get; set; }
    }
}