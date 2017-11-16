using System.Linq;
using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;

namespace WebSaude.Infra.Data.Repositories
{
    public class ProfissionalAcessoRepository : RepositoryBase<ProfissionalAcesso>, IProfissionalAcessoRepository
    {
        public ProfissionalAcesso ConsultAcessoPorToken(string token)
        {
            return GetAll().FirstOrDefault(p => p.Token == token);
        }
    }
}