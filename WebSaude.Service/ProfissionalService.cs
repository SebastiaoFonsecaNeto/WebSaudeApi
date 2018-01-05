using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;
using WebSaude.Domain.Interfaces.Services;

namespace WebSaude.Service
{
    public class ProfissionalService : ServiceBase<Profissional>, IProfissionalService
    {
        private readonly IProfissionalRepository _profissionalRepository;

        public ProfissionalService(IProfissionalRepository profissionalRepository)
            : base(profissionalRepository)
        {
            _profissionalRepository = profissionalRepository;
        }
    }
}