using WebSaude.Application.Interface;
using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Services;

namespace WebSaude.Application
{
    public class PacienteAppService : AppServiceBase<Paciente>, IPacienteAppService
    {
        private readonly IPacienteService _pacienteService;

        public PacienteAppService(IPacienteService pacienteService)
            : base(pacienteService)
        {
            _pacienteService = pacienteService;
        }
    }
}