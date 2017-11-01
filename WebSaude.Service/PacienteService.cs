using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;
using WebSaude.Domain.Interfaces.Services;

namespace WebSaude.Service
{
    public class PacienteService : ServiceBase<Paciente>, IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
            : base(pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }
    }
}