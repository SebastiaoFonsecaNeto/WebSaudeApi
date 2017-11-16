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
    public class AuthLogin : ActionFilterAttribute
    {
        private readonly WebControleRepository _webControleRepositorio;

        public AuthLogin()
        {
            _webControleRepositorio = new WebControleRepository();
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var ip = HttpContext.Current != null ? Convert.ToInt32(HttpContext.Current.Request.UserHostAddress) : 0;

            var webcontrole = _webControleRepositorio.ConsultarPorIp(ip);

            if (webcontrole == null)
            {
                webcontrole = new WebControle
                {
                    Ip = ip,
                    QuantidadeMinuto = 1,
                    Ultimo = DateTime.Now
                };

                try
                {
                    _webControleRepositorio.Add(webcontrole);
                }
                catch (Exception)
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized,
                        "Erro de conexão com o servidor contate o Administrador!");
                }
            }
            else
            {
                if (webcontrole.QuantidadeMinuto < 10)
                {
                    if (webcontrole.Ultimo.Minute == DateTime.Now.Minute)
                        webcontrole.QuantidadeMinuto++;
                    else
                        webcontrole.QuantidadeMinuto = 0;
                    webcontrole.Ultimo = DateTime.Now;

                    try
                    {
                        _webControleRepositorio.Update(webcontrole);
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
                        "Acesso bloqueado devido a quantidade excessiva de acessos ao servidor!");
            }
        }
    }
}