using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebSaude.Domain.Entities;
using WebSaude.Infra.Data.Repositories;

namespace WebSaude.Api
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class Auth : ActionFilterAttribute
    {
        private readonly ProfissionalAcessoRepository _profissionalAcessoRepositorio;
        private ProfissionalAcesso _profissionalAcesso;

        public Auth()
        {
            _profissionalAcessoRepositorio = new ProfissionalAcessoRepository();
            _profissionalAcesso = new ProfissionalAcesso();
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext == null)
                actionContext = new HttpActionContext();

            var token = actionContext.Request?.Headers?.Authorization?.Scheme;

            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Sem token de autenticação!");
                return;
            }

            _profissionalAcesso = _profissionalAcessoRepositorio.ConsultAcessoPorToken(token);

            if (_profissionalAcesso == null)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Token de autenticação inválido!");
                return;
            }

            if (_profissionalAcesso.QuantidadeMinuto < 50)
            {
                if (Convert.ToDateTime(_profissionalAcesso.Ultimo).AddHours(1) > DateTime.Now)
                {
                    if (Convert.ToDateTime(_profissionalAcesso.Ultimo).Minute == DateTime.Now.Minute)
                        _profissionalAcesso.QuantidadeMinuto++;
                    else
                        _profissionalAcesso.QuantidadeMinuto = 0;

                    _profissionalAcesso.Ultimo = DateTime.Now;
                    _profissionalAcesso.Ip = HttpContext.Current != null
                        ? Convert.ToInt32(HttpContext.Current.Request.UserHostAddress)
                        : 0;

                    try
                    {
                        _profissionalAcessoRepositorio.Update(_profissionalAcesso);
                    }
                    catch (Exception)
                    {
                        actionContext.Response =
                            actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                                "Erro de conexão com o servidor contate o Administrador!");
                    }
                }
                else
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                        "Token expirado!");
            }
            else
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                    "Acesso bloqueado devido a quantidade excessiva de acessos ao servidor!");
        }
    }
}