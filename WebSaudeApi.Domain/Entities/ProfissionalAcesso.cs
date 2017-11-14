using System;

namespace WebSaude.Domain.Entities
{
    public class ProfissionalAcesso
    {
        public int ProfissionalId { get; set; }
        public int PermissaoId { get; set; }
        public string Senha { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFim { get; set; }
        public bool? Dom { get; set; }
        public bool? Seg { get; set; }
        public bool? Ter { get; set; }
        public bool? Qua { get; set; }
        public bool? Qui { get; set; }
        public bool? Sex { get; set; }
        public bool? Sab { get; set; }
        public DateTime Ultimo { get; set; }
        public int? Ip { get; set; }
        public int? QuantidadeMinuto { get; set; }
        public string Token { get; set; }
        public virtual Profissional Profissional { get; set; }
        public virtual Permissao Permissao { get; set; }
    }
}