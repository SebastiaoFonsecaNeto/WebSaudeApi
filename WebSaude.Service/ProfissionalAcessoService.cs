using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;
using WebSaude.Domain.Interfaces.Services;

namespace WebSaude.Service
{
    public class ProfissionalAcessoService : ServiceBase<ProfissionalAcesso>, IProfissionalAcessoService
    {
        private readonly IProfissionalAcessoRepository _profissionalAcessoRepository;

        public ProfissionalAcessoService(IProfissionalAcessoRepository profissionalAcessoRepository)
            : base(profissionalAcessoRepository)
        {
            _profissionalAcessoRepository = profissionalAcessoRepository;
        }

        public string Login(string email, string senha)
        {
            return _profissionalAcessoRepository.Login(email, senha);
        }

        public bool Logout(string email)
        {
            return _profissionalAcessoRepository.Logout(email);
        }
    }
}