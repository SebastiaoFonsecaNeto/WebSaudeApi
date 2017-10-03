using WebSaude.Application.Interface;
using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Services;

namespace WebSaude.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }
    }
}
