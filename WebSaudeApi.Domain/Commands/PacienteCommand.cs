using System;

namespace WebSaude.Domain.Commands
{
    public class PacienteCommand
    {
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
    }
}