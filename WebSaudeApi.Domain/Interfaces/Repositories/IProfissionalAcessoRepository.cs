using WebSaude.Domain.Entities;

namespace WebSaude.Domain.Interfaces.Repositories
{
    public interface IProfissionalAcessoRepository : IRepositoryBase<ProfissionalAcesso>
    {
        ProfissionalAcesso ConsultAcessoPorToken(string token);

        string Login(string email, string senha);
    }
}