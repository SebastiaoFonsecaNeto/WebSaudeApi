using WebSaude.Domain.Entities;

namespace WebSaude.Domain.Interfaces.Services
{
    public interface IProfissionalAcessoService : IServiceBase<ProfissionalAcesso>
    {
        string Login(string email, string senha);
    }
}