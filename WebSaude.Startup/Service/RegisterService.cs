using Ninject;
using WebSaude.Domain.Interfaces.Services;
using WebSaude.Service;

namespace WebSaude.Startup.Service
{
    public class RegisterService
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));

            kernel.Bind<IPacienteService>().To<PacienteService>();
            kernel.Bind<IProfissionalAcessoService>().To<ProfissionalAcessoService>();
            kernel.Bind<IProfissionalService>().To<ProfissionalService>();
        }
    }
}