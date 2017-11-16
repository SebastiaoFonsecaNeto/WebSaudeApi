using Ninject;
using WebSaude.Domain.Interfaces.Repositories;
using WebSaude.Infra.Data.Repositories;

namespace WebSaude.Startup.Repository
{
    public class RegisterRepository
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind(typeof (IRepositoryBase<>)).To(typeof (RepositoryBase<>));
            kernel.Bind<IPacienteRepository>().To<PacienteRepository>();
            kernel.Bind<IProfissionalRepository>().To<ProfissionalRepository>();
            kernel.Bind<IProfissionalAcessoRepository>().To<ProfissionalAcessoRepository>();
            kernel.Bind<IWebControleRepository>().To<WebControleRepository>();
        }
    }
}