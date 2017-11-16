using System.Linq;
using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;

namespace WebSaude.Infra.Data.Repositories
{
    public class WebControleRepository : RepositoryBase<WebControle>, IWebControleRepository
    {
        public WebControle ConsultarPorIp(int ip)
        {
            return GetAll().FirstOrDefault(w => w.Ip == ip);
        }
    }
}