using System;
using System.Data.Entity.Core;
using System.Linq;
using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;
using WebSaude.Domain.Resources;
using WebSaude.Domain.Utilitarios;

namespace WebSaude.Infra.Data.Repositories
{
    public class ProfissionalAcessoRepository : RepositoryBase<ProfissionalAcesso>, IProfissionalAcessoRepository
    {
        public ProfissionalAcesso ConsultAcessoPorToken(string token)
        {
            return GetAll().FirstOrDefault(p => p.Token == token);
        }

        public string Login(string email, string senha)
        {
            try
            {
                var profissional = GetAll().FirstOrDefault(p => p.Profissional.Email == email);

                if (profissional == null)
                    throw new Exception(ProfissionalResource.ProfissionalNaoCadastrado);

                if (profissional.Senha != senha)
                    throw new Exception(ProfissionalResource.SenhaInvalida);

                profissional.Token = Util.GeraHash(profissional.Profissional.Id.ToString());
                profissional.Ultimo = DateTime.Now;

                Update(profissional);

                return (profissional.Token);
            }
            catch (EntitySqlException erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}