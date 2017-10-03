using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;
using WebSaude.Domain.Interfaces.Services;

namespace WebSaude.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
