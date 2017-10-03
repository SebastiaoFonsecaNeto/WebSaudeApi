using System;
using System.Web.Http;
using WebSaude.Application.Interface;

namespace WebSaude.Api.Controllers
{
    [RoutePrefix("")]
    public class ClientesController: ApiController
    {
        private readonly IClienteAppService _clienteApp;
        
        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        /// <summary>
        /// Listar todos os clientes cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("clientes")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var clientes = _clienteApp.GetAll();
                if (clientes == null)
                {
                    return NotFound();
                }

                return Ok(clientes);
            }
            catch (Exception e)
            {
                throw new Exception("erro consultar :" + e.Message);
            }
        }

    }
}