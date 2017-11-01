using WebSaude.Domain.Interfaces.Services;
using Ninject;
using WebSaude.Application;
using WebSaude.Application.Interface;
using WebSaude.Service;

namespace WebSaude.Startup.Service
{
    public class RegisterService
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));

            kernel.Bind<IPacienteService>().To<PacienteService>();
            kernel.Bind<IPacienteAppService>().To<PacienteAppService>();
        }
    }
}
