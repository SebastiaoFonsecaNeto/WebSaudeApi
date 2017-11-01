using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;

namespace WebSaude.Infra.Data.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>, IPacienteRepository
    {
    }
}