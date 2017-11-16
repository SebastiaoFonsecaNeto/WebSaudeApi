using WebSaude.Domain.Entities;

namespace WebSaude.Domain.Interfaces.Repositories
{
    public interface IWebControleRepository : IRepositoryBase<WebControle>
    {
        WebControle ConsultarPorIp(int ip);
    }
}