﻿using WebSaude.Domain.Entities;
using WebSaude.Domain.Interfaces.Repositories;

namespace WebSaude.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}